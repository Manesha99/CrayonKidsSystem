export class Employee{
    splice(arg0: number, arg1: number) {
      throw new Error('Method not implemented.');
    }
    id: number | undefined;

    constructor(
    public empType: string,
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