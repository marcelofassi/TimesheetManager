import {
  Box,
  Card,
  CardContent,
  Grid,
  Stack,
  Typography,
  TextField,
  InputAdornment,
  IconButton,
} from "@mui/material";
import MoreVertIcon from "@mui/icons-material/MoreVert";
import {
  PieChart,
  Pie,
  Cell,
  ResponsiveContainer,
  AreaChart,
  Area,
  XAxis,
  YAxis,
  Tooltip,
  CartesianGrid,
} from "recharts";

// -------- Mock data --------
const donutData = [
  { name: "Sale", value: 45, color: "#4F46E5" },
  { name: "Distribute", value: 35, color: "#06B6D4" },
  { name: "Return", value: 20, color: "#F59E0B" },
];

const kpis = [
  { title: "Total Products", value: "178+" },
  { title: "Past Due", value: "$ 2100.45" },
  { title: "Total Balance qty.", value: "100+" },
  { title: "Total Vendors", value: "24" },
  { title: "Total Outstanding", value: "$ 5400.67" },
  { title: "Due Soon", value: "$ 350" },
];

const lineData = [
  { name: "10am", sales: 78, returns: 22 },
  { name: "11am", sales: 65, returns: 30 },
  { name: "12am", sales: 40, returns: 18 },
  { name: "01am", sales: 25, returns: 14 },
  { name: "02am", sales: 50, returns: 20 },
  { name: "03am", sales: 62, returns: 26 },
  { name: "04am", sales: 58, returns: 21 },
  { name: "05am", sales: 80, returns: 35 },
  { name: "06am", sales: 66, returns: 28 },
  { name: "07am", sales: 88, returns: 40 },
];

// -------- Helpers --------
const CardSoft = ({ children, sx }: { children: React.ReactNode; sx?: any }) => (
  <Card
    elevation={0}
    sx={{
      borderRadius: 3,
      bgcolor: "background.paper",
      boxShadow:
        "0 2px 6px rgba(16,24,40,.05), 0 8px 24px rgba(16,24,40,.08)",
      ...sx,
    }}
  >
    <CardContent sx={{ p: 2.5 }}>{children}</CardContent>
  </Card>
);

const KpiPill = ({ title, value }: { title: string; value: string }) => (
  <CardSoft
    sx={{
      borderRadius: 4,
      "& .MuiTypography-h6": { fontWeight: 800 },
    }}
  >
    <Stack direction="row" alignItems="flex-start" spacing={2}>
      <Box sx={{ flexGrow: 1 }}>
        <Typography variant="body2" color="text.secondary">
          {title}
        </Typography>
        <Typography variant="h6" mt={0.5}>
          {value}
        </Typography>
      </Box>
      <IconButton size="small">
        <MoreVertIcon fontSize="small" />
      </IconButton>
    </Stack>
  </CardSoft>
);

