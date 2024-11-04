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
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://th.bing.com/th/id/OIP.XTIeUOHB_fSYyFELXefS3wHaHa?rs=1&pid=ImgDetMain"
                        time="10 minutos"
                        infoHeader="Projeto para curso de HTML e CSS."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={2}
                        stacks={["HTML", "CSS", "JavaScript"]}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://mildaintrainings.com/wp-content/uploads/2017/11/react-logo.png"
                        time="30 minutos"
                        infoHeader="Projeto para curso de React."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={5}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://th.bing.com/th/id/OIP.XTIeUOHB_fSYyFELXefS3wHaHa?rs=1&pid=ImgDetMain"
                        time="50 minutos"
                        infoHeader="Projeto para curso de HTML."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={12}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://wallpaperaccess.com/full/1555163.jpg"
                        time="2 horas"
                        infoHeader="Projeto para curso de JavaScript."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={7}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://mildaintrainings.com/wp-content/uploads/2017/11/react-logo.png"
                        time="3 horas"
                        infoHeader="Projeto para curso de React."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={5}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://th.bing.com/th/id/OIP.XTIeUOHB_fSYyFELXefS3wHaHa?rs=1&pid=ImgDetMain"
                        time="6 horas"
                        infoHeader="Projeto para curso de HTML e CSS."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={13}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://wallpaperaccess.com/full/1555163.jpg"
                        time="12 horas"
                        infoHeader="Projeto para curso de JavaScript."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={25}
                    />
                    <Card
                        username="Edinaldo Silva"
                        userImage="https://avatars.githubusercontent.com/u/122048298?v=4&size=64"
                        imageLink="https://th.bing.com/th/id/OIP.XTIeUOHB_fSYyFELXefS3wHaHa?rs=1&pid=ImgDetMain"
                        time="1 dia"
                        infoHeader="Projeto para curso de HTML."
                        infoContent="Projeto do bootcamp XP Inc - Desenvolvimento Full Stack..."
                        likes={30}
                    />
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
