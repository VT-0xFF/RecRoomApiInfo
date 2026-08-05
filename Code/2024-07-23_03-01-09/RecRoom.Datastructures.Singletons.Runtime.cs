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
	private static List<WeakReference<GameObject>> NACIMJPOPFI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<UnityEngine.Object> AHDCHIFEKFP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68C86A0", Offset = "0x68C78A0", VA = "0x1868C86A0")]
	public static void RegisterDontDestroyOnLoad(GameObject JDNAMEBBFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68C8810", Offset = "0x68C7A10", VA = "0x1868C8810")]
	public static void RegisterHideFlagsDontSaveObject(UnityEngine.Object MEAFIMADMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68C8040", Offset = "0x68C7240", VA = "0x1868C8040", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68C8100", Offset = "0x68C7300", VA = "0x1868C8100")]
	private void BHGAGFLNHAB(Scene JKKNEDBGDJF, Scene GGIBALMFIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68C8250", Offset = "0x68C7450", VA = "0x1868C8250", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "6")]
	protected virtual void EHDODILDOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68C8990", Offset = "0x68C7B90", VA = "0x1868C8990")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CIKFABGDFJP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2949B50", Offset = "0x2948D50", VA = "0x182949B50")]
	public static void LOJLCDAKAJD<T>(this T INPAFGCEBHH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68C7EA0", Offset = "0x68C70A0", VA = "0x1868C7EA0")]
	public static void LOJLCDAKAJD(this GameObject NBDLDMDNCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1DE0", Offset = "0x3EF0FE0", VA = "0x183EF1DE0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3EF1F50", Offset = "0x3EF1150", VA = "0x183EF1F50", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3E47460", Offset = "0x3E46660", VA = "0x183E47460")]
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
	public GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x947E80", Offset = "0x947080", VA = "0x180947E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68C89D0", Offset = "0x68C7BD0", VA = "0x1868C89D0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68C8C10", Offset = "0x68C7E10", VA = "0x1868C8C10")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static T BOLGDNNEFAC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T MJFJCBEEADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x44F3210", Offset = "0x44F2410", VA = "0x1844F3210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static bool HPJBMFGHLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x497A220", Offset = "0x4979420", VA = "0x18497A220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4979EC0", Offset = "0x49790C0", VA = "0x184979EC0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x497A160", Offset = "0x4979360", VA = "0x18497A160", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
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
