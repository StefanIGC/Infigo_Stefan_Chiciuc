using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Services.Interfaces;

namespace CMSPlus.Services.Services;

public class TopicService : ITopicService
{
    private readonly ITopicRepository _topicRepository;
    private readonly ICommentRepository _commentRepository;

    public TopicService(ITopicRepository topicRepository, ICommentRepository commentRepository)
    {
        _topicRepository = topicRepository;
        _commentRepository = commentRepository;
    }

    public async Task<TopicEntity> GetById(int id)
    {
        return await _topicRepository.GetById(id);
    }

    public async Task<TopicEntity?> GetBySystemName(string systemName)
    {
        return await _topicRepository.GetBySystemName(systemName);
    }

    public async Task<IEnumerable<TopicEntity>> GetAll()
    {
        return await _topicRepository.GetAll();
    }

    public async Task Create(TopicEntity entity)
    {
        await _topicRepository.Create(entity);
    }

    public async Task Update(TopicEntity entity)
    {
        await _topicRepository.Update(entity);
    }

    public async Task Delete(int id)
    {
        await _topicRepository.Delete(id);
    }

    public async Task AddComment(CommentEntity entity)
    {
        await _commentRepository.Create(entity);
    }
}