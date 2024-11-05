import React from "react";
import { useState } from "react";
import { Button, Container, Text } from "./styles";

const TesteUseState = () => {
    const [name, setName] = useState("João");

    const handleChangeName = () => {
        setName(prev => prev === "João" ? "Maria" : "João");
    };

    return (
        <Container>
            <Text>{name}</Text>
            <Button onClick={handleChangeName}>Alterar Nome</Button>
        </Container>
    );
};

export { TesteUseState };
