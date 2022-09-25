import { Box, Flex } from '@chakra-ui/react'
import React from 'react'
import { Outlet } from 'react-router-dom'
import Navbar from '../components/Navbar/Navbar'

const Layout = () => {
  return (
    <Flex w="100vw" h="100vh">
      <Navbar/>
      <Outlet/>
    </Flex>
  )
}

export default Layout