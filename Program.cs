public class Televisao
{
    private readonly GerenciadorCanais _gerenciadorCanais;
    private readonly GerenciadorVolume _gerenciadorVolume;
    private bool _ligada;

    public Televisao()
    {
        _gerenciadorCanais = new GerenciadorCanais();
        _gerenciadorVolume = new GerenciadorVolume();
        _ligada = false;
    }

    public void Ligar()
    {
        _ligada = true;
        _gerenciadorCanais.TrocarCanal(_gerenciadorCanais.ObterUltimoCanal());
        Console.WriteLine("A TV foi ligada. Canal atual: " + ObterCanalAtual());
    }

    public void Desligar()
    {
        _ligada = false;
        Console.WriteLine("A TV foi desligada.");
    }
    
    public bool EstaLigada()
    {
        return _ligada;
    }

    // Gerenciamento de Canais
    public int ObterCanalAtual()
    {
        return _gerenciadorCanais.ObterCanalAtual();
    }

    public bool TrocarCanal(int numeroCanal)
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return false;
        }

        if (_gerenciadorCanais.TrocarCanal(numeroCanal))
        {
            Console.WriteLine("Canal alterado para: " + ObterCanalAtual());
            return true;
        }
        Console.WriteLine("Erro: Canal " + numeroCanal + " inválido. O número do canal deve ser entre 1 e 520.");
        return false;
    }

    public void CanalParaCima()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorCanais.CanalParaCima();
        Console.WriteLine("Canal para cima. Canal atual: " + ObterCanalAtual());
    }

    public void CanalParaBaixo()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorCanais.CanalParaBaixo();
        Console.WriteLine("Canal para baixo. Canal atual: " + ObterCanalAtual());
    }

    // Gerenciamento de Volume
    public int ObterVolumeAtual()
    {
        return _gerenciadorVolume.ObterVolumeAtual();
    }

    public void AumentarVolume()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorVolume.AumentarVolume();
        Console.WriteLine("Volume aumentado para: " + ObterVolumeAtual());
    }

    public void DiminuirVolume()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorVolume.DiminuirVolume();
        Console.WriteLine("Volume diminuído para: " + ObterVolumeAtual());
    }

    public void AtivarMudo()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorVolume.AtivarMudo();
        Console.WriteLine("Mudo ativado. Volume: " + ObterVolumeAtual());
    }

    public void DesativarMudo()
    {
        if (!_ligada)
        {
            Console.WriteLine("Erro: A TV está desligada.");
            return;
        }
        _gerenciadorVolume.DesativarMudo();
        Console.WriteLine("Mudo desativado. Volume: " + ObterVolumeAtual());
    }
}