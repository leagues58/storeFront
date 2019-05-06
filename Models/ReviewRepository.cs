namespace StoreFront.Models
{
    public class ReviewRepository: IReviewRepository
    {
        private readonly AppDbContext appDbContext;

        public ReviewRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void AddReview(Review review)
        {
            this.appDbContext.Reviews.Add(review);
            this.appDbContext.SaveChanges();
        }
    }
}
