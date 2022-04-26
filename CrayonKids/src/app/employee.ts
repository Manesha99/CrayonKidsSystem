export class Employee{
    id: number | undefined;

    constructor(
    public name: string,
    public surname: string,
    public birthDate: string,
    public hireDate: string,
    public email: string,
    public contactNr: string,
    public streetAddress: string,
    public address2: string,
    public province: string,
    public city: string,
    public postalCode: string,

    ){}
}