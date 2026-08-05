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
	private static List<WeakReference<GameObject>> KHOCAGHJBNE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> AOOLACCKEIE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D90AC0", Offset = "0x7D8F6C0", VA = "0x187D90AC0")]
	public static void RegisterDontDestroyOnLoad(GameObject CJBDGNIBOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D90C20", Offset = "0x7D8F820", VA = "0x187D90C20")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D90480", Offset = "0x7D8F080", VA = "0x187D90480", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D90540", Offset = "0x7D8F140", VA = "0x187D90540")]
	private void EPLHNLBONKB(Scene HJNMJIJFLGD, Scene POMNCOEIPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D90680", Offset = "0x7D8F280", VA = "0x187D90680", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	protected virtual void BFKNNPMLNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D90D90", Offset = "0x7D8F990", VA = "0x187D90D90")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFNEBKBAHAI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3040D20", Offset = "0x303F920", VA = "0x183040D20")]
	public static void JPLABPNDMDB<T>(this T LBEOEMMCAFH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D902F0", Offset = "0x7D8EEF0", VA = "0x187D902F0")]
	public static void JPLABPNDMDB(this GameObject AOALCMHDOFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB65E0", Offset = "0x4EB51E0", VA = "0x184EB65E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6750", Offset = "0x4EB5350", VA = "0x184EB6750", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4E68A50", Offset = "0x4E67650", VA = "0x184E68A50")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAB0B80", Offset = "0xAAF780", VA = "0x180AB0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D90DD0", Offset = "0x7D8F9D0", VA = "0x187D90DD0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7D91010", Offset = "0x7D8FC10", VA = "0x187D91010")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GKIIHENKMEG
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class SingletonMonoBehaviour<T> : MonoBehaviour, GKIIHENKMEG where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static T KLHINJJCPGC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55024E0", Offset = "0x55010E0", VA = "0x1855024E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A010", Offset = "0x5A08C10", VA = "0x185A0A010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A09CD0", Offset = "0x5A088D0", VA = "0x185A09CD0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5A09F60", Offset = "0x5A08B60", VA = "0x185A09F60", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
