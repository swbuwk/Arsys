import { Center, ChakraProps } from '@chakra-ui/react'
import React, {FC} from 'react'

interface SectionProps extends ChakraProps {
    h?: string,
    w?: string,
    col?: string,
    dir?: "row" | "column"
    children?: React.ReactNode
}

const Section: FC<SectionProps> = ({h = "100vh", w = "80vw", col = "white", dir="row", children}) => {
  return (
    <Center w="100%" h={h} bgColor={col}>
        <Center w={w} h={h} flexDir={dir}>
            {children}
        </Center>
    </Center>
  )
}

export default Section