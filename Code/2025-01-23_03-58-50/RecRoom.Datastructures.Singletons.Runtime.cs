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
	private static List<WeakReference<GameObject>> ODDJCNBDGBF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> JKLELIJOKJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B8C0", Offset = "0x6F1A0C0", VA = "0x186F1B8C0")]
	public static void RegisterDontDestroyOnLoad(GameObject CLJHIFMEGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BA30", Offset = "0x6F1A230", VA = "0x186F1BA30")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object INCBEIDOHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B260", Offset = "0x6F19A60", VA = "0x186F1B260", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B320", Offset = "0x6F19B20", VA = "0x186F1B320")]
	private void BIOLCMBNBGE(Scene PEHNLLCAPBJ, Scene CJLAALNMBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B470", Offset = "0x6F19C70", VA = "0x186F1B470", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "6")]
	protected virtual void PGOBPEDLFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BBB0", Offset = "0x6F1A3B0", VA = "0x186F1BBB0")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PFLLGLOJDJB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3226100", Offset = "0x3224900", VA = "0x183226100")]
	public static void COJGIOALDPI<T>(this T FGOJHDGPHCJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BF40", Offset = "0x6F1A740", VA = "0x186F1BF40")]
	public static void COJGIOALDPI(this GameObject PBJIFBOBIOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43506E0", Offset = "0x434EEE0", VA = "0x1843506E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4350880", Offset = "0x434F080", VA = "0x184350880", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x43055D0", Offset = "0x4303DD0", VA = "0x1843055D0")]
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
	public GameObject BOMBMPDPILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xD8B3B0", Offset = "0xD89BB0", VA = "0x180D8B3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BBF0", Offset = "0x6F1A3F0", VA = "0x186F1BBF0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BE30", Offset = "0x6F1A630", VA = "0x186F1BE30")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AJLLNJOPIJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class SingletonMonoBehaviour<T> : MonoBehaviour, AJLLNJOPIJK where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static T BJNFKEAALFE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T ODDIIHPHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A22BF0", Offset = "0x4A213F0", VA = "0x184A22BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool KNPGJHABEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E7BE70", Offset = "0x4E7A670", VA = "0x184E7BE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BB10", Offset = "0x4E7A310", VA = "0x184E7BB10", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E7BDB0", Offset = "0x4E7A5B0", VA = "0x184E7BDB0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
