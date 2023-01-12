using AutoMapper;

public class ClientCredentialProfile: Profile{

public ClientCredentialProfile()
{
        CreateMap<ClientCredentialDto, ClientCredential>();

        CreateMap<ClientCredential, ClientCredentialDto>();
}

}