import ReactDOM from 'react-dom/client';
import './index.css';
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import Layout from './routes/Layout';
import Home from './routes/Home';
import { ChakraProvider } from '@chakra-ui/react';
import Services from './routes/Services';
import About from './routes/About';

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);

const router = createBrowserRouter([
  {
    path: "/",
    element: <Layout/>,
    children: [
      {
        path: "/home",
        element: <Home/>
      },
      {
        path: "/services",
        element: <Services/>
      },
      {
        path: "/about",
        element: <About/>
      }
    ]
  },
]);

root.render(
  <ChakraProvider>
    <RouterProvider router={router}/>
  </ChakraProvider>
);