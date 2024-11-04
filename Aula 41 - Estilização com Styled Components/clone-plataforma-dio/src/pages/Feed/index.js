import React from "react";
import { Header } from "../../components/Header";
import { Card } from "../../components/Card";
import { Container, Column, Title, TitleHighlight } from "./styles";
import { UserInfo } from "../../components/UserInfo";

const Feed = () => {
    return (
        <div>
            <Header />
            <Container>
                <Column flex={3}>
                    <Title>Feed</Title>
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                </Column>
                <Column flex={1}>
                    <TitleHighlight># Ranking Top 5 da Semana</TitleHighlight>
                    <UserInfo
                        percentual={75}
                        nome="Edinaldo Silva"
                        image="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                    />
                    <UserInfo
                        percentual={55}
                        nome="Edinaldo Silva"
                        image="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                    />
                    <UserInfo
                        percentual={40}
                        nome="Edinaldo Silva"
                        image="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                    />
                    <UserInfo
                        percentual={25}
                        nome="Edinaldo Silva"
                        image="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                    />
                    <UserInfo
                        percentual={10}
                        nome="Edinaldo Silva"
                        image="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                    />
                </Column>
            </Container>
        </div>
    );
};

export { Feed };
