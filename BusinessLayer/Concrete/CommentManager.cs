﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }
        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationId == id);
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
    }
}