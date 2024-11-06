import React from "react";
import { useNavigate } from "react-router-dom";

import { Header } from "../../components/Header";
import { Container, TextContent, Title, TitleHighlight } from "./styles";
import { Button } from "../../components/Button";

import banner from "../../assets/banner.png";

const Home = () => {
    const navigate = useNavigate();

    const handleClickSignIn = () => {
        navigate("/login");
    };

    const handleClickSignUp = () => {
        navigate("/cadastro");
    };

    return (
        <div>
            <Header
                showHome={false}
                onClickEntrar={handleClickSignIn}
                onClickCadastrar={handleClickSignUp}
            />
            <Container>
                <section>
                    <Title>
                        <TitleHighlight>Implemente</TitleHighlight>
                        <br />o seu futuro global agora!
                    </Title>
                    <TextContent>
                        Domine as tecnologias utilizadas pelas empresas mais
                        inovadoras do mundo e encare seu novo desafio
                        profissional, evoluindo em comunidade com os melhores
                        experts.
                    </TextContent>
                    <Button
                        title="Começar agora"
                        variant="secondary"
                        onClick={handleClickSignIn}
                    ></Button>
                </section>
                <section>
                    <img src={banner} alt="Page banner" />
                </section>
            </Container>
        </div>
    );
};

export { Home };
