import { Box, Flex } from '@chakra-ui/react'
import React from 'react'

const ARS = () => {
  return (
    <Flex alignItems="flex-end" fontSize="5xl" fontWeight="black" userSelect="none">
        <Box lineHeight="1" color="gray.300" mr="-9px">A</Box>
        <Box lineHeight="1" color="orange.400" mr="-9px">R</Box>
        <Box lineHeight="1" color="gray.800" mr="-2px">S</Box>
        <Box lineHeight="1.1" fontSize="3xl" color="gray.800">YS</Box>
    </Flex>
  )
}

export default ARS