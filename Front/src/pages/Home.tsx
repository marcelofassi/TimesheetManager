import { Card, CardContent, Grid, Typography, Stack, Chip } from "@mui/material";
import { AreaChart, Area, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer } from "recharts";

const chartData = [
  { name: "10am", sales: 400 }, { name: "11am", sales: 800 },
  { name: "12am", sales: 650 }, { name: "01am", sales: 300 },
  { name: "02am", sales: 520 }, { name: "03am", sales: 760 },
  { name: "04am", sales: 610 }, { name: "05am", sales: 900 },
  { name: "06am", sales: 720 }, { name: "07am", sales: 860 },
];

function StatCard({ title, value }: { title: string; value: string }) {
  return (
    <Card elevation={0} sx={{ borderRadius: 3 }}>
      <CardContent>
        <Typography variant="body2" color="text.secondary">{title}</Typography>
        <Typography variant="h5" fontWeight={700} sx={{ mt: .5 }}>{value}</Typography>
      </CardContent>
    </Card>
  );
}

export default function Home() {
  return (
    <Stack spacing={3}>
      <Typography variant="h5" fontWeight={700}>Bienvenido Marcelo 👋</Typography>

      <Grid container spacing={2}>
        <Grid item xs={12} md={6} lg={4}>
          <Card elevation={0} sx={{ borderRadius: 3 }}>
            <CardContent>
              <Typography variant="subtitle2" color="text.secondary">Reports</Typography>
              <Stack direction="row" spacing={1} sx={{ mt: 2 }}>
                <Chip label="Sale" color="primary" variant="outlined" />
                <Chip label="Distribute" color="secondary" variant="outlined" />
                <Chip label="Return" variant="outlined" />
              </Stack>
              <Typography sx={{ mt: 2 }} color="text.secondary">
                80% Transactions (mock)
              </Typography>
            </CardContent>
          </Card>
        </Grid>

        <Grid item xs={12} md={6} lg={8}>
          <Grid container spacing={2}>
            <Grid item xs={12} sm={6} md={3}><StatCard title="Proyectos Totales" value="178+" /></Grid>
            <Grid item xs={12} sm={6} md={3}><StatCard title="Past Due" value="$ 2100.45" /></Grid>
            <Grid item xs={12} sm={6} md={3}><StatCard title="Total Balance qty." value="100+" /></Grid>
            <Grid item xs={12} sm={6} md={3}><StatCard title="Total Vendors" value="24" /></Grid>
          </Grid>
        </Grid>
      </Grid>

      <Grid container spacing={2}>
        <Grid item xs={12} md={7}>
          <Card elevation={0} sx={{ height: 320, borderRadius: 3 }}>
            <CardContent sx={{ height: 1 }}>
              <Typography sx={{ mb: 2 }} variant="subtitle2" color="text.secondary">Reports</Typography>
              <ResponsiveContainer width="100%" height="85%">
                <AreaChart data={chartData}>
                  <defs>
                    <linearGradient id="c" x1="0" y1="0" x2="0" y2="1">
                      <stop offset="5%" stopColor="#1976d2" stopOpacity={0.4}/>
                      <stop offset="95%" stopColor="#1976d2" stopOpacity={0}/>
                    </linearGradient>
                  </defs>
                  <CartesianGrid strokeDasharray="3 3" />
                  <XAxis dataKey="name" />
                  <YAxis />
                  <Tooltip />
                  <Area type="monotone" dataKey="sales" stroke="#1976d2" fill="url(#c)" />
                </AreaChart>
              </ResponsiveContainer>
            </CardContent>
          </Card>
        </Grid>

        <Grid item xs={12} md={5}>
          <Card elevation={0} sx={{ borderRadius: 3 }}>
            <CardContent>
              <Typography variant="subtitle2" color="text.secondary" sx={{ mb: 2 }}>
                Gross calculations for:
              </Typography>
              <Stack spacing={1.5}>
                <StatCard title="2 Months ago" value="$ 43,332" />
                <StatCard title="Last Month" value="$ 23,240" />
                <StatCard title="This Month" value="$ 3,220" />
              </Stack>
            </CardContent>
          </Card>
        </Grid>
      </Grid>
    </Stack>
  );
}
