import React from "react";
import Home from "./components/Home";
import Edit from "./components/Edit";
import New from "./components/New";

const AppRoutes = [
  {
    path: "/",
    element: <Home />,
  },
  {
    path: "/edit",
    element: <Edit />,
  },
  {
    path: "/new",
    element: <New />,
  },
];

export default AppRoutes;
