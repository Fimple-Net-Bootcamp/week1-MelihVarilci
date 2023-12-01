using Homework1.Entities;

namespace Homework1.Abstracts;

public interface ILendingPolicyService
{
    // Ödünç Alma
    void LendBook(Member member, Book book);

    // İade işlemleri
    void RefundProcessing(Member member, Book book);
}