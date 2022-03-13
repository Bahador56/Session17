namespace Session17.Models
{
    public enum StudentValidationTypes :int
    {
        Success=1,
        FirstNameIsNotValid=-1,
        LastNameIsNotValid=-2,
        BirthDateIsNotValid=-3,
        StudentNumberIsRequired=-4,
        StudentNumberIsDuplicated=-5,
        Error=-6

    }
}
