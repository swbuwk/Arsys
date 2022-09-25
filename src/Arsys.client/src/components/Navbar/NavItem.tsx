import { Box, Text } from '@chakra-ui/react'
import React, { FC } from 'react'
import { Link, useLocation } from 'react-router-dom'

interface NavItemProps {
    to: string,
    children?: React.ReactNode
}

const NavItem: FC<NavItemProps> = ({to, children}) => {

    const location = useLocation()

  return (
    <Box role="group" userSelect="none">
        <Link to={to}><Text transitionDuration="0.2s" color={location.pathname === to ? "orange.400" : "black"}>{children}</Text></Link>
        <Box _groupHover={{ width: "100%" }} transitionDuration="0.2s" bgColor="orange.400" w="0" h="2px"/>
    </Box>
  )
}

export default NavItem