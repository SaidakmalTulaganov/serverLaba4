package ru.prkis.lab.auto.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import ru.prkis.lab.auto.entity.CarsEntity;
import ru.prkis.lab.auto.repository.CarsRepository;
import ru.vyatgu.prkis.lab.auto.Cars;

import java.util.ArrayList;
import java.util.List;

@Service
public class CarsService {

    @Autowired
    private CarsRepository carsRepository;

    private Cars mapEntityToBean(CarsEntity entity) {
        Cars bean = new Cars();
        bean.setIdCar(entity.getIdCar());
        bean.setIdBody(entity.getIdBody());
        bean.setIdManufacturer(entity.getIdManufacturer());
        bean.setYear(entity.getYear());
        bean.setPrice(entity.getPrice());
        bean.setQuantity(entity.getQuantity());
        bean.setDefective(entity.getDefective());
        return bean;
    }

    private CarsEntity mapBeanToEntity(Cars bean) {
        CarsEntity entity = new CarsEntity();
        entity.setIdCar(bean.getIdCar());
        entity.setIdBody(bean.getIdBody());
        entity.setIdManufacturer(bean.getIdManufacturer());
        entity.setYear(bean.getYear());
        entity.setPrice(bean.getPrice());
        entity.setQuantity(bean.getQuantity());
        entity.setDefective(bean.getDefective());
        return entity;
    }

    public List<Cars> getAll() {
        List<CarsEntity> carsFromBd = carsRepository.findAll();
        List<Cars> cars = new ArrayList<>();
        for (CarsEntity carsEntity : carsFromBd) {
            cars.add(mapEntityToBean(carsEntity));
        }
        return cars;
    }

    public Cars addCars(Cars newCars) {
        CarsEntity newCarsEntity = carsRepository.save(mapBeanToEntity(newCars));
        newCars.setIdCar(newCarsEntity.getIdCar());
        return newCars;
    }

    public Cars getByID(long id) {
        return mapEntityToBean(carsRepository.findById(id).get());
    }

    public Cars delete(long id) {
        CarsEntity tmp = carsRepository.findById(id).get();
        Cars cars = mapEntityToBean(tmp);
        carsRepository.deleteById(id);
        return cars;
    }

    public Cars changeCars(Cars newCars) {
        CarsEntity tmp = carsRepository.save(mapBeanToEntity(newCars));
        newCars.setIdCar(tmp.getIdCar());
        return newCars;
    }
    /*private static List<Cars> testCars;

    private List<Cars> getTestCars() {
        if(testCars != null) {
            return testCars;
        }
        testCars = new ArrayList<>();
        for(long i = 1; i <= 10; i++) {
            Cars testCar = new Cars();
            testCar.setIdCar(i);
            testCar.setIdManufacturer(i);
            testCar.setIdBody(i);
            testCar.setYear(i);
            testCar.setPrice(i);
            testCar.setQuantity(i);
            testCar.setDefective(i);
            testCars.add(testCar);
        }
        return testCars;
    }

    public List<Cars> getAll() {
        return getTestCars();
    }

    public Cars addCars(Cars newCars) {
        getTestCars().add(newCars);
        return newCars;
    }

    public Cars getById(Long id) {
        for(Cars n : testCars){
            if(n.getIdCar() == id)
            {
                return n;
            }
        }
        return null;
    }

    public Cars delete(Long id) {
        int index = -1;
        for(int i = 0; i < testCars.size(); i++){
            if(testCars.get(i).getIdCar()== id){
                index = i;
                break;
            }
        }

        if(index != -1){
            Cars tmp = testCars.get(index);
            testCars.remove(index);
            return  tmp;
        }

        return  null;
    }

    public Cars changeCars(Cars newStats) {
        for(Cars tmp: testCars) {
            if(tmp.getIdCar() == newStats.getIdCar()) {
                tmp.setIdBody(newStats.getIdBody());
                tmp.setIdManufacturer(newStats.getIdManufacturer());
                tmp.setPrice(newStats.getPrice());
                tmp.setDefective(newStats.getDefective());
                tmp.setQuantity(newStats.getQuantity());
                tmp.setYear(newStats.getYear());
                return tmp;
            }
        }
        return null;
    }*/
}