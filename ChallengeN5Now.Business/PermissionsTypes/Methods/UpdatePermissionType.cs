﻿using ChallengeN5Now.Domain.Models;
using MediatR;

namespace ChallengeN5Now.Business.PermissionsTypes.Methods
{
    public class UpdatePermissionType : IRequest<PermissionType>
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
