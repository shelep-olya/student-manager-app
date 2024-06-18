import React from "react";
import Home from "./components/Home";
import Edit from "./components/Home";
import New from "./components/Home";

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
