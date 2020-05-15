package ru.prkis.lab.auto.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import ru.prkis.lab.auto.entity.CarsEntity;
import ru.prkis.lab.auto.entity.ManufacturersEntity;
import ru.prkis.lab.auto.repository.ManufacturersRepository;
import ru.vyatgu.prkis.lab.auto.Cars;
import ru.vyatgu.prkis.lab.auto.Manufacturers;
import java.util.ArrayList;
import java.util.List;

@Service
public class ManufacturersService {

    @Autowired
    private ManufacturersRepository manufacturersRepository;

    private Manufacturers mapEntityToBean(ManufacturersEntity entity) {
        Manufacturers bean = new Manufacturers();
        bean.setIdManufacturer(entity.getIdManufacturer());
        bean.setName(entity.getName());
        bean.setCountry(entity.getCountry());
        return bean;
    }

    private ManufacturersEntity mapBeanToEntity(Manufacturers bean) {
        ManufacturersEntity entity = new ManufacturersEntity();
        entity.setIdManufacturer(bean.getIdManufacturer());
        entity.setName(bean.getName());
        entity.setCountry(bean.getCountry());
        return entity;
    }

    public List<Manufacturers> getAll() {
        List<ManufacturersEntity> manufacturersFromBd = manufacturersRepository.findAll();
        List<Manufacturers> manufacturers = new ArrayList<>();
        for (ManufacturersEntity manufacturersEntity: manufacturersFromBd) {
            manufacturers.add(mapEntityToBean(manufacturersEntity));
        }
        return manufacturers;
    }

    public Manufacturers addManufacturers(Manufacturers newManufacturers) {
        ManufacturersEntity newManufacturersEntity = manufacturersRepository.save(mapBeanToEntity(newManufacturers));
        newManufacturers.setIdManufacturer(newManufacturersEntity.getIdManufacturer());
        return newManufacturers;
    }

    public Manufacturers getByID(long id){
        return mapEntityToBean(manufacturersRepository.findById(id).get());
    }

    public Manufacturers delete(long id){
        ManufacturersEntity tmp = manufacturersRepository.findById(id).get();
        Manufacturers manufacturers = mapEntityToBean(tmp);
        manufacturersRepository.deleteById(id);
        return manufacturers;
    }

    public Manufacturers changeManufacturers(Manufacturers newManufacturers) {
        ManufacturersEntity tmp = manufacturersRepository.save(mapBeanToEntity(newManufacturers));
        newManufacturers.setIdManufacturer(tmp.getIdManufacturer());
        return newManufacturers;
    }
    /*private static List<Manufacturers> testManufacturers;

    private List<Manufacturers> getTestManufacturers() {
        if(testManufacturers != null) {
            return testManufacturers;
        }
        testManufacturers = new ArrayList<>();
        for(long i = 1; i <= 10; i++) {
            Manufacturers testManufacturer = new Manufacturers();
            testManufacturer.setIdManufacturer(i);
            testManufacturer.setName("Наименование производителя " + i);
            testManufacturer.setCountry("Страна " + i);
            testManufacturers.add(testManufacturer);
        }
        return testManufacturers;
    }

    public List<Manufacturers> getAll() {
        return getTestManufacturers();
    }

    public Manufacturers addManufacturers(Manufacturers newManufacturers) {
        getTestManufacturers().add(newManufacturers);
        return newManufacturers;
    }

    public Manufacturers getById(Long id) {
        for(Manufacturers n : testManufacturers){
            if(n.getIdManufacturer() == id)
            {
                return n;
            }
        }
        return null;
    }

    public Manufacturers delete(Long id) {
        int index = -1;
        for(int i = 0; i < testManufacturers.size(); i++){
            if(testManufacturers.get(i).getIdManufacturer()== id){
                index = i;
                break;
            }
        }

        if(index != -1){
            Manufacturers tmp = testManufacturers.get(index);
            testManufacturers.remove(index);
            return  tmp;
        }

        return  null;
    }

    public Manufacturers changeManufacturers(Manufacturers newStats) {
        for(Manufacturers tmp: testManufacturers) {
            if(tmp.getIdManufacturer() == newStats.getIdManufacturer()) {
                tmp.setName(newStats.getName());
                tmp.setCountry(newStats.getCountry());
                return tmp;
            }
        }
        return null;
    }*/
}