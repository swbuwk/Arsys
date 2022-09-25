import { Center, Flex, Grid, Heading } from '@chakra-ui/react'
import React from 'react'
import Section from '../components/Section'
import ServiceBlock from '../components/ServiceBlock'

const Services = () => {

    const services = [
        {
            title: "Cash desc",
            subtitle: "Кассовая станция",
            text: "Составление и оплата заказов, анализ доходов/расходов и многое другое",
            img: ""
        },
        {
            title: "Storage",
            subtitle: "Склад",
            text: "Контроль за продукцией, просмотр графика поставок",
            img: ""
        },
        {
            title: "Hall managment",
            subtitle: "Управление залом",
            text: "Конструктор зала, бронирование столиков и просмотр информации о столах",
            img: ""
        },
        {
            title: "Mobile waiter",
            subtitle: "Мобильный оффициант",
            text: "Принятие и обработка заказов, контроль над залом, информация о наличии продукции",
            img: ""
        }
    ]

  return (
    <Flex flexDir="column" alignItems="center" w="100%" color="white">
        <Section dir="column" col="gray.900">
            <Heading size="2xl" mb="30px">Сервисы</Heading>
            <Grid gridTemplateColumns="1fr 1fr" gap="40px">
                {services.map((service, key) => (
                    <ServiceBlock
                        {...service}
                        key={key}
                    />
                ))}
            </Grid>
        </Section>
    </Flex>
  )
}

export default Services