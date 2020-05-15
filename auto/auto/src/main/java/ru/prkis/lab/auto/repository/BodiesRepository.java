package ru.prkis.lab.auto.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import ru.prkis.lab.auto.entity.BodiesEntity;

@Repository
public interface BodiesRepository extends JpaRepository<BodiesEntity, Long> {

}
