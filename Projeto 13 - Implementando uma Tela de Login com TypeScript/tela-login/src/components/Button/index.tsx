import { ButtonContainer } from "./styles";
import { IButtonProps } from "./types";

const Button = ({ isValid, title, onClick }: IButtonProps) => {
    return <ButtonContainer disabled={!isValid} onClick={onClick}>{title}</ButtonContainer>;
};

export default Button;
