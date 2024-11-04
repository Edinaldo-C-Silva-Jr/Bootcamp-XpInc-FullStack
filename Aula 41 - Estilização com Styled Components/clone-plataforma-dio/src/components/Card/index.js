import React from "react";
import { FiThumbsUp } from "react-icons/fi";

import {
    CardContainer,
    Content,
    HasInfo,
    ImageBackground,
    PostInfo,
    UserInfo,
    UserPicture,
} from "./styles";

const Card = () => {
    return (
        <CardContainer>
            <ImageBackground />
            <Content>
                <UserInfo>
                    <UserPicture src="https://avatars.githubusercontent.com/u/122048298?v=4&size=64" />
                    <section>
                        <h4>Edinaldo Silva</h4>
                        <p>Há 8 minutos</p>
                    </section>
                </UserInfo>
                <PostInfo>
                    <h4>Projeto para curso de HTML e CSS.</h4>
                    <p>
                        Projeto feuto no curso de HTML e CSS no bootcamp XP Inc
                        - Desenvolvimento Full Stack...
                        <strong>Saiba Mais</strong>
                    </p>
                </PostInfo>
                <HasInfo>
                    <h4>#HTML #CSS #JavaScript</h4>
                    <p>
                        <FiThumbsUp /> 10
                    </p>
                </HasInfo>
            </Content>
        </CardContainer>
    );
};

export { Card };
