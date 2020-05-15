package ru.prkis.lab.auto.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import ru.prkis.lab.auto.entity.BodiesEntity;
import ru.prkis.lab.auto.repository.BodiesRepository;
import ru.vyatgu.prkis.lab.auto.Bodies;

import java.util.ArrayList;
import java.util.List;

@Service
public class BodiesService {

    @Autowired
    private BodiesRepository bodiesRepository;

    private Bodies mapEntityToBean(BodiesEntity entity) {
        Bodies bean = new Bodies();
        bean.setIdBody(entity.getIdBody());
        bean.setName(entity.getName());
        bean.setDescription(entity.getDescription());
        return bean;
    }

    private BodiesEntity mapBeanToEntity(Bodies bean) {
        BodiesEntity entity = new BodiesEntity();
        entity.setIdBody(bean.getIdBody());
        entity.setName(bean.getName());
        entity.setDescription(bean.getDescription());
        return entity;
    }

    public List<Bodies> getAll() {
        List<BodiesEntity> bodiesFromBd = bodiesRepository.findAll();
        List<Bodies> bodies = new ArrayList<>();
        for (BodiesEntity bodiesEntity: bodiesFromBd) {
            bodies.add(mapEntityToBean(bodiesEntity));
        }
        return bodies;
    }

    public Bodies addBodies(Bodies newBodies) {
        BodiesEntity newBodiesEntity = bodiesRepository.save(mapBeanToEntity(newBodies));
        newBodies.setIdBody(newBodiesEntity.getIdBody());
        return newBodies;
    }

    public Bodies getByID(long id){
        return mapEntityToBean(bodiesRepository.findById(id).get());
    }

    public Bodies delete(long id){
        BodiesEntity tmp = bodiesRepository.findById(id).get();
        Bodies bodies = mapEntityToBean(tmp);
        bodiesRepository.deleteById(id);
        return bodies;
    }

    public Bodies changeBodies(Bodies newBodies) {
        BodiesEntity tmp = bodiesRepository.save(mapBeanToEntity(newBodies));
        newBodies.setIdBody(tmp.getIdBody());
        return newBodies;
    }
    /*private static List<Bodies> testBodies;

    private List<Bodies> getTestBodies() {
        if(testBodies != null) {
            return testBodies;
        }
        testBodies = new ArrayList<>();
        for(long i = 1; i <= 10; i++) {
            Bodies testBody = new Bodies();
            testBody.setIdBody(i);
            testBody.setName("Наименование кузова " + i);
            testBody.setDescription("Описание кузова " + i);
            testBodies.add(testBody);
        }
        return testBodies;
    }

    public List<Bodies> getAll() {
        return getTestBodies();
    }

    public Bodies addBodies(Bodies newBodies) {
        getTestBodies().add(newBodies);
        return newBodies;
    }

    public Bodies getByID(Long id) {
        for(Bodies n : testBodies){
            if(n.getIdBody() == id)
            {
                return n;
            }
        }
        return null;
    }

    public Bodies delete(Long id) {
        int index = -1;
        for(int i = 0; i < testBodies.size(); i++){
            if(testBodies.get(i).getIdBody()== id){
                index = i;
                break;
            }
        }

        if(index != -1){
            Bodies tmp = testBodies.get(index);
            testBodies.remove(index);
            return  tmp;
        }

        return  null;
    }

    public Bodies changeBodies(Bodies newStats) {
        for(Bodies tmp: testBodies) {
            if(tmp.getIdBody() == newStats.getIdBody()) {
                tmp.setDescription(newStats.getDescription());
                tmp.setName(newStats.getName());
                return tmp;
            }
        }
        return null;
    }*/
}