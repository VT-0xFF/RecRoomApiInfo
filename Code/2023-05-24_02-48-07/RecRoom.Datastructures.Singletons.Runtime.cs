using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static HashSet<GameObject> HDHLALKFPCL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> MMBLIPGOAJI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13A4940", Offset = "0x13A3540", VA = "0x1813A4940")]
	public static void RegisterDontDestroyOnLoad(GameObject NBIMDBPEIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13A4A00", Offset = "0x13A3600", VA = "0x1813A4A00")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object HHNPCHNMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13A45B0", Offset = "0x13A31B0", VA = "0x1813A45B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "6")]
	protected virtual void NGCFLIENGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13A4B60", Offset = "0x13A3760", VA = "0x1813A4B60")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JNCOMBCJEMF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25D0F20", Offset = "0x25CFB20", VA = "0x1825D0F20")]
	public static void GHBBEHGPPMI<T>(this T DPLEBJGMEDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13A4BA0", Offset = "0x13A37A0", VA = "0x1813A4BA0")]
	public static void GHBBEHGPPMI(this GameObject ALBKEDBKENG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static T PKIKEDNMDGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static T EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29A47D0", Offset = "0x29A33D0", VA = "0x1829A47D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3C888A0", Offset = "0x3C874A0", VA = "0x183C888A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C88570", Offset = "0x3C87170", VA = "0x183C88570", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C887D0", Offset = "0x3C873D0", VA = "0x183C887D0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2930E00", Offset = "0x292FA00", VA = "0x182930E00")]
	public SingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F0EA10", Offset = "0x5F0D610", VA = "0x185F0EA10", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F0EB40", Offset = "0x5F0D740", VA = "0x185F0EB40", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27BF840", Offset = "0x27BE440", VA = "0x1827BF840")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13A5020", Offset = "0x13A3C20", VA = "0x1813A5020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x13A4C90", Offset = "0x13A3890", VA = "0x1813A4C90")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13A4F10", Offset = "0x13A3B10", VA = "0x1813A4F10")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
	public ManagedSingletonObject()
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
