package ru.prkis.lab.auto.endpoint;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ws.server.endpoint.annotation.Endpoint;
import org.springframework.ws.server.endpoint.annotation.PayloadRoot;
import org.springframework.ws.server.endpoint.annotation.RequestPayload;
import org.springframework.ws.server.endpoint.annotation.ResponsePayload;
import ru.prkis.lab.auto.service.CarsService;
import ru.vyatgu.prkis.lab.auto.*;

@Endpoint
public class CarsEndpoint {
    private static final String NAMESPACE_URI = "http://vyatgu.ru/prkis/lab/auto";

    private final CarsService carsService;

    @Autowired
    public CarsEndpoint(CarsService carsService) {
        this.carsService = carsService;
    }

    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "getAddCarsRequest")
    @ResponsePayload
    public GetAddCarsResponse getAllCars(@RequestPayload GetAddCarsRequest request) throws Exception {
        GetAddCarsResponse response = new GetAddCarsResponse();
        response.setCars(carsService.addCars(request.getCars()));
        return response;
    }

    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "getCarsByIdRequest")
    @ResponsePayload
    public GetCarsByIdResponse getAllCars(@RequestPayload GetCarsByIdRequest request) throws Exception {
        GetCarsByIdResponse response = new GetCarsByIdResponse();
        response.setCars(carsService.getByID(request.getId()));
        return response;
    }

    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "getAllCarsRequest")
    @ResponsePayload
    public GetAllCarsResponse getAllCars(@RequestPayload GetAllCarsRequest request) throws Exception {
        GetAllCarsResponse response = new GetAllCarsResponse();
        response.getCars().addAll(carsService.getAll());
        return response;
    }
    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "getDeleteCarsRequest")
    @ResponsePayload
    public GetDeleteCarsResponse getDeleteCars(@RequestPayload GetDeleteCarsRequest request) throws Exception{
        GetDeleteCarsResponse response = new GetDeleteCarsResponse();
        response.setCars(carsService.delete(request.getId()));
        return response;
    }

    @PayloadRoot(namespace = NAMESPACE_URI, localPart = "getChangeCarsRequest")
    @ResponsePayload
    public GetChangeCarsResponse getChangeCars(@RequestPayload GetChangeCarsRequest request) throws Exception{
        GetChangeCarsResponse response = new GetChangeCarsResponse();
        response.setCars(carsService.changeCars(request.getCars()));
        return response;
    }
}