-- View on  on service_messages -->  
CREATE VIEW vw_service_message_nl (service, message) AS 
SELECT s.NameNL, m.NameNL 
FROM online_services as s, messages as m, service_messages sm
WHERE s.Id = sm.ServiceId AND m.Id = sm.MessageId;

select distinct(service) from vw_service_message_nl;

select count(*) as "Service count" from (select distinct(service) from vw_service_message_nl);

select count(*) from vw_service_message_nl;

