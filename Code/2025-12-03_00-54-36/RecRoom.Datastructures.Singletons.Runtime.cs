using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static List<WeakReference<GameObject>> JNFMNCAVXXN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> JZWZHQAVUOU;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81905C0", Offset = "0x818F1C0", VA = "0x1881905C0")]
	public static void RegisterDontDestroyOnLoad(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8190710", Offset = "0x818F310", VA = "0x188190710")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x818FF70", Offset = "0x818EB70", VA = "0x18818FF70", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8190020", Offset = "0x818EC20", VA = "0x188190020")]
	private void FKVLCJUNXOH(Scene a, Scene b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8190170", Offset = "0x818ED70", VA = "0x188190170", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "6")]
	protected virtual void FNFPULQMBRP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8190880", Offset = "0x818F480", VA = "0x188190880")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HMMTQSBHVOM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x36B0550", Offset = "0x36AF150", VA = "0x1836B0550")]
	public static void MNUZQMPRXDU<a>(this a a) where a : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81908C0", Offset = "0x818F4C0", VA = "0x1881908C0")]
	public static void MNUZQMPRXDU(this GameObject a)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD12A0", Offset = "0x4FCFEA0", VA = "0x184FD12A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1420", Offset = "0x4FD0020", VA = "0x184FD1420", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1510", Offset = "0x4FD0110", VA = "0x184FD1510")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GameObject NDIXLSKEJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x11EE830", Offset = "0x11ED430", VA = "0x1811EE830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8190A40", Offset = "0x818F640", VA = "0x188190A40")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8190C80", Offset = "0x818F880", VA = "0x188190C80")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IISBWKQEDGX
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class SingletonMonoBehaviour<T> : MonoBehaviour, IISBWKQEDGX where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static T KIWZHDPKYDG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T PGFSJHGESKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x588A930", Offset = "0x5889530", VA = "0x18588A930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool FBOXVAHKOPR
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D6EB80", Offset = "0x5D6D780", VA = "0x185D6EB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D6E820", Offset = "0x5D6D420", VA = "0x185D6E820", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D6EAC0", Offset = "0x5D6D6C0", VA = "0x185D6EAC0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
	public SingletonMonoBehaviour()
	{
	}
}
namespace Cpp2IlInjected;

internal class AddressAttribute : Attribute
{
	public string RVA;

	public string Offset;

	public string VA;

	public string Slot;
}
internal class FieldOffsetAttribute : Attribute
{
	public string Offset;
}
internal class AttributeAttribute : Attribute
{
	public string Name;

	public string RVA;

	public string Offset;
}
internal class MetadataOffsetAttribute : Attribute
{
	public string Offset;
}
internal class TokenAttribute : Attribute
{
	public string Token;
}
internal class AnalysisFailedException : Exception
{
	public AnalysisFailedException(string message)
		: base(message)
	{
	}
}
