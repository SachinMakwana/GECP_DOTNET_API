from g in db.Grievance
join gs in db.GrievanceStatus on new { GrievanceId = g.Id } equals new { GrievanceId = gs.GrievanceId }
where
  gs.CreatedDateInt ==
	(from gt in db.GrievanceStatus
	where
	  gt.GrievanceId == g.Id
	select new {
	  gt.CreatedDateInt
	}).Max(p => p.CreatedDateInt)
select new {
  Id = g.Id,
  Name = g.Name,
  EmailId = g.EmailId,
  Mobile = g.Mobile,
  Subject = g.Subject,
  Description = g.Description,
  Attachments = g.Attachments,
  CreatedDate = g.CreatedDate,
  CreatedDateInt = g.CreatedDateInt,
  UpdatedDate = g.UpdatedDate,
  UpdatedDateInt = g.UpdatedDateInt,
  gs.Status,
  StatusUpdated = gs.CreatedDate,
  StatusUpdatedInt = gs.CreatedDateInt,
  StatusDescription = gs.Description
}