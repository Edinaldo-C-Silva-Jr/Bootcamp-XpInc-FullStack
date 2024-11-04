import React from "react";
import { IconContainer, InputContainer, InputText } from "./styles";

const Input = ({ leftIcon, name, ...rest }) => {
    return (
        <InputContainer>
            {leftIcon ? ( // Só exibe o leftIcon se ele existir.
                <IconContainer>{leftIcon}</IconContainer>
            ) : null}
            <InputText {...rest} />
        </InputContainer>
    );
};

export { Input };
