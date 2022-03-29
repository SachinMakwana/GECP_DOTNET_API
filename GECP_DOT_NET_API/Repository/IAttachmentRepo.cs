using GECP_DOT_NET_API.Helper;
using GECP_DOT_NET_API.Models;
using System;
using System.Collections.Generic;

namespace GECP_DOT_NET_API.Repository
{
    public interface IAttachmentRepo
    {
        public ServiceResponse<List<AttachmentVM>> GetAllAttachmentDetails();

        public ServiceResponse<bool> AddAttachmentDetail(AttachmentVM attachmentVM);

        public ServiceResponse<bool> UpdateAttachmentDetail(AttachmentVM attachmentVM);

        public ServiceResponse<bool> DeleteAttachmentDetail(AttachmentVM attachmentVM);
    }
}
