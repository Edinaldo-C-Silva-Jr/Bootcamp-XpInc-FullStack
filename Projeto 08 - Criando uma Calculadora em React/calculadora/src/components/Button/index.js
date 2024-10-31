import { ButtonContainer } from "./styles";

const Button = ({label, onClick}) => {
    return (
      <ButtonContainer onClick={onclick}>
        {label}
      </ButtonContainer>
    );
  }
  
  export default Button;
  