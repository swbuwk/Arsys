import { Box, Button, Center, Flex, Heading, HStack, VStack } from '@chakra-ui/react'
import { FC } from 'react'
import ARS from '../ARS'
import NavItem from './NavItem'

const Navbar:FC = () => {
  return (
    <Center pos="fixed" zIndex="1000" w="100%" h="8vh" bgColor="white">
        <Flex w="70%" h="100%" alignItems="center" justifyContent="space-between">
            <ARS/>
            <HStack spacing="20px" color="black">
                <NavItem to="/home">Главная</NavItem>
                <NavItem to="/services">Сервисы</NavItem>
                <NavItem to="/about">О нас</NavItem>
            </HStack>
            <Button colorScheme="orange">
                Начать
            </Button>
        </Flex>
    </Center>
  )
}

export default Navbar