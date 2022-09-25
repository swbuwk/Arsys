import { Box, Button, Flex, Heading, Image, Text } from '@chakra-ui/react'
import React, {FC} from 'react'

interface ServiceBlockProps {
    title: string
    subtitle: string,
    text: string,
    img: string
}

const ServiceBlock:FC<ServiceBlockProps> = ({title, subtitle, text, img}) => {
  return (
    <Flex flexDir="column" justifyContent="space-between" p="30px" border="1px solid gray" boxShadow="2xl" transitionDuration="0.4s" _hover={{transform: "translateY(-5px)"}}>
        <Box>
            <Image src={img}/>
            <Box>
                <Heading size="lg">{title}</Heading>
                <Heading size="md" color="gray.300">{subtitle}</Heading>
            </Box>
            <Text>{text}</Text>
        </Box>
        <Button colorScheme="orange" mt="30px" w="30%">Подробнее</Button>
    </Flex>
  )
}

export default ServiceBlock