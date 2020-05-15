package ru.prkis.lab.auto.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.prkis.lab.auto.entity.CarsEntity;

@Repository
public interface CarsRepository extends JpaRepository<CarsEntity, Long> {

}