// -------- Page --------
export default function Home() {
  return (
    <Stack spacing={3}>
      <Typography variant="h5" fontWeight={700}>
        Bienvenido Marcelo 👋
      </Typography>

      {/* Fila superior: Donut + KPIs principales (4) */}
      <Grid container spacing={2}>
        <Grid item xs={12} md={5} lg={4}>
          <CardSoft sx={{ height: { xs: 260, md: 220 } }}>
            <Stack
              direction="row"
              alignItems="center"
              justifyContent="space-between"
              mb={1.5}
            >
              <Typography variant="subtitle2" color="text.secondary">
                Reports
              </Typography>
              <IconButton size="small">
                <MoreVertIcon fontSize="small" />
              </IconButton>
            </Stack>

            <Box sx={{ height: "150px" }}>
              <ResponsiveContainer width="100%" height="100%">
                <PieChart>
                  <Pie
                    data={donutData}
                    innerRadius={45}
                    outerRadius={65}
                    paddingAngle={2}
                    dataKey="value"
                    startAngle={90}
                    endAngle={-270}
                  >
                    {donutData.map((d, i) => (
                      <Cell key={i} fill={d.color} />
                    ))}
                  </Pie>
                </PieChart>
              </ResponsiveContainer>
            </Box>

            <Stack direction="row" spacing={1} mt={1}>
              {donutData.map((d) => (
                <Stack
                  key={d.name}
                  direction="row"
                  spacing={0.75}
                  alignItems="center"
                  sx={{
                    px: 1,
                    py: 0.25,
                    borderRadius: 10,
                    border: "1px solid #eef0f4",
                  }}
                >
                  <Box
                    sx={{
                      width: 10,
                      height: 10,
                      borderRadius: "50%",
                      bgcolor: d.color,
                    }}
                  />
                  <Typography variant="caption" color="text.secondary">
                    {d.name}
                  </Typography>
                </Stack>
              ))}
            </Stack>

            <Typography variant="body2" color="text.secondary" mt={1.5}>
              80% Transactions (mock)
            </Typography>
          </CardSoft>
        </Grid>

        {/* KPIs en “pill cards” */}
        <Grid item xs={12} md={7} lg={8}>
          <Grid container spacing={2}>
            {kpis.slice(0, 4).map((k) => (
              <Grid item xs={12} sm={6} md={6} lg={3} key={k.title}>
                <KpiPill title={k.title} value={k.value} />
              </Grid>
            ))}
          </Grid>
        </Grid>
      </Grid>

      {/* Fila intermedia: Otros KPIs (2) */}
      <Grid container spacing={2}>
        {kpis.slice(4, 6).map((k) => (
          <Grid item xs={12} md={6} key={k.title}>
            <KpiPill title={k.title} value={k.value} />
          </Grid>
        ))}
      </Grid>

      {/* Fila inferior: línea + gross calculations */}
      <Grid container spacing={2}>
        <Grid item xs={12} md={7}>
          <CardSoft sx={{ height: 360 }}>
            <Stack
              direction="row"
              alignItems="center"
              justifyContent="space-between"
              mb={1.5}
            >
              <Typography variant="subtitle2" color="text.secondary">
                Reports
              </Typography>
              <IconButton size="small">
                <MoreVertIcon fontSize="small" />
              </IconButton>
            </Stack>

            <Box sx={{ height: "85%" }}>
              <ResponsiveContainer width="100%" height="100%">
                <AreaChart data={lineData} margin={{ top: 10, right: 20, left: 0, bottom: 0 }}>
                  <defs>
                    <linearGradient id="gradientSales" x1="0" y1="0" x2="0" y2="1">
                      <stop offset="0%" stopColor="#6366F1" stopOpacity={0.9} />
                      <stop offset="100%" stopColor="#6366F1" stopOpacity={0} />
                    </linearGradient>
                    <linearGradient id="gradientReturns" x1="0" y1="0" x2="0" y2="1">
                      <stop offset="0%" stopColor="#F59E0B" stopOpacity={0.9} />
                      <stop offset="100%" stopColor="#F59E0B" stopOpacity={0} />
                    </linearGradient>
                  </defs>

                  <CartesianGrid strokeDasharray="3 3" stroke="#E5E7EB" />
                  <XAxis dataKey="name" stroke="#9CA3AF" tick={{ fill: "#9CA3AF" }} />
                  <YAxis stroke="#9CA3AF" tick={{ fill: "#9CA3AF" }} />
                  <Tooltip />
                  <Area
                    type="monotone"
                    dataKey="sales"
                    stroke="#6366F1"
                    strokeWidth={3}
                    fill="url(#gradientSales)"
                  />
                  <Area
                    type="monotone"
                    dataKey="returns"
                    stroke="#F59E0B"
                    strokeWidth={3}
                    fill="url(#gradientReturns)"
                  />
                </AreaChart>
              </ResponsiveContainer>
            </Box>
          </CardSoft>
        </Grid>

        <Grid item xs={12} md={5}>
          <CardSoft sx={{ height: 360 }}>
            <Typography variant="subtitle1" fontWeight={700} mb={2}>
              Gross calculations for:
            </Typography>
            <Stack spacing={2}>
              <TextField
                label="2 Months ago"
                placeholder="$ 43,332"
                InputProps={{
                  startAdornment: <InputAdornment position="start">$</InputAdornment>,
                }}
              />
              <TextField
                label="Last Month"
                placeholder="$ 23,240"
                InputProps={{
                  startAdornment: <InputAdornment position="start">$</InputAdornment>,
                }}
              />
              <TextField
                label="This Month"
                placeholder="$ 3,220"
                InputProps={{
                  startAdornment: <InputAdornment position="start">$</InputAdornment>,
                }}
              />
            </Stack>
          </CardSoft>
        </Grid>
      </Grid>
    </Stack>
  );
}
