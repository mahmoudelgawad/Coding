
select  st.FirstName,st.LastName ,sub.Name,stgr.Grade
from Student st  
 join StudentGrade stgr on stgr.Student_ID = st.ID
 join [Subject] sub on sub.ID = stgr.subject_id

group by st.FirstName,st.LastName ,sub.Name,stgr.Grade
 order by sub.Name,grade DESC
 
 
-- ####################################################
 
 
select  st.FirstName,st.LastName ,sub.Name,stgr2.maxgrade
from Student st  
 join StudentGrade stgr on stgr.Student_ID = st.ID
 inner join(select  Subject_ID,Student_ID,max(grade) maxgrade from StudentGrade group by StudentGrade.Subject_ID,Student_ID) stgr2
	on stgr2.Subject_ID = stgr.Subject_ID and stgr2.Student_ID = st.ID 
 join [Subject] sub on sub.ID = stgr.subject_id

  order by sub.Name,grade DESC
  
--#################solution#########################################3  
 with ordermarks as (
select Student_ID,Subject_ID,Grade,RANK() over (partition by subject_id order by grade DESC) rn
  from StudentGrade
)

select st.FirstName, st.LastName, sub.Name, ordermarks.Grade
from ordermarks
join Student st on st.ID = ordermarks.Student_ID
join Subject sub on sub.ID = ordermarks.Subject_ID
where ordermarks.rn = 1