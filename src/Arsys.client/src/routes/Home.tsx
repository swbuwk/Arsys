import { Box, Button, Center, Flex, Heading, Image, Text } from '@chakra-ui/react'
import React from 'react'
import { Link } from 'react-router-dom'
import Section from '../components/Section'

const Home = () => {
  return (
    <Flex flexDir="column" alignItems="center" w="100%" color="white">
      <Section col="gray.900">
        <Box w="50%">
          <Heading size="3xl" mb="50px">
            Управляйте свои заведением с <Text color="orange.300">максимальным комфортом.</Text>
          </Heading>
          <Button size="lg" w="250px" colorScheme="orange"><Link to="/services">Подробнее</Link></Button>
        </Box>
        <Image w="50%" src="https://www.pngall.com/wp-content/uploads/2/Meal-PNG-Download-Image.png"/>
      </Section>
      <Section>
        <Heading color="black">Content</Heading>
      </Section>
      <Section h="80vh" col="orange">
        <Heading color="white">Content</Heading>
      </Section>
    </Flex>
  )
}

export default Home