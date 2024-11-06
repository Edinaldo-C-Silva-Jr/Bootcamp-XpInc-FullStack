import React from "react";
import { ButtonContainer } from "./styles";

// Recebe propriedades. A propriedade variant vem com um valor padrão.
const Button = ({ title, variant = "primary", onClick }) => {
    return (
        <ButtonContainer variant={variant} onClick={onClick}>
            {title}
        </ButtonContainer>
    );
};

export { Button };
