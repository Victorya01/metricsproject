using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication12.Controllers;
using Xunit;
using Moq;
using WebApplication12.Repository;
using WebApplication12;

namespace UnitTest
{
    public class UnitTests2
    {
        private CpuMetricsController controller;
        private Mock<ICpuMetricsRepository> mock; 
        private DotNetMetricsController controller2;
        private Mock<IDotNetMetricsRepository> mock2;
        private HddMetricsController controller3;
        private Mock<IHddMetricsRepository> mock3;
        private NetworkMetricsController controller4;
        private Mock<INetworkMetricsRepository> mock4;
        private RamMetricsController controller5;
        private Mock<IRamMetricsRepository> mock5;

        public UnitTests2()
        {
            mock = new Mock<ICpuMetricsRepository>();
            mock2 = new Mock<IDotNetMetricsRepository>();
            mock3 = new Mock<IHddMetricsRepository>();
            mock4 = new Mock<INetworkMetricsRepository>();
            mock5 = new Mock<IRamMetricsRepository>();

            controller = new CpuMetricsController(mock.Object);
            controller2 = new DotNetMetricsController(mock2.Object);
            controller3 = new HddMetricsController(mock3.Object);
            controller4 = new NetworkMetricsController(mock4.Object);
            controller5 = new RamMetricsController(mock5.Object);
        }

        [Fact]
        public void CpuMetricsController_Test()
        {
            // ������������� �������� ��������
            // � �������� ����������� ��� � ����������� �������� CpuMetric ������
            mock.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // ��������� �������� �� �����������
            var result = controller.Create(new WebApplication12.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // ��������� �������� �� ��, ��� ���� ������� ����������
            // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
            mock.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
        
        [Fact]
        public void DotNetMetricsController_Test()
        {
            // ������������� �������� ��������
            // � �������� ����������� ��� � ����������� �������� CpuMetric ������
            mock2.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // ��������� �������� �� �����������
            var result = controller2.Create(new WebApplication12.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // ��������� �������� �� ��, ��� ���� ������� ����������
            // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
            mock2.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
        [Fact]
        public void HddMetricsController_Test()
        {
            // ������������� �������� ��������
            // � �������� ����������� ��� � ����������� �������� CpuMetric ������
            mock3.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // ��������� �������� �� �����������
            var result = controller3.Create(new WebApplication12.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // ��������� �������� �� ��, ��� ���� ������� ����������
            // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
            mock3.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
        [Fact]
        public void NetworkMetricsController_Test()
        {
            // ������������� �������� ��������
            // � �������� ����������� ��� � ����������� �������� CpuMetric ������
            mock4.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // ��������� �������� �� �����������
            var result = controller4.Create(new WebApplication12.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // ��������� �������� �� ��, ��� ���� ������� ����������
            // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
            mock4.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
        [Fact]
        public void RamMetricsController_Test()
        {
            // ������������� �������� ��������
            // � �������� ����������� ��� � ����������� �������� CpuMetric ������
            mock5.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

            // ��������� �������� �� �����������
            var result = controller5.Create(new WebApplication12.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

            // ��������� �������� �� ��, ��� ���� ������� ����������
            // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
            mock5.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
    }
}



