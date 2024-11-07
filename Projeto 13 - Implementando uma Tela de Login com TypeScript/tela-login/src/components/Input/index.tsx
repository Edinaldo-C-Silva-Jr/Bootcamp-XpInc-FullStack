import { IInputProps } from "./types";
import { Container, ErrorMessage, InputContainer } from "./styles";
import { Controller } from "react-hook-form";

const Input = ({ control, name, errorMessage, ...rest }: IInputProps) => {
    return (
        <Container>
            <InputContainer>
                <Controller
                    control={control}
                    name={name}
                    render={({ field: { onChange, onBlur, value, ref } }) => (
                        <input
                            {...rest}
                            onChange={onChange}
                            onBlur={onBlur}
                            value={value}
                            ref={ref}
                        />
                    )}
                />
            </InputContainer>
            {errorMessage ? <ErrorMessage>{errorMessage}</ErrorMessage> : null}
        </Container>
    );
};

export default Input;
