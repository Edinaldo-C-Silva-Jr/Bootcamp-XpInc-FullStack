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

const Card = ({
    username,
    imageLink,
    userImage,
    infoHeader,
    infoContent,
    time = "0 minutos",
    likes = 0,
    stacks = [],
}) => {
    return (
        <CardContainer>
            <ImageBackground src={imageLink} />
            <Content>
                <UserInfo>
                    <UserPicture src={userImage} />
                    <section>
                        <h4>{username}</h4>
                        <p>Há {time}.</p>
                    </section>
                </UserInfo>
                <PostInfo>
                    <h4>{infoHeader}</h4>
                    <p>
                        {infoContent}
                        <strong>... Saiba Mais</strong>
                    </p>
                </PostInfo>
                <HasInfo>
                    <h4>{stacks.map((stack) => `#${stack} `)}</h4>
                    <p>
                        <FiThumbsUp /> {likes}
                    </p>
                </HasInfo>
            </Content>
        </CardContainer>
    );
};

export { Card };
