using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ELICKFEEMJL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7ECF50", Offset = "0x7EBD50", VA = "0x1807ECF50")]
	public ELICKFEEMJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B55B90", Offset = "0x4B54990", VA = "0x184B55B90")]
	public byte[] INLPGCCBMJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void IAJINJNGKKH(IncrementalHash FJDPCLONNGD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D99C0", Offset = "0x5D87C0", VA = "0x1805D99C0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[LPGFFIDHFBP]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[LPGFFIDHFBP]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4B591C0", Offset = "0x4B57FC0", VA = "0x184B591C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B59180", Offset = "0x4B57F80", VA = "0x184B59180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B59200", Offset = "0x4B58000", VA = "0x184B59200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B59410", Offset = "0x4B58210", VA = "0x184B59410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4B59380", Offset = "0x4B58180", VA = "0x184B59380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AE0", Offset = "0x8D38E0", VA = "0x1808D4AE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AF0", Offset = "0x8D38F0", VA = "0x1808D4AF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B59140", Offset = "0x4B57F40", VA = "0x184B59140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4B592F0", Offset = "0x4B580F0", VA = "0x184B592F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B58B70", Offset = "0x4B57970", VA = "0x184B58B70")]
	public void CopyBounds(SavedExtents KBAPGFOKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B590B0", Offset = "0x4B57EB0", VA = "0x184B590B0")]
	public void SetLocalSpaceBounds(Bounds BJBAMEAMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAD5E60", Offset = "0xAD4C60", VA = "0x180AD5E60")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B590A0", Offset = "0x4B57EA0", VA = "0x184B590A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B58BA0", Offset = "0x4B579A0", VA = "0x184B58BA0")]
	private void JNGIOALBHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4B58E70", Offset = "0x4B57C70", VA = "0x184B58E70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4B585B0", Offset = "0x4B573B0", VA = "0x184B585B0")]
	public static void CalculateLocalBoundsFor(GameObject LHOMOGPNLAL, out Bounds BJBAMEAMGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B58DB0", Offset = "0x4B57BB0", VA = "0x184B58DB0")]
	private static void NDIFBEHENEI(Bounds BAHCPBFJIGN, Color PMOBKAEONAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B590D0", Offset = "0x4B57ED0", VA = "0x184B590D0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x522EE0", Offset = "0x521CE0", VA = "0x180522EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "4")]
	public virtual void KFJOICHFJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[ELICKFEEMJL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C960", Offset = "0x3E8B760", VA = "0x183E8C960", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C4A0", Offset = "0x3E8B2A0", VA = "0x183E8C4A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3E8CF60", Offset = "0x3E8BD60", VA = "0x183E8CF60")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IMNDAELPLAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public IMNDAELPLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC7C0", Offset = "0x3EBB5C0", VA = "0x183EBC7C0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[ELICKFEEMJL]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA6B0", Offset = "0x3EB94B0", VA = "0x183EBA6B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA6E0", Offset = "0x3EB94E0", VA = "0x183EBA6E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA600", Offset = "0x3EB9400", VA = "0x183EBA600", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey IFKOMGEEEMC]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA630", Offset = "0x3EB9430", VA = "0x183EBA630", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA500", Offset = "0x3EB9300", VA = "0x183EBA500", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9D60", Offset = "0x3EB8B60", VA = "0x183EB9D60", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EB96D0", Offset = "0x3EB84D0", VA = "0x183EB96D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9330", Offset = "0x3EB8130", VA = "0x183EB9330", Slot = "14")]
	protected virtual string KMJFHGNAAAF(TKeyVal EEFKDOBNENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x28C3370", Offset = "0x28C2170", VA = "0x1828C3370", Slot = "4")]
	public bool ContainsKey(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA3F0", Offset = "0x3EB91F0", VA = "0x183EBA3F0", Slot = "5")]
	public bool TryGetValue(TKey IFKOMGEEEMC, out TVal PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9240", Offset = "0x3EB8040", VA = "0x183EB9240", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EB9240", Offset = "0x3EB8040", VA = "0x183EB9240", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA420", Offset = "0x3EB9220", VA = "0x183EBA420")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NAPGAIHAMON<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OOIJDFINBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public OOIJDFINBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3937180", Offset = "0x3935F80", VA = "0x183937180")]
		internal bool <GetSamples>b__0(global::ALJHLAKNACE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float KONDOBIJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float NCNHPMMEEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::ALJHLAKNACE<float, T>> PBGIKIFDGNA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int MGAOJOKJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3936540", Offset = "0x3935340", VA = "0x183936540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x39370D0", Offset = "0x3935ED0", VA = "0x1839370D0")]
	public NAPGAIHAMON(float PKGGLGLDPJF, float HPGEPJCALAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3936E10", Offset = "0x3935C10", VA = "0x183936E10")]
	public bool MIBDGIGPEBA(float NMMJGCHJEKG, T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3936CF0", Offset = "0x3935AF0", VA = "0x183936CF0")]
	public int LCBBNENKPKF(float NMMJGCHJEKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x39369B0", Offset = "0x39357B0", VA = "0x1839369B0")]
	public IEnumerable<T> HJJBOLOJPLK(float NMMJGCHJEKG, [Optional] float? AIIAHLFFILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3936640", Offset = "0x3935440", VA = "0x183936640")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3936D50", Offset = "0x3935B50", VA = "0x183936D50")]
	private void MGBNCFPLJAI(float NMMJGCHJEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class NBLJOJIFHFA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KDDHHGNILKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T NMGHIPGAEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float BOOPJOMNHDN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float KKPHBMKJDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> BCEODFMEOPH;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int EOFHPGEBODB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private KDDHHGNILKN[] KGBBFPHOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int JIAOIDKFLNM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float ECBHLBIDJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AD0", Offset = "0x8D38D0", VA = "0x1808D4AD0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B10", Offset = "0x8D3910", VA = "0x1808D4B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x39B90C0", Offset = "0x39B7EC0", VA = "0x1839B90C0")]
	public NBLJOJIFHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x39B90F0", Offset = "0x39B7EF0", VA = "0x1839B90F0")]
	public NBLJOJIFHFA(int ILOELBIABFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x39B8ED0", Offset = "0x39B7CD0", VA = "0x1839B8ED0")]
	public void NGPIMMKGFMI(float NMMJGCHJEKG, T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39B8870", Offset = "0x39B7670", VA = "0x1839B8870")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x39B81F0", Offset = "0x39B6FF0", VA = "0x1839B81F0")]
	public bool EMCELFINIFI(float JCEOABMHENE, float AKMPAHOGEPA, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x39B7ED0", Offset = "0x39B6CD0", VA = "0x1839B7ED0")]
	public bool DHDPCLIMMIL(float JCEOABMHENE, float AKMPAHOGEPA, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x39B8CA0", Offset = "0x39B7AA0", VA = "0x1839B8CA0")]
	public void MCIFFCMKDLO(float JCEOABMHENE, float AKMPAHOGEPA, List<T> DLJHFCENONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x39B7B90", Offset = "0x39B6990", VA = "0x1839B7B90")]
	private int CGANMJELEFN(int MNKBKHLPOED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x39B89C0", Offset = "0x39B77C0", VA = "0x1839B89C0")]
	private void ICODBDOGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KLMGBCCEJMK();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NCLGALOCMOJ(T COMGDPEPLKC, T HJFFDGEGELD, float NCLDEDMIFEJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T EEMHMAAMNFE(T PEPOHKCFAOG, float NCLDEDMIFEJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LBOKHIFHNHE(T COMGDPEPLKC, T HJFFDGEGELD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T CDPOBENFKCG(T COMGDPEPLKC, T HJFFDGEGELD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BPJHPHMGMOO : global::NBLJOJIFHFA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4B53EF0", Offset = "0x4B52CF0", VA = "0x184B53EF0", Slot = "4")]
	protected override Vector3 KLMGBCCEJMK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B54010", Offset = "0x4B52E10", VA = "0x184B54010", Slot = "5")]
	protected override Vector3 NCLGALOCMOJ(Vector3 COMGDPEPLKC, Vector3 HJFFDGEGELD, float NCLDEDMIFEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4B53E50", Offset = "0x4B52C50", VA = "0x184B53E50", Slot = "6")]
	protected override Vector3 EEMHMAAMNFE(Vector3 PEPOHKCFAOG, float NCLDEDMIFEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4B53F60", Offset = "0x4B52D60", VA = "0x184B53F60", Slot = "7")]
	protected override Vector3 LBOKHIFHNHE(Vector3 COMGDPEPLKC, Vector3 HJFFDGEGELD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4B53DE0", Offset = "0x4B52BE0", VA = "0x184B53DE0", Slot = "8")]
	protected override Vector3 CDPOBENFKCG(Vector3 COMGDPEPLKC, Vector3 HJFFDGEGELD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4B540D0", Offset = "0x4B52ED0", VA = "0x184B540D0")]
	public BPJHPHMGMOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GEBKONIFIAG : global::NBLJOJIFHFA<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B55840", Offset = "0x4B54640", VA = "0x184B55840")]
	public GEBKONIFIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B558A0", Offset = "0x4B546A0", VA = "0x184B558A0")]
	public GEBKONIFIAG(int ILOELBIABFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xA5A890", Offset = "0xA59690", VA = "0x180A5A890", Slot = "4")]
	protected override float KLMGBCCEJMK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B557C0", Offset = "0x4B545C0", VA = "0x184B557C0", Slot = "5")]
	protected override float NCLGALOCMOJ(float COMGDPEPLKC, float HJFFDGEGELD, float NCLDEDMIFEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E1B470", Offset = "0x3E1A270", VA = "0x183E1B470", Slot = "6")]
	protected override float EEMHMAAMNFE(float PEPOHKCFAOG, float NCLDEDMIFEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D590", Offset = "0x2B9C390", VA = "0x182B9D590", Slot = "7")]
	protected override float LBOKHIFHNHE(float COMGDPEPLKC, float HJFFDGEGELD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4B557B0", Offset = "0x4B545B0", VA = "0x184B557B0", Slot = "8")]
	protected override float CDPOBENFKCG(float COMGDPEPLKC, float HJFFDGEGELD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BFLAJAJAOHC
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27DE260", Offset = "0x27DD060", VA = "0x1827DE260")]
	public static global::LNEJNHFNMLH<T1> FBNMOHOMNBD<T1>(T1 DOONPOOJIPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26A4E20", Offset = "0x26A3C20", VA = "0x1826A4E20")]
	public static global::ALJHLAKNACE<T1, T2> FBNMOHOMNBD<T1, T2>(T1 DOONPOOJIPE, T2 NINKOELFMKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26A4E90", Offset = "0x26A3C90", VA = "0x1826A4E90")]
	public static global::AGGECLPFKPA<T1, T2, T3> FBNMOHOMNBD<T1, T2, T3>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x27F2D00", Offset = "0x27F1B00", VA = "0x1827F2D00")]
	public static global::COBEFPJPBCD<T1, T2, T3, T4> FBNMOHOMNBD<T1, T2, T3, T4>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x27E4800", Offset = "0x27E3600", VA = "0x1827E4800")]
	public static global::IONNGCDMANC<T1, T2, T3, T4, T5> FBNMOHOMNBD<T1, T2, T3, T4, T5>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27E4750", Offset = "0x27E3550", VA = "0x1827E4750")]
	public static global::NJGHLLNICCL<T1, T2, T3, T4, T5, T6> FBNMOHOMNBD<T1, T2, T3, T4, T5, T6>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27E4690", Offset = "0x27E3490", VA = "0x1827E4690")]
	public static global::HGMGIDCFHAI<T1, T2, T3, T4, T5, T6, T7> FBNMOHOMNBD<T1, T2, T3, T4, T5, T6, T7>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA, T7 BEECOKKAGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27E45C0", Offset = "0x27E33C0", VA = "0x1827E45C0")]
	public static global::PALAHDFPLLL<T1, T2, T3, T4, T5, T6, T7, T8> FBNMOHOMNBD<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA, T7 BEECOKKAGIE, T8 LCBIBMNEKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x21A5820", Offset = "0x21A4620", VA = "0x1821A5820")]
	[IteratorStateMachine(typeof(JKOHEOFCHFN))]
	public static IEnumerable<global::ALJHLAKNACE<T1, T2>> BPKEDPMCDEI<T1, T2>(IEnumerable<T1> OCNFPNPPOJC, IEnumerable<T2> BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x23A75C0", Offset = "0x23A63C0", VA = "0x1823A75C0")]
	[IteratorStateMachine(typeof(PFOFMPGEIBL))]
	public static IEnumerable<global::AGGECLPFKPA<T1, T2, T3>> BPKEDPMCDEI<T1, T2, T3>(IEnumerable<T1> OCNFPNPPOJC, IEnumerable<T2> BAHCPBFJIGN, IEnumerable<T3> PMOBKAEONAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B39580", Offset = "0x2B38380", VA = "0x182B39580")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x436CAA0", Offset = "0x436B8A0", VA = "0x18436CAA0")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x436CAB0", Offset = "0x436B8B0", VA = "0x18436CAB0")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO, int CHIGJLPKPEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B53D60", Offset = "0x4B52B60", VA = "0x184B53D60")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO, int CHIGJLPKPEF, int KADBCKMKNKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B53D40", Offset = "0x4B52B40", VA = "0x184B53D40")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO, int CHIGJLPKPEF, int KADBCKMKNKN, int ILMDLFONPEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B53DB0", Offset = "0x4B52BB0", VA = "0x184B53DB0")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO, int CHIGJLPKPEF, int KADBCKMKNKN, int ILMDLFONPEJ, int BFCMOPPDCKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B53D80", Offset = "0x4B52B80", VA = "0x184B53D80")]
	internal static int DILPHKHKGNJ(int AFNHABMDEAA, int MHDOKLKOOHA, int HMFJDPKJLPO, int CHIGJLPKPEF, int KADBCKMKNKN, int ILMDLFONPEJ, int BFCMOPPDCKJ, int MLOFKCECFFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LNEJNHFNMLH<T1> : IComparable<global::LNEJNHFNMLH<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2727290", Offset = "0x2726090", VA = "0x182727290")]
	public LNEJNHFNMLH(T1 DOONPOOJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3702440", Offset = "0x3701240", VA = "0x183702440", Slot = "4")]
	public int CompareTo(global::LNEJNHFNMLH<T1> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37024B0", Offset = "0x37012B0", VA = "0x1837024B0", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C2450", Offset = "0x6C1250", VA = "0x1806C2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3702550", Offset = "0x3701350", VA = "0x183702550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ALJHLAKNACE<T1, T2> : IComparable<global::ALJHLAKNACE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2AC46A0", Offset = "0x2AC34A0", VA = "0x182AC46A0")]
	public ALJHLAKNACE(T1 DOONPOOJIPE, T2 NINKOELFMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4233060", Offset = "0x4231E60", VA = "0x184233060", Slot = "4")]
	public int CompareTo(global::ALJHLAKNACE<T1, T2> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42339B0", Offset = "0x42327B0", VA = "0x1842339B0", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4233CE0", Offset = "0x4232AE0", VA = "0x184233CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4234240", Offset = "0x4233040", VA = "0x184234240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AGGECLPFKPA<T1, T2, T3> : IComparable<global::AGGECLPFKPA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F697D0", Offset = "0x2F685D0", VA = "0x182F697D0")]
	public AGGECLPFKPA(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2F68FF0", Offset = "0x2F67DF0", VA = "0x182F68FF0", Slot = "4")]
	public int CompareTo(global::AGGECLPFKPA<T1, T2, T3> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2F692E0", Offset = "0x2F680E0", VA = "0x182F692E0", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2F694E0", Offset = "0x2F682E0", VA = "0x182F694E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F69550", Offset = "0x2F68350", VA = "0x182F69550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class COBEFPJPBCD<T1, T2, T3, T4> : IComparable<global::COBEFPJPBCD<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 NPLCANEGIJI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x36BD9C0", Offset = "0x36BC7C0", VA = "0x1836BD9C0")]
	public COBEFPJPBCD(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x36BD590", Offset = "0x36BC390", VA = "0x1836BD590", Slot = "4")]
	public int CompareTo(global::COBEFPJPBCD<T1, T2, T3, T4> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x36BD6D0", Offset = "0x36BC4D0", VA = "0x1836BD6D0", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x36BD7F0", Offset = "0x36BC5F0", VA = "0x1836BD7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x36BD8B0", Offset = "0x36BC6B0", VA = "0x1836BD8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IONNGCDMANC<T1, T2, T3, T4, T5> : IComparable<global::IONNGCDMANC<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 NPLCANEGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 EKHEILFDGPE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3848720", Offset = "0x3847520", VA = "0x183848720")]
	public IONNGCDMANC(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3848230", Offset = "0x3847030", VA = "0x183848230", Slot = "4")]
	public int CompareTo(global::IONNGCDMANC<T1, T2, T3, T4, T5> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x38483B0", Offset = "0x38471B0", VA = "0x1838483B0", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x38484F0", Offset = "0x38472F0", VA = "0x1838484F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x38485F0", Offset = "0x38473F0", VA = "0x1838485F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NJGHLLNICCL<T1, T2, T3, T4, T5, T6> : IComparable<global::NJGHLLNICCL<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 NPLCANEGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 EKHEILFDGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 MEMNHEHFLHG;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2724E40", Offset = "0x2723C40", VA = "0x182724E40")]
	public NJGHLLNICCL(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x27248A0", Offset = "0x27236A0", VA = "0x1827248A0", Slot = "4")]
	public int CompareTo(global::NJGHLLNICCL<T1, T2, T3, T4, T5, T6> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2724A60", Offset = "0x2723860", VA = "0x182724A60", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2724BD0", Offset = "0x27239D0", VA = "0x182724BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2724CF0", Offset = "0x2723AF0", VA = "0x182724CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HGMGIDCFHAI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::HGMGIDCFHAI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 NPLCANEGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 EKHEILFDGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 MEMNHEHFLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 FKIMFLDHJJI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x35E7F80", Offset = "0x35E6D80", VA = "0x1835E7F80")]
	public HGMGIDCFHAI(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA, T7 BEECOKKAGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x35E7920", Offset = "0x35E6720", VA = "0x1835E7920", Slot = "4")]
	public int CompareTo(global::HGMGIDCFHAI<T1, T2, T3, T4, T5, T6, T7> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x35E7B20", Offset = "0x35E6920", VA = "0x1835E7B20", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x35E7CC0", Offset = "0x35E6AC0", VA = "0x1835E7CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x35E7E10", Offset = "0x35E6C10", VA = "0x1835E7E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PALAHDFPLLL<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::PALAHDFPLLL<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 GOLHHAPLPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 ONOLLNCOFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 FICOFPGHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 NPLCANEGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 EKHEILFDGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 MEMNHEHFLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 FKIMFLDHJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 BNDMEOMDDKG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x353FD50", Offset = "0x353EB50", VA = "0x18353FD50")]
	public PALAHDFPLLL(T1 DOONPOOJIPE, T2 NINKOELFMKJ, T3 BBNEHFJNGAF, T4 ADFAEFEGFCO, T5 GFJLNMPLHBO, T6 DLNGPKNDJHA, T7 BEECOKKAGIE, T8 LCBIBMNEKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x353F640", Offset = "0x353E440", VA = "0x18353F640", Slot = "4")]
	public int CompareTo(global::PALAHDFPLLL<T1, T2, T3, T4, T5, T6, T7, T8> KBAPGFOKKBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x353F890", Offset = "0x353E690", VA = "0x18353F890", Slot = "0")]
	public override bool Equals(object KBAPGFOKKBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x353FA50", Offset = "0x353E850", VA = "0x18353FA50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x353FBC0", Offset = "0x353E9C0", VA = "0x18353FBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float HEIDJEPIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x656F30", Offset = "0x655D30", VA = "0x180656F30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBD00", Offset = "0x3BDAB00", VA = "0x183BDBD00")]
	public T BDMHEBOIKDI(float NCLDEDMIFEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3BDB8A0", Offset = "0x3BDA6A0", VA = "0x183BDB8A0")]
	public T ADHDDIIAJGH(float NCLDEDMIFEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NCLGALOCMOJ(T COMGDPEPLKC, T HJFFDGEGELD, float NCLDEDMIFEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B556F0", Offset = "0x4B544F0", VA = "0x184B556F0", Slot = "4")]
	protected override float NCLGALOCMOJ(float COMGDPEPLKC, float HJFFDGEGELD, float NCLDEDMIFEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B55770", Offset = "0x4B54570", VA = "0x184B55770")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B5A370", Offset = "0x4B59170", VA = "0x184B5A370", Slot = "4")]
	protected override Vector3 NCLGALOCMOJ(Vector3 COMGDPEPLKC, Vector3 HJFFDGEGELD, float NCLDEDMIFEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4B5A430", Offset = "0x4B59230", VA = "0x184B5A430")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4B545C0", Offset = "0x4B533C0", VA = "0x184B545C0", Slot = "4")]
	protected override Color NCLGALOCMOJ(Color COMGDPEPLKC, Color HJFFDGEGELD, float NCLDEDMIFEJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4B54610", Offset = "0x4B53410", VA = "0x184B54610")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class JNEOLILKKMM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private T[] KJHGLIDBGFP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x595210", Offset = "0x594010", VA = "0x180595210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5A3710", Offset = "0x5A2510", VA = "0x1805A3710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3DAF9A0", Offset = "0x3DAE7A0", VA = "0x183DAF9A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0610", Offset = "0x3DAF410", VA = "0x183DB0610")]
	public static global::JNEOLILKKMM<T> PEPJCOIMNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF7C0", Offset = "0x3DAE5C0", VA = "0x183DAF7C0")]
	public static global::JNEOLILKKMM<T> FFNEEBOLEOH(int IMNCEOIPJNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DB08C0", Offset = "0x3DAF6C0", VA = "0x183DB08C0")]
	private JNEOLILKKMM(T[] CPFDAGLPFPN, int IMNCEOIPJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF750", Offset = "0x3DAE550", VA = "0x183DAF750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFF00", Offset = "0x3DAED00", VA = "0x183DAFF00")]
	public void NGPIMMKGFMI(in T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF900", Offset = "0x3DAE700", VA = "0x183DAF900")]
	public void GAIMKPILCFO(int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0280", Offset = "0x3DAF080", VA = "0x183DB0280")]
	public void OGCMIFMLPGF(in T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFC90", Offset = "0x3DAEA90", VA = "0x183DAFC90")]
	public void LLOHMLOBHKM(int ILOELBIABFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0740", Offset = "0x3DAF540", VA = "0x183DB0740")]
	private void PLHGGAIPPCA(int IMNCEOIPJNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class INEOAEIJAGE
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27EA000", Offset = "0x27E8E00", VA = "0x1827EA000")]
	public static global::JNEOLILKKMM<T> PEPJCOIMNOL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x21D3A70", Offset = "0x21D2870", VA = "0x1821D3A70")]
	public static global::JNEOLILKKMM<T> FFNEEBOLEOH<T>(int IMNCEOIPJNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class JECHPJFKJGE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Dictionary<TKey, TVal> PNGGCNPHFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<TVal, TKey> IKPEEEAPBKK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1E0", Offset = "0x28C9FE0", VA = "0x1828CB1E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool MLHMDIBJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> GCKOBJPDJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B6D0", Offset = "0x2F6A4D0", VA = "0x182F6B6D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> KODDIGCFFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3483800", Offset = "0x3482600", VA = "0x183483800", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2F67DD0", Offset = "0x2F66BD0", VA = "0x182F67DD0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x46BBDE0", Offset = "0x46BABE0", VA = "0x1846BBDE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x46BB640", Offset = "0x46BA440", VA = "0x1846BB640")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x46BB5C0", Offset = "0x46BA3C0", VA = "0x1846BB5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x46BB200", Offset = "0x46BA000", VA = "0x1846BB200", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x46BBC60", Offset = "0x46BAA60", VA = "0x1846BBC60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x46BB170", Offset = "0x46B9F70", VA = "0x1846BB170", Slot = "9")]
	public void Add(TKey IFKOMGEEEMC, TVal PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x46BB1A0", Offset = "0x46B9FA0", VA = "0x1846BB1A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x377D130", Offset = "0x377BF30", VA = "0x18377D130", Slot = "8")]
	public bool ContainsKey(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37038F0", Offset = "0x37026F0", VA = "0x1837038F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE520", Offset = "0x2FBD320", VA = "0x182FBE520", Slot = "10")]
	public bool Remove(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2FBE520", Offset = "0x2FBD320", VA = "0x182FBE520", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37022B0", Offset = "0x37010B0", VA = "0x1837022B0", Slot = "11")]
	public bool TryGetValue(TKey IFKOMGEEEMC, out TVal PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x46BB540", Offset = "0x46BA340", VA = "0x1846BB540", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x46BB290", Offset = "0x46BA090", VA = "0x1846BB290", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KGBBFPHOMGB, int KLFCFLDJMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x46BB670", Offset = "0x46BA470", VA = "0x1846BB670")]
	public void NGPIMMKGFMI(TVal HGHHGPACLPK, TKey IFKOMGEEEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x46BB6F0", Offset = "0x46BA4F0", VA = "0x1846BB6F0")]
	public void NGPIMMKGFMI(KeyValuePair<TVal, TKey> EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x46BB2F0", Offset = "0x46BA0F0", VA = "0x1846BB2F0")]
	public bool DAAGNBINBBN(TVal IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x46BB8A0", Offset = "0x46BA6A0", VA = "0x1846BB8A0")]
	public bool OKCEKAKCNAH(KeyValuePair<TVal, TKey> EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x388F660", Offset = "0x388E460", VA = "0x18388F660")]
	public bool OGCMIFMLPGF(TVal IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x388F660", Offset = "0x388E460", VA = "0x18388F660")]
	public bool OGCMIFMLPGF(KeyValuePair<TVal, TKey> EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x46BB900", Offset = "0x46BA700", VA = "0x1846BB900")]
	public bool PDIMMFIGHEA(TVal IFKOMGEEEMC, out TKey PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x46BB320", Offset = "0x46BA120", VA = "0x1846BB320")]
	public IEnumerator<KeyValuePair<TVal, TKey>> EDEDLGBINCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x46BB430", Offset = "0x46BA230", VA = "0x1846BB430")]
	private void EEOCNANJDIK(TKey IFKOMGEEEMC, TVal HGHHGPACLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x46BB760", Offset = "0x46BA560", VA = "0x1846BB760")]
	private void OBDMGLIEHPB(TKey IFKOMGEEEMC, TVal HGHHGPACLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x46BB930", Offset = "0x46BA730", VA = "0x1846BB930")]
	private bool PFDMCPCLADJ(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x46BBAB0", Offset = "0x46BA8B0", VA = "0x1846BBAB0")]
	private bool PFDMCPCLADJ(TVal HGHHGPACLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x46BBD00", Offset = "0x46BAB00", VA = "0x1846BBD00")]
	public JECHPJFKJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class GHMAPOKABGD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private global::GHMAPOKABGD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8D4AD0", Offset = "0x8D38D0", VA = "0x1808D4AD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x28B6670", Offset = "0x28B5470", VA = "0x1828B6670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28B68E0", Offset = "0x28B56E0", VA = "0x1828B68E0")]
		public Enumerator(global::GHMAPOKABGD<T> DLJHFCENONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28B5EF0", Offset = "0x28B4CF0", VA = "0x1828B5EF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28B62E0", Offset = "0x28B50E0", VA = "0x1828B62E0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28B5C30", Offset = "0x28B4A30", VA = "0x1828B5C30")]
		private void CGLEFAOOOKM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private T[] HIBKHIHBJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CHMJDGBLLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int JLOKGPBMKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int ANOPPJLGPDO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x28B9960", Offset = "0x28B8760", VA = "0x1828B9960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x28BB2C0", Offset = "0x28BA0C0", VA = "0x1828BB2C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x28BB050", Offset = "0x28B9E50", VA = "0x1828BB050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x28BB9E0", Offset = "0x28BA7E0", VA = "0x1828BB9E0")]
	public GHMAPOKABGD(int IMNCEOIPJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x28BB500", Offset = "0x28BA300", VA = "0x1828BB500")]
	public void NGPIMMKGFMI(T NCLDEDMIFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x28BA2C0", Offset = "0x28B90C0", VA = "0x1828BA2C0")]
	public void GNKPCPADAIN(IEnumerable<T> OMIIMFGLMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x28BA2A0", Offset = "0x28B90A0", VA = "0x1828BA2A0")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28BB470", Offset = "0x28BA270", VA = "0x1828BB470")]
	public void MEGGLDDHEPN(int FDHPLBOBCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x28BB100", Offset = "0x28B9F00", VA = "0x1828BB100")]
	public void IPGGGOCAIPE(int FDHPLBOBCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x28B99A0", Offset = "0x28B87A0", VA = "0x1828B99A0")]
	public void CLGPMLLJJHN(T[] KGBBFPHOMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28BB400", Offset = "0x28BA200", VA = "0x1828BB400")]
	public Enumerator LPPJAAHLHFO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28BB8A0", Offset = "0x28BA6A0", VA = "0x1828BB8A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x28BB8A0", Offset = "0x28BA6A0", VA = "0x1828BB8A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x28BA0C0", Offset = "0x28B8EC0", VA = "0x1828BA0C0")]
	private int GAMCFICAHKA(int IMDCPBGFCMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x28BB0D0", Offset = "0x28B9ED0", VA = "0x1828BB0D0")]
	private int IBGOGGAOEBM(int IMDCPBGFCMD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class FJBMOCBILAH<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Func<Internal, External> EBOJCLPOGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly Func<External, Internal> GJMDIGAHHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private IList<Internal> KBFCGHDEKBD;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> GHIPOEDMANN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MLHMDIBJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x62C620", Offset = "0x62B420", VA = "0x18062C620", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76D2B0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x38D70F0", Offset = "0x38D5EF0", VA = "0x1838D70F0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x38D7190", Offset = "0x38D5F90", VA = "0x1838D7190", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x38D7090", Offset = "0x38D5E90", VA = "0x1838D7090", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38D7000", Offset = "0x38D5E00", VA = "0x1838D7000")]
	public FJBMOCBILAH(Func<Internal, External> EBOJCLPOGME, Func<External, Internal> GJMDIGAHHNO, bool NDNPKPFBMKJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x38D6D10", Offset = "0x38D5B10", VA = "0x1838D6D10", Slot = "6")]
	public int IndexOf(External EKJALHDOPCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38D68E0", Offset = "0x38D56E0", VA = "0x1838D68E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38D6990", Offset = "0x38D5790", VA = "0x1838D6990", Slot = "13")]
	public bool Contains(External EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x38D6A20", Offset = "0x38D5820", VA = "0x1838D6A20", Slot = "14")]
	public void CopyTo(External[] KGBBFPHOMGB, int KLFCFLDJMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38D67F0", Offset = "0x38D55F0", VA = "0x1838D67F0", Slot = "11")]
	public void Add(External EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x38D6E00", Offset = "0x38D5C00", VA = "0x1838D6E00", Slot = "7")]
	public void Insert(int IMDCPBGFCMD, External EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x38D6F70", Offset = "0x38D5D70", VA = "0x1838D6F70", Slot = "15")]
	public bool Remove(External EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x38D6EA0", Offset = "0x38D5CA0", VA = "0x1838D6EA0", Slot = "8")]
	public void RemoveAt(int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x38D6C40", Offset = "0x38D5A40", VA = "0x1838D6C40", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2607260", Offset = "0x2606060", VA = "0x182607260", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class BOBBEOBEFFB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly Func<Internal, External> EBOJCLPOGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private IReadOnlyList<Internal> KBFCGHDEKBD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> GHIPOEDMANN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool MLHMDIBJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x522FE0", Offset = "0x521DE0", VA = "0x180522FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3C07210", Offset = "0x3C06010", VA = "0x183C07210", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3C071B0", Offset = "0x3C05FB0", VA = "0x183C071B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2727290", Offset = "0x2726090", VA = "0x182727290")]
	public BOBBEOBEFFB(Func<Internal, External> EBOJCLPOGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3C07160", Offset = "0x3C05F60", VA = "0x183C07160")]
	public BOBBEOBEFFB(IReadOnlyList<Internal> KBFCGHDEKBD, Func<Internal, External> EBOJCLPOGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3C06ED0", Offset = "0x3C05CD0", VA = "0x183C06ED0")]
	public void CLGPMLLJJHN(External[] KGBBFPHOMGB, int KLFCFLDJMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3C070F0", Offset = "0x3C05EF0", VA = "0x183C070F0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x260E050", Offset = "0x260CE50", VA = "0x18260E050", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class MDGGEBNECEB<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private IReadOnlyList<Internal> KBFCGHDEKBD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> GHIPOEDMANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MLHMDIBJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x522FE0", Offset = "0x521DE0", VA = "0x180522FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3706BF0", Offset = "0x37059F0", VA = "0x183706BF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3706B90", Offset = "0x3705990", VA = "0x183706B90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2727290", Offset = "0x2726090", VA = "0x182727290")]
	public MDGGEBNECEB(IReadOnlyList<Internal> KBFCGHDEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3706AF0", Offset = "0x37058F0", VA = "0x183706AF0")]
	public bool OKCEKAKCNAH(External EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3706850", Offset = "0x3705650", VA = "0x183706850")]
	public void CLGPMLLJJHN(External[] KGBBFPHOMGB, int KLFCFLDJMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3706A80", Offset = "0x3705880", VA = "0x183706A80", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2607260", Offset = "0x2606060", VA = "0x182607260", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class JPFLDGFIEPE
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NKGNCFDOKAB(object[] OGCCHBFJPAB);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	protected JPFLDGFIEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class AFPLKGAPKNF<T> : JPFLDGFIEPE
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	protected struct FCJNPDJPGEL
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum PMPKLAHPGOH
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public PMPKLAHPGOH FEGCMBEFABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public T DIKCECEKHKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private int MCCCODFCKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly bool HHGCNENCADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	protected readonly bool DHLOBFDGBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected List<T> EFIHBHPCDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<FCJNPDJPGEL> FNCLEDGFEJO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DAKBAJLPFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2F68AD0", Offset = "0x2F678D0", VA = "0x182F68AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2F68FA0", Offset = "0x2F67DA0", VA = "0x182F68FA0")]
	protected AFPLKGAPKNF(bool DHLOBFDGBCE, bool HHGCNENCADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2F68900", Offset = "0x2F67700", VA = "0x182F68900")]
	protected bool CECCCABNBFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2F68820", Offset = "0x2F67620", VA = "0x182F68820")]
	protected void AMCILBIOJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2F68B10", Offset = "0x2F67910", VA = "0x182F68B10")]
	protected void MIBFJBJGFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2836920", Offset = "0x2835720", VA = "0x182836920")]
	private static void MPAPCDGPDKL<U>(ref List<U> KBFCGHDEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2F68CC0", Offset = "0x2F67AC0", VA = "0x182F68CC0", Slot = "5")]
	public void NGPIMMKGFMI(T DIKCECEKHKC, bool NAEOBFAKLNI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2F68E40", Offset = "0x2F67C40", VA = "0x182F68E40", Slot = "6")]
	public void OGCMIFMLPGF(T DIKCECEKHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2F689A0", Offset = "0x2F677A0", VA = "0x182F689A0")]
	public void GJNEFCAFABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface ANDPEIPONNN
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class LKKJDCJIBEF : global::AFPLKGAPKNF<Action>, ANDPEIPONNN
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4B56D50", Offset = "0x4B55B50", VA = "0x184B56D50")]
	public LKKJDCJIBEF(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4B56A50", Offset = "0x4B55850", VA = "0x184B56A50")]
	public void LFNNGNNHDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4B56C70", Offset = "0x4B55A70", VA = "0x184B56C70", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4B56C10", Offset = "0x4B55A10", VA = "0x184B56C10")]
	public static LKKJDCJIBEF MBKONHDDFDE(LKKJDCJIBEF CHOIEPEFGJJ, Action DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4B56CF0", Offset = "0x4B55AF0", VA = "0x184B56CF0")]
	public static LKKJDCJIBEF PAILFEFMMAH(LKKJDCJIBEF CHOIEPEFGJJ, Action DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCNEFDCCHBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class CNNKIFKGGFF<T> : global::AFPLKGAPKNF<Action<T>>, global::HCNEFDCCHBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public CNNKIFKGGFF(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x36BA460", Offset = "0x36B9260", VA = "0x1836BA460")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x36BC340", Offset = "0x36BB140", VA = "0x1836BC340", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x36BB750", Offset = "0x36BA550", VA = "0x1836BB750")]
	public static global::CNNKIFKGGFF<T> MBKONHDDFDE(global::CNNKIFKGGFF<T> CHOIEPEFGJJ, Action<T> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x36BD4F0", Offset = "0x36BC2F0", VA = "0x1836BD4F0")]
	public static global::CNNKIFKGGFF<T> PAILFEFMMAH(global::CNNKIFKGGFF<T> CHOIEPEFGJJ, Action<T> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface ODGCLEEFMNF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T, U> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T, U> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class EDDMEMNPBID<T, U> : global::AFPLKGAPKNF<Action<T, U>>, global::ODGCLEEFMNF<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public EDDMEMNPBID(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x347B3A0", Offset = "0x347A1A0", VA = "0x18347B3A0")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ, U AGNPICGJIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x347D320", Offset = "0x347C120", VA = "0x18347D320", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x347C8C0", Offset = "0x347B6C0", VA = "0x18347C8C0")]
	public static global::EDDMEMNPBID<T, U> MBKONHDDFDE(global::EDDMEMNPBID<T, U> CHOIEPEFGJJ, Action<T, U> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x347F0C0", Offset = "0x347DEC0", VA = "0x18347F0C0")]
	public static global::EDDMEMNPBID<T, U> PAILFEFMMAH(global::EDDMEMNPBID<T, U> CHOIEPEFGJJ, Action<T, U> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface IPEOHEHBKGJ<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T, U, V> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T, U, V> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class ELOPDJNONAN<T, U, V> : global::AFPLKGAPKNF<Action<T, U, V>>, global::IPEOHEHBKGJ<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public ELOPDJNONAN(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3486E60", Offset = "0x3485C60", VA = "0x183486E60")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ, U AGNPICGJIEB, V GOCEOGCFGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3488FA0", Offset = "0x3487DA0", VA = "0x183488FA0", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34882C0", Offset = "0x34870C0", VA = "0x1834882C0")]
	public static global::ELOPDJNONAN<T, U, V> MBKONHDDFDE(global::ELOPDJNONAN<T, U, V> CHOIEPEFGJJ, Action<T, U, V> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3489C00", Offset = "0x3488A00", VA = "0x183489C00")]
	public static global::ELOPDJNONAN<T, U, V> PAILFEFMMAH(global::ELOPDJNONAN<T, U, V> CHOIEPEFGJJ, Action<T, U, V> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BMEEIOPOHGH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T, U, V, W> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T, U, V, W> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class DHHJABNICKC<T, U, V, W> : global::AFPLKGAPKNF<Action<T, U, V, W>>, global::BMEEIOPOHGH<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public DHHJABNICKC(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8E20", Offset = "0x3CC7C20", VA = "0x183CC8E20")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ, U AGNPICGJIEB, V GOCEOGCFGOI, W LMHLEELBKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAE50", Offset = "0x3CC9C50", VA = "0x183CCAE50", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA650", Offset = "0x3CC9450", VA = "0x183CCA650")]
	public static global::DHHJABNICKC<T, U, V, W> MBKONHDDFDE(global::DHHJABNICKC<T, U, V, W> CHOIEPEFGJJ, Action<T, U, V, W> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCBD60", Offset = "0x3CCAB60", VA = "0x183CCBD60")]
	public static global::DHHJABNICKC<T, U, V, W> PAILFEFMMAH(global::DHHJABNICKC<T, U, V, W> CHOIEPEFGJJ, Action<T, U, V, W> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KJJDNDPJCMO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T, U, V, W, X> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T, U, V, W, X> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class GNOMILPMKOM<T, U, V, W, X> : global::AFPLKGAPKNF<Action<T, U, V, W, X>>, global::KJJDNDPJCMO<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public GNOMILPMKOM(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x28C1290", Offset = "0x28C0090", VA = "0x1828C1290")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ, U AGNPICGJIEB, V GOCEOGCFGOI, W LMHLEELBKOB, X DCMLOLBECIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x28C1C00", Offset = "0x28C0A00", VA = "0x1828C1C00", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x28C1840", Offset = "0x28C0640", VA = "0x1828C1840")]
	public static global::GNOMILPMKOM<T, U, V, W, X> MBKONHDDFDE(global::GNOMILPMKOM<T, U, V, W, X> CHOIEPEFGJJ, Action<T, U, V, W, X> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x28C1EF0", Offset = "0x28C0CF0", VA = "0x1828C1EF0")]
	public static global::GNOMILPMKOM<T, U, V, W, X> PAILFEFMMAH(global::GNOMILPMKOM<T, U, V, W, X> CHOIEPEFGJJ, Action<T, U, V, W, X> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface MNKCLDPCDEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGPIMMKGFMI(Action<T, U, V, W, X, Y> DIKCECEKHKC, bool NAEOBFAKLNI = false);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGCMIFMLPGF(Action<T, U, V, W, X, Y> DIKCECEKHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NABKIFCDAMG<T, U, V, W, X, Y> : global::AFPLKGAPKNF<Action<T, U, V, W, X, Y>>, global::MNKCLDPCDEP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x28C1F90", Offset = "0x28C0D90", VA = "0x1828C1F90")]
	public NABKIFCDAMG(bool DHLOBFDGBCE = false, bool HHGCNENCADH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3934470", Offset = "0x3933270", VA = "0x183934470")]
	public void LFNNGNNHDDO(T NCLDEDMIFEJ, U AGNPICGJIEB, V GOCEOGCFGOI, W LMHLEELBKOB, X DCMLOLBECIB, Y FNPBMEBCJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3934B40", Offset = "0x3933940", VA = "0x183934B40", Slot = "4")]
	public override void NKGNCFDOKAB(object[] OGCCHBFJPAB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3934730", Offset = "0x3933530", VA = "0x183934730")]
	public static global::NABKIFCDAMG<T, U, V, W, X, Y> MBKONHDDFDE(global::NABKIFCDAMG<T, U, V, W, X, Y> CHOIEPEFGJJ, Action<T, U, V, W, X, Y> DIKCECEKHKC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x39351D0", Offset = "0x3933FD0", VA = "0x1839351D0")]
	public static global::NABKIFCDAMG<T, U, V, W, X, Y> PAILFEFMMAH(global::NABKIFCDAMG<T, U, V, W, X, Y> CHOIEPEFGJJ, Action<T, U, V, W, X, Y> DIKCECEKHKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CMEFHMMIOIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct CBIOEKCKFFF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly global::CMEFHMMIOIH<T> AGPKOBFFJCG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T NMGHIPGAEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x36B5E30", Offset = "0x36B4C30", VA = "0x1836B5E30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x36B5E00", Offset = "0x36B4C00", VA = "0x1836B5E00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7495E0", Offset = "0x7483E0", VA = "0x1807495E0")]
		public CBIOEKCKFFF(global::CMEFHMMIOIH<T> AGPKOBFFJCG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct BOALGFPBDHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<CBIOEKCKFFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public global::CMEFHMMIOIH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x36B5BE0", Offset = "0x36B49E0", VA = "0x1836B5BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x36B5DB0", Offset = "0x36B4BB0", VA = "0x1836B5DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct POBEOIPDBGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<CBIOEKCKFFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public global::CMEFHMMIOIH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x36C8D20", Offset = "0x36C7B20", VA = "0x1836C8D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x36B5DB0", Offset = "0x36B4BB0", VA = "0x1836B5DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly SemaphoreSlim GOFPNLDOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private T EPMAPMMCJAL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JOACPIALFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x36B8010", Offset = "0x36B6E10", VA = "0x1836B8010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x36B8030", Offset = "0x36B6E30", VA = "0x1836B8030")]
	public CMEFHMMIOIH(in T EPMAPMMCJAL, int COBIKGACCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2722670", Offset = "0x2721470", VA = "0x182722670")]
	public CMEFHMMIOIH(in T EPMAPMMCJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x36B7A10", Offset = "0x36B6810", VA = "0x1836B7A10")]
	public CBIOEKCKFFF FJNEFJABAFO()
	{
		return default(CBIOEKCKFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x36B79D0", Offset = "0x36B67D0", VA = "0x1836B79D0")]
	public CBIOEKCKFFF FJNEFJABAFO(CancellationToken NPNNOOBBHFE)
	{
		return default(CBIOEKCKFFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x36B7EB0", Offset = "0x36B6CB0", VA = "0x1836B7EB0")]
	[AsyncStateMachine(typeof(global::CMEFHMMIOIH<>.BOALGFPBDHC))]
	public Task<CBIOEKCKFFF> KKBIMDDFKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x36B7D30", Offset = "0x36B6B30", VA = "0x1836B7D30")]
	[AsyncStateMachine(typeof(global::CMEFHMMIOIH<>.POBEOIPDBGK))]
	public Task<CBIOEKCKFFF> KKBIMDDFKNP(CancellationToken NPNNOOBBHFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NNAMNHGFJFI
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4B572D0", Offset = "0x4B560D0", VA = "0x184B572D0")]
	public static global::CMEFHMMIOIH<LNDPKAFLDND> PEPJCOIMNOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4B57260", Offset = "0x4B56060", VA = "0x184B57260")]
	public static global::CMEFHMMIOIH<LNDPKAFLDND> PEPJCOIMNOL(int COBIKGACCEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x27DE260", Offset = "0x27DD060", VA = "0x1827DE260")]
	public static global::CMEFHMMIOIH<T> PEPJCOIMNOL<T>(in T EPMAPMMCJAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x26B12A0", Offset = "0x26B00A0", VA = "0x1826B12A0")]
	public static global::CMEFHMMIOIH<T> PEPJCOIMNOL<T>(in T EPMAPMMCJAL, int COBIKGACCEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GCFAFDLHEFJ<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate bool HNNIMJDIBEN(global::GCFAFDLHEFJ<T> OBJPKPCAKNL);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class NAFIHAFEEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::GCFAFDLHEFJ<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public NAFIHAFEEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F250", Offset = "0x2C0E050", VA = "0x182C0F250")]
		internal bool <FindNode>b__0(global::GCFAFDLHEFJ<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public T AKINHGDEEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LinkedList<global::GCFAFDLHEFJ<T>> FCNIPKEKDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public global::GCFAFDLHEFJ<T> JDBMJPLCLIJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::GCFAFDLHEFJ<T> IFHOJLIAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDE80", Offset = "0x5FCC80", VA = "0x1805FDE80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2C036B0", Offset = "0x2C024B0", VA = "0x182C036B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KEAEEGLIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2C038F0", Offset = "0x2C026F0", VA = "0x182C038F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JEGALBFEMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x2C03960", Offset = "0x2C02760", VA = "0x182C03960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GCFAFDLHEFJ<T> IBMKHGGBBKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x2C03870", Offset = "0x2C02670", VA = "0x182C03870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2C05830", Offset = "0x2C04630", VA = "0x182C05830")]
	public GCFAFDLHEFJ(T HOCHNAIKDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2C04870", Offset = "0x2C03670", VA = "0x182C04870")]
	public global::GCFAFDLHEFJ<T> LNHGKKHAHGG(T BJEJIHPNBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2C044E0", Offset = "0x2C032E0", VA = "0x182C044E0")]
	public global::GCFAFDLHEFJ<T> KGPLJLMBKBK(T HJKGGOAOHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2C04A80", Offset = "0x2C03880", VA = "0x182C04A80")]
	public global::GCFAFDLHEFJ<T> OGCMIFMLPGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2C03C00", Offset = "0x2C02A00", VA = "0x182C03C00")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2C04C90", Offset = "0x2C03A90", VA = "0x182C04C90")]
	public global::GCFAFDLHEFJ<T> OJIOICJEDAF(T MIOILDJFLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2C041A0", Offset = "0x2C02FA0", VA = "0x182C041A0")]
	public static void IFKPOEIHFGG(global::GCFAFDLHEFJ<T> DHLEHNAGAMA, HNNIMJDIBEN OAEFIHFINLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x34082E0", Offset = "0x34070E0", VA = "0x1834082E0")]
	public static void IFKPOEIHFGG<A>(global::GCFAFDLHEFJ<T> DHLEHNAGAMA, Func<global::GCFAFDLHEFJ<T>, A, bool> OAEFIHFINLM, A IOIPPNFHGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2C04DA0", Offset = "0x2C03BA0", VA = "0x182C04DA0")]
	public static string OKGNBHIHBOM(global::GCFAFDLHEFJ<T> DHLEHNAGAMA, int GPFBOLLGNHI = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2C03280", Offset = "0x2C02080", VA = "0x182C03280")]
	public static global::GCFAFDLHEFJ<T> AHKGNDCPAEA(global::GCFAFDLHEFJ<T> DHLEHNAGAMA, T MDABNMOHODH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LKNJJECFMIC<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> BMLDLAMHKMN(TRequest LBOBHKOOIAP, CancellationToken NPNNOOBBHFE);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum EKBPFPPODIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class DKMICINIMMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private const float DBKKPINEFNB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TimeSpan ELDEIBKNNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int BMLNKFFLDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EKBPFPPODIE JOPJIIJAJGP;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public static readonly DKMICINIMMI OJCIGOFJNDO;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float FPGIJENMLEM
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x36F52A0", Offset = "0x36F40A0", VA = "0x1836F52A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan HPPMIBJNMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x36F54D0", Offset = "0x36F42D0", VA = "0x1836F54D0")]
		public DKMICINIMMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct PEPBCKGMIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly TRequest LBOBHKOOIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly CancellationToken NPNNOOBBHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly TaskCompletionSource<TResult> AFMGIEKACLH;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3709A40", Offset = "0x3708840", VA = "0x183709A40")]
		public PEPBCKGMIBL(TRequest LBOBHKOOIAP, TaskCompletionSource<TResult> AFMGIEKACLH, CancellationToken NPNNOOBBHFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class JNKPLOFGLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public JNKPLOFGLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1E0", Offset = "0x28C9FE0", VA = "0x1828CB1E0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct KIHNEDPFEIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public global::LKNJJECFMIC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x36FB190", Offset = "0x36F9F90", VA = "0x1836FB190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8375F0", Offset = "0x8363F0", VA = "0x1808375F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NPNHICCIIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PEPBCKGMIBL req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public global::LKNJJECFMIC<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public NPNHICCIIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3709690", Offset = "0x3708490", VA = "0x183709690")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CancellationTokenSource NMOLNFFJAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly List<PEPBCKGMIBL> JIFFHBKCCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DKMICINIMMI OHHJMPBIMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BMLDLAMHKMN IGEGHHKHLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Task BDPKDKPJFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private int NAOEELMMMEO;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3701570", Offset = "0x3700370", VA = "0x183701570")]
	public LKNJJECFMIC(BMLDLAMHKMN IGEGHHKHLLE, [Optional] DKMICINIMMI OHHJMPBIMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3700780", Offset = "0x36FF580", VA = "0x183700780")]
	public Task<TResult> DMJENOENLED(TRequest LBOBHKOOIAP, CancellationToken NPNNOOBBHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x37014E0", Offset = "0x37002E0", VA = "0x1837014E0")]
	private void GPHMKJHOEHJ(PEPBCKGMIBL KDPOMHINFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x37001E0", Offset = "0x36FEFE0", VA = "0x1837001E0")]
	[AsyncStateMachine(typeof(global::LKNJJECFMIC<, >.KIHNEDPFEIM))]
	private Task COMFHDGLODD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3700F00", Offset = "0x36FFD00", VA = "0x183700F00")]
	private PEPBCKGMIBL EFMIOCCNKJN()
	{
		return default(PEPBCKGMIBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x36FFC10", Offset = "0x36FEA10", VA = "0x1836FFC10")]
	private void CJHDOJAPENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3700C30", Offset = "0x36FFA30", VA = "0x183700C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class ODDGJLNMIDK<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int MCMJEPKKFNB(TKey IFKOMGEEEMC, TVal PEPOHKCFAOG);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BLGNBLFDEKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TKey EKMCGMDHAGI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TVal NMGHIPGAEHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x769780", Offset = "0x768580", VA = "0x180769780")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x769D40", Offset = "0x768B40", VA = "0x180769D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int JHKKINIGJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D14A0", Offset = "0x5D02A0", VA = "0x1805D14A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x58A560", Offset = "0x589360", VA = "0x18058A560")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public DateTime LJAGGAMGIGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x7C6D60", Offset = "0x7C5B60", VA = "0x1807C6D60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3884C10", Offset = "0x3883A10", VA = "0x183884C10")]
		public BLGNBLFDEKN(TKey IFKOMGEEEMC, TVal HGHHGPACLPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int FNCGFECGEMJ = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Dictionary<TKey, LinkedListNode<BLGNBLFDEKN>> GAGGMGEPBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly LinkedList<BLGNBLFDEKN> JKINOHMGENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly MCMJEPKKFNB MJOIELKOCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly TimeSpan GPMCKKKEOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly FCIIKPKFPDN GPAMEIFGGEI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int BPDIMLEAABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F32E0", Offset = "0x6F20E0", VA = "0x1806F32E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool IDBDLDOOFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x388F5D0", Offset = "0x388E3D0", VA = "0x18388F5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal int GCLDCDNKLFC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x705360", Offset = "0x704160", VA = "0x180705360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7C17C0", Offset = "0x7C05C0", VA = "0x1807C17C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2762730", Offset = "0x2761530", VA = "0x182762730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IEnumerable<TKey> GCKOBJPDJFB
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x388E910", Offset = "0x388D710", VA = "0x18388E910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public TVal IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x388F660", Offset = "0x388E460", VA = "0x18388F660")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x388F410", Offset = "0x388E210", VA = "0x18388F410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3890190", Offset = "0x388EF90", VA = "0x183890190")]
	public ODDGJLNMIDK(int IMNCEOIPJNE, [Optional] MCMJEPKKFNB MJOIELKOCDD, [Optional] IEqualityComparer<TKey> HOGPNGMDKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x388FE20", Offset = "0x388EC20", VA = "0x18388FE20")]
	public ODDGJLNMIDK(TimeSpan GPMCKKKEOMD, [Optional] IEqualityComparer<TKey> HOGPNGMDKCO, [Optional] FCIIKPKFPDN GPAMEIFGGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x388FDD0", Offset = "0x388EBD0", VA = "0x18388FDD0")]
	public ODDGJLNMIDK(int IMNCEOIPJNE, TimeSpan GPMCKKKEOMD, [Optional] IEqualityComparer<TKey> HOGPNGMDKCO, [Optional] FCIIKPKFPDN GPAMEIFGGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3890260", Offset = "0x388F060", VA = "0x183890260")]
	public ODDGJLNMIDK(int IMNCEOIPJNE, MCMJEPKKFNB MJOIELKOCDD, TimeSpan GPMCKKKEOMD, [Optional] IEqualityComparer<TKey> HOGPNGMDKCO, [Optional] FCIIKPKFPDN GPAMEIFGGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x388E390", Offset = "0x388D190", VA = "0x18388E390")]
	public void ADHPEEPNAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x388F820", Offset = "0x388E620", VA = "0x18388F820")]
	public void OKBEIPOGICA(TKey IFKOMGEEEMC, TVal PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x388F690", Offset = "0x388E490", VA = "0x18388F690")]
	public bool OGCMIFMLPGF(TKey IFKOMGEEEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x388F510", Offset = "0x388E310", VA = "0x18388F510")]
	private TVal HPAAPNLJBAF(TKey HNDPMALOKEA)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x388FB20", Offset = "0x388E920", VA = "0x18388FB20")]
	public bool PDIMMFIGHEA(TKey HNDPMALOKEA, out TVal PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x388F390", Offset = "0x388E190", VA = "0x18388F390")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x388F9A0", Offset = "0x388E7A0", VA = "0x18388F9A0")]
	private bool PAADABALGEL(BLGNBLFDEKN OAOOHEOOPGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x388F100", Offset = "0x388DF00", VA = "0x18388F100")]
	private void CPPELOFDHOA(LinkedListNode<BLGNBLFDEKN> BALPIBKOIKB, TVal MBGAGEJIJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x388E700", Offset = "0x388D500", VA = "0x18388E700")]
	private void BNLCMKMOKMD(TKey IFKOMGEEEMC, TVal PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x388ECD0", Offset = "0x388DAD0", VA = "0x18388ECD0")]
	private void CPHNEMOGAKJ(BLGNBLFDEKN OAOOHEOOPGM, TVal MBGAGEJIJFA, int ACHEGPDDCMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class AFMDBOLIPGP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<T> KBFCGHDEKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private HashSet<T> IBBLEMFKKCM;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1E0", Offset = "0x28C9FE0", VA = "0x1828CB1E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool MLHMDIBJFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x522EC0", Offset = "0x521CC0", VA = "0x180522EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public T IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F68670", Offset = "0x2F67470", VA = "0x182F68670", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F68760", Offset = "0x2F67560", VA = "0x182F68760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x28BFF40", Offset = "0x28BED40", VA = "0x1828BFF40", Slot = "11")]
	public void Add(T EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F68130", Offset = "0x2F66F30", VA = "0x182F68130")]
	public bool LLIEDMKLNJB(T EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F684E0", Offset = "0x2F672E0", VA = "0x182F684E0", Slot = "15")]
	public bool Remove(T EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F67D50", Offset = "0x2F66B50", VA = "0x182F67D50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F68560", Offset = "0x2F67360", VA = "0x182F68560", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2F67CC0", Offset = "0x2F66AC0", VA = "0x182F67CC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27292E0", Offset = "0x27280E0", VA = "0x1827292E0", Slot = "13")]
	public bool Contains(T EKJALHDOPCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2F67D20", Offset = "0x2F66B20", VA = "0x182F67D20", Slot = "14")]
	public void CopyTo(T[] KGBBFPHOMGB, int KLFCFLDJMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2F67DD0", Offset = "0x2F66BD0", VA = "0x182F67DD0", Slot = "6")]
	public int IndexOf(T EKJALHDOPCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2F67E00", Offset = "0x2F66C00", VA = "0x182F67E00", Slot = "7")]
	public void Insert(int IMDCPBGFCMD, T EKJALHDOPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2F682B0", Offset = "0x2F670B0", VA = "0x182F682B0", Slot = "8")]
	public void RemoveAt(int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F68060", Offset = "0x2F66E60", VA = "0x182F68060")]
	public void LEHOAJGPLFC(Predicate<T> LFHECFFPPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F68280", Offset = "0x2F67080", VA = "0x182F68280")]
	public void NMMENAJEOOG(Comparison<T> FBKBHGONALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F68590", Offset = "0x2F67390", VA = "0x182F68590")]
	public AFMDBOLIPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CBHANIKOIKJ
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B542E0", Offset = "0x4B530E0", VA = "0x184B542E0")]
	public static Vector3 OIBNJFBOPBO(this GameObject LHOMOGPNLAL, float POEGBEDCCCA)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5DA510", Offset = "0x5D9310", VA = "0x1805DA510")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B59950", Offset = "0x4B58750", VA = "0x184B59950")]
		public SerializedGuid(in Guid MIOLOJDBEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B59770", Offset = "0x4B58570", VA = "0x184B59770")]
		public static SerializedGuid JJDDHBKONNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4B594A0", Offset = "0x4B582A0", VA = "0x184B594A0")]
		public static SerializedGuid ACODKBEBPAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4B59520", Offset = "0x4B58320", VA = "0x184B59520")]
		public bool ANIOOALEMMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4B59920", Offset = "0x4B58720", VA = "0x184B59920", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4B59880", Offset = "0x4B58680", VA = "0x184B59880", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4B597F0", Offset = "0x4B585F0", VA = "0x184B597F0")]
		public bool MOAHIBEKJCF(in Guid MIOLOJDBEFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4B595E0", Offset = "0x4B583E0", VA = "0x184B595E0", Slot = "7")]
		public bool Equals(SerializedGuid KBAPGFOKKBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4B59680", Offset = "0x4B58480", VA = "0x184B59680", Slot = "0")]
		public override bool Equals(object AHLFMJPCIDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4B59760", Offset = "0x4B58560", VA = "0x184B59760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4B595B0", Offset = "0x4B583B0", VA = "0x184B595B0", Slot = "6")]
		public int CompareTo(SerializedGuid KBAPGFOKKBB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class DDLHMIGEINK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly Type BGAGOPCGMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string HLHLEFKNIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly bool BMCKFFHMCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public readonly bool OBLJOJAAIFI;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B54650", Offset = "0x4B53450", VA = "0x184B54650")]
	public DDLHMIGEINK(Type IDMGLEHFHPM, string GFAPCFHIPHM, bool ILPNFNGBKHF = false, bool LIIMHILAGKG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface GHLJEGHLGKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface DADCNMPPOON<T> : GHLJEGHLGKF
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CFCFKFKKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string BBGFEMAJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::DADCNMPPOON<T> JKLDFFJHEAM(Action<T> GDNDBJJCMCK);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::DADCNMPPOON<T> PECCLJEHEBJ(Action<T> GDNDBJJCMCK);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::DADCNMPPOON<T> NMNCBIIKJJA(Action<T, T> KJIPIKFFMJI);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::DADCNMPPOON<T> FHHKFGEKKMH(Action<T, T> KJIPIKFFMJI);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::DADCNMPPOON<T> FMHCBOCKEIH(Action<string> MLLMMOPKNGM);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DADCNMPPOON<T> MFPGBHPJAJO(Action<string> MLLMMOPKNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NDKBOOIGGGM<T> : global::DADCNMPPOON<T>, GHLJEGHLGKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private global::EDDMEMNPBID<T, T> HJCOPFGKHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private global::CNNKIFKGGFF<T> LBHHLJIADIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private global::CNNKIFKGGFF<string> AOCJPEGANPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private string IHOKHFNAGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private T OEKNFPMCAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool BABCLFPPEAM;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public T NMGHIPGAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x271FBF0", Offset = "0x271E9F0", VA = "0x18271FBF0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool CFCFKFKKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x62D540", Offset = "0x62C340", VA = "0x18062D540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string BBGFEMAJFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x54B0C0", Offset = "0x549EC0", VA = "0x18054B0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x271F7A0", Offset = "0x271E5A0", VA = "0x18271F7A0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x271FB50", Offset = "0x271E950", VA = "0x18271FB50")]
	private void PCNJDBECILG(T ICHCCKHPGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x271F960", Offset = "0x271E760", VA = "0x18271F960")]
	private void JIPPOKHIINA(string FJNMEOAHDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x271F820", Offset = "0x271E620", VA = "0x18271F820")]
	public void FJGFFBLJIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x271FB00", Offset = "0x271E900", VA = "0x18271FB00", Slot = "6")]
	public global::DADCNMPPOON<T> NMNCBIIKJJA(Action<T, T> KJIPIKFFMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x271F7D0", Offset = "0x271E5D0", VA = "0x18271F7D0", Slot = "7")]
	public global::DADCNMPPOON<T> FHHKFGEKKMH(Action<T, T> KJIPIKFFMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x271FA00", Offset = "0x271E800", VA = "0x18271FA00", Slot = "4")]
	public global::DADCNMPPOON<T> JKLDFFJHEAM(Action<T> KJIPIKFFMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x271FC20", Offset = "0x271EA20", VA = "0x18271FC20", Slot = "5")]
	public global::DADCNMPPOON<T> PECCLJEHEBJ(Action<T> GDNDBJJCMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x271F8D0", Offset = "0x271E6D0", VA = "0x18271F8D0", Slot = "8")]
	public global::DADCNMPPOON<T> FMHCBOCKEIH(Action<string> MLLMMOPKNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x271FA90", Offset = "0x271E890", VA = "0x18271FA90", Slot = "9")]
	public global::DADCNMPPOON<T> MFPGBHPJAJO(Action<string> MLLMMOPKNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x271FC70", Offset = "0x271EA70", VA = "0x18271FC70")]
	public NDKBOOIGGGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class LIDGENINALM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ILKDGHEEBJO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public global::DADCNMPPOON<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public global::CDLEAIJLAJI<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public ILKDGHEEBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x2FB95A0", Offset = "0x2FB83A0", VA = "0x182FB95A0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x26AC540", Offset = "0x26AB340", VA = "0x1826AC540")]
	public static global::CBNPJNGNOBA<T> DGDPGKGOGNL<T>(this global::DADCNMPPOON<T> JHGOKCFDJHN, Action<T> IFOGDLBNNEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class FCIIKPKFPDN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class CBAAGMEAJOD : FCIIKPKFPDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static FCIIKPKFPDN MHOGIHBANHN
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4B54180", Offset = "0x4B52F80", VA = "0x184B54180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override DateTime BJPJBBJHGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4B54130", Offset = "0x4B52F30", VA = "0x184B54130", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override float KCDEFJIFBBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B4D7A0", Offset = "0x4B4C5A0", VA = "0x184B4D7A0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4B54280", Offset = "0x4B53080", VA = "0x184B54280")]
		public CBAAGMEAJOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static FCIIKPKFPDN IIEILCMGAGC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public static FCIIKPKFPDN OJCIGOFJNDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4B54760", Offset = "0x4B53560", VA = "0x184B54760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract DateTime BJPJBBJHGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public abstract float KCDEFJIFBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	protected FCIIKPKFPDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class AKMJHMFODFC : global::DPGHIBNPLAO<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B53CA0", Offset = "0x4B52AA0", VA = "0x184B53CA0")]
	public AKMJHMFODFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DPGHIBNPLAO<T> : global::LALBDIOHIHH<T>, CIFCDNJLAOP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Task<T> INGFLBMKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Task GBJBCIICMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x25FD110", Offset = "0x25FBF10", VA = "0x1825FD110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public global::CBNPJNGNOBA<T> EIICMKALNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private PCDEFPAPNCL HKBAMJMFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x2600020", Offset = "0x25FEE20", VA = "0x182600020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x38F2D90", Offset = "0x38F1B90", VA = "0x1838F2D90")]
	public DPGHIBNPLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CDBNCOLMIIL : global::FJMNINPECJA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B54570", Offset = "0x4B53370", VA = "0x184B54570")]
	public CDBNCOLMIIL(Exception FLNLIILPCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FJMNINPECJA<T> : global::LALBDIOHIHH<T>, CIFCDNJLAOP, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> INGFLBMKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task GBJBCIICMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x25FD110", Offset = "0x25FBF10", VA = "0x1825FD110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::CBNPJNGNOBA<T> EIICMKALNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private PCDEFPAPNCL HKBAMJMFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2600020", Offset = "0x25FEE20", VA = "0x182600020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x38D7230", Offset = "0x38D6030", VA = "0x1838D7230")]
	public FJMNINPECJA(Exception FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface CIFCDNJLAOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	Task INGFLBMKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	PCDEFPAPNCL EIICMKALNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface LALBDIOHIHH<T> : CIFCDNJLAOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[NotNull]
	new Task<T> INGFLBMKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	[NotNull]
	new global::CBNPJNGNOBA<T> EIICMKALNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class HMGHGEILKOH<TTask, T> : global::LALBDIOHIHH<T>, CIFCDNJLAOP, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class EDHHOFGNCFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public global::HMGHGEILKOH<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public EDHHOFGNCFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static bool DJLLDBKLGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Task<T> DCIEJFOHMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	protected readonly CancellationTokenSource FEOAJIEFGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool PCDAJGPJMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SynchronizationContext KCCLHKPHHJB;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> INGFLBMKKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task GBJBCIICMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::CBNPJNGNOBA<T> EIICMKALNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private PCDEFPAPNCL HKBAMJMFHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x267C4A0", Offset = "0x267B2A0", VA = "0x18267C4A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool ALACEBEGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x62C620", Offset = "0x62B420", VA = "0x18062C620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D170", Offset = "0x3A8BF70", VA = "0x183A8D170")]
	static HMGHGEILKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3A8D2E0", Offset = "0x3A8C0E0", VA = "0x183A8D2E0")]
	protected HMGHGEILKOH(TTask DCIEJFOHMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CC30", Offset = "0x3A8BA30", VA = "0x183A8CC30", Slot = "1")]
	~HMGHGEILKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB60", Offset = "0x3A8B960", VA = "0x183A8CB60", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CE90", Offset = "0x3A8BC90", VA = "0x183A8CE90")]
	private void PKIKJPNJAMN(bool NIGMMBMMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T PHPILDNIMPC(TTask NMOHFAJFOGK);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GKDCKCNFCHD();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CCD0", Offset = "0x3A8BAD0", VA = "0x183A8CCD0")]
	[CompilerGenerated]
	private void NKIJBBDHPDN(object CDNIMMGEDLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MOHELNCGALG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public readonly Type BGAGOPCGMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public readonly string HLHLEFKNIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly bool BMCKFFHMCOG;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4B57200", Offset = "0x4B56000", VA = "0x184B57200")]
	public MOHELNCGALG(Type IDMGLEHFHPM, string GFAPCFHIPHM, bool ILPNFNGBKHF = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x522ED0", Offset = "0x521CD0", VA = "0x180522ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x546710", Offset = "0x545510", VA = "0x180546710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public T this[int KOHLIKKCMDH, int HOLINNIDFGI]
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2BB94F0", Offset = "0x2BB82F0", VA = "0x182BB94F0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2BB9590", Offset = "0x2BB8390", VA = "0x182BB9590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9460", Offset = "0x2BB8260", VA = "0x182BB9460")]
		public Array2D(uint AGFGCPCKPEN, uint LNBHIGPMBFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x2BB93E0", Offset = "0x2BB81E0", VA = "0x182BB93E0")]
		public void GJNEFCAFABC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4B53CE0", Offset = "0x4B52AE0", VA = "0x184B53CE0")]
		public Array2DVector3(uint AGFGCPCKPEN, uint LNBHIGPMBFM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal static class JIEICDELIKC
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int BAEBBJCLJNG = -1;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int FKCJMMPAFBM = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DefaultMember("Item")]
public class DGPOFCEOILL<THandle, TValue> : IDisposable where THandle : struct, PEGENHNABPB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<THandle> CHCBGPPMGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<TValue> JPDIOLMENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly Func<TValue> BHKDEIIOEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly Action<TValue> DMCHBDCDDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private int EAAPIKHKLPP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public TValue IKCMDFNPDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x388F660", Offset = "0x388E460", VA = "0x18388F660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8B30", Offset = "0x3CC7930", VA = "0x183CC8B30")]
	public DGPOFCEOILL(Action<TValue> DMCHBDCDDCG, [Optional] Func<TValue> BHKDEIIOEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3CC81F0", Offset = "0x3CC6FF0", VA = "0x183CC81F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8270", Offset = "0x3CC7070", VA = "0x183CC8270")]
	public THandle FBNMOHOMNBD()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3CC88F0", Offset = "0x3CC76F0", VA = "0x183CC88F0")]
	public THandle NGPIMMKGFMI(TValue PEPOHKCFAOG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8A40", Offset = "0x3CC7840", VA = "0x183CC8A40")]
	public bool OGCMIFMLPGF(THandle FGLMPLBOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7FC0", Offset = "0x3CC6DC0", VA = "0x183CC7FC0")]
	public bool BOFGGBLPILF(THandle FGLMPLBOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8850", Offset = "0x3CC7650", VA = "0x183CC8850")]
	public bool KHKICPAOJJO(THandle FGLMPLBOFPE, out TValue PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3CC85B0", Offset = "0x3CC73B0", VA = "0x183CC85B0")]
	public TValue HPAAPNLJBAF(THandle FGLMPLBOFPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC87A0", Offset = "0x3CC75A0", VA = "0x183CC87A0")]
	public bool KDHPPGFOAPN(THandle FGLMPLBOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7F90", Offset = "0x3CC6D90", VA = "0x183CC7F90")]
	private THandle AMMNEOFIKGO(int IMDCPBGFCMD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC81C0", Offset = "0x3CC6FC0", VA = "0x183CC81C0")]
	private TValue DGDPGKGOGNL(int IMDCPBGFCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8450", Offset = "0x3CC7250", VA = "0x183CC8450")]
	private void FKMECKEJIPF(int IMDCPBGFCMD, in THandle FGLMPLBOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8AF0", Offset = "0x3CC78F0", VA = "0x183CC8AF0")]
	private void PCNJDBECILG(int IMDCPBGFCMD, in TValue PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8680", Offset = "0x3CC7480", VA = "0x183CC8680")]
	private THandle INOFECDFAJL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8490", Offset = "0x3CC7290", VA = "0x183CC8490")]
	private void HMEFPIAKGDD(THandle FGLMPLBOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8790", Offset = "0x3CC7590", VA = "0x183CC8790")]
	private int JCIKBHPDJFK(int ANOPPJLGPDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8960", Offset = "0x3CC7760", VA = "0x183CC8960")]
	private bool NJJLFJPJKGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5739A0", Offset = "0x5727A0", VA = "0x1805739A0")]
	private void DCLEBDNBHDM(THandle FGLMPLBOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8600", Offset = "0x3CC7400", VA = "0x183CC8600")]
	private bool ICBGDHLPBHB(out THandle FGLMPLBOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8970", Offset = "0x3CC7770", VA = "0x183CC8970")]
	private bool OCFGIFJGDKE(out THandle FGLMPLBOFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8550", Offset = "0x3CC7350", VA = "0x183CC8550")]
	private void HMPBCCAAJLP(THandle FGLMPLBOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x3CC80A0", Offset = "0x3CC6EA0", VA = "0x183CC80A0")]
	private void DGDCPBGMHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public interface PEGENHNABPB
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	int LNKLOMNFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int CAOIDEMHPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface JIMEJMBIFAO<T> : PEGENHNABPB, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MCACKCGHMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x2C40E30", Offset = "0x2C3FC30", VA = "0x182C40E30")]
	public static bool JJCNNKAFOEH<T>(this T FGLMPLBOFPE) where T : struct, PEGENHNABPB
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class FFPHJJIJEKG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private enum CBALHBEFIOO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private int FJDPCLONNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ACEDIEDGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private CBALHBEFIOO IFNHFJGBFAN;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool HFMHLPNCPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x4B54E70", Offset = "0x4B53C70", VA = "0x184B54E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool GAJEBOBNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x4B54970", Offset = "0x4B53770", VA = "0x184B54970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4B556C0", Offset = "0x4B544C0", VA = "0x184B556C0")]
	public FFPHJJIJEKG(bool ACEDIEDGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4B54E80", Offset = "0x4B53C80", VA = "0x184B54E80")]
	public void JJACGGMCOJF(object AHLFMJPCIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4B553B0", Offset = "0x4B541B0", VA = "0x184B553B0")]
	public void LJPELAEJMAB(int PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4B553A0", Offset = "0x4B541A0", VA = "0x184B553A0")]
	public void KBACIJNBKAF(uint DKKLDDOIAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4B54950", Offset = "0x4B53750", VA = "0x184B54950")]
	public void BDILMLIEGDG(bool DPCEGCLJNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x4B555F0", Offset = "0x4B543F0", VA = "0x184B555F0")]
	public void NPJJMDNFCMI(long INGJBOICPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x4B549F0", Offset = "0x4B537F0", VA = "0x184B549F0")]
	public void GFMANPNHMPI(ulong PGHAMJFFGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x4B548E0", Offset = "0x4B536E0", VA = "0x184B548E0")]
	public void AFCACAJFPMH(string EKDDMDAOKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x4B55630", Offset = "0x4B54430", VA = "0x184B55630")]
	public void OOOJHNJFPAJ(Enum FLNLIILPCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B554D0", Offset = "0x4B542D0", VA = "0x184B554D0")]
	public void MPHCMAODECO(IList KBFCGHDEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3407AC0", Offset = "0x34068C0", VA = "0x183407AC0")]
	public void MAHCKEKGLOM<T, U>(Dictionary<T, U> GHLJEIJJOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B54A40", Offset = "0x4B53840", VA = "0x184B54A40")]
	private void HDLABDAGHBL(IDictionary GHLJEIJJOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B54E00", Offset = "0x4B53C00", VA = "0x184B54E00")]
	public int IAHFGBLPHAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B55460", Offset = "0x4B54260", VA = "0x184B55460")]
	public short MCCIDDCGBIB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B54A30", Offset = "0x4B53830", VA = "0x184B54A30")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x4B54980", Offset = "0x4B53780", VA = "0x184B54980")]
	private void CIKELGLMGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class AENNNJPEKCK<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal class BJBPCPAEFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TNode OOHLLAEGIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public TNode ABHIDEANEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public KIIGHHCAAJP APPKCAMLICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<KIIGHHCAAJP> KONFKNDCJPO;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		public BJBPCPAEFFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal struct KIIGHHCAAJP : IComparable<KIIGHHCAAJP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public int DGODDCKMMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public TClaimant GDACKPEKCGE;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x52ACF0", Offset = "0x529AF0", VA = "0x18052ACF0")]
		public KIIGHHCAAJP(int DGODDCKMMAE, TClaimant GDACKPEKCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2F6AEB0", Offset = "0x2F69CB0", VA = "0x182F6AEB0")]
		public bool LFABBBIKCEI(in KIIGHHCAAJP KBAPGFOKKBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2F6AF10", Offset = "0x2F69D10", VA = "0x182F6AF10")]
		public bool OLIPJLCCHEP(in KIIGHHCAAJP KBAPGFOKKBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2F6AEA0", Offset = "0x2F69CA0", VA = "0x182F6AEA0", Slot = "4")]
		public int CompareTo(KIIGHHCAAJP KBAPGFOKKBB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2F6AF20", Offset = "0x2F69D20", VA = "0x182F6AF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum COEFOABPMJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ALPGFGCHFPO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public global::AENNNJPEKCK<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x28B7B10", Offset = "0x28B6910", VA = "0x1828B7B10")]
		[DebuggerHidden]
		public ALPGFGCHFPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2F69920", Offset = "0x2F68720", VA = "0x182F69920", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2F69AE0", Offset = "0x2F688E0", VA = "0x182F69AE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2F69A00", Offset = "0x2F68800", VA = "0x182F69A00", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2608180", Offset = "0x2606F80", VA = "0x182608180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly global::CDIEOIIFDFO<BJBPCPAEFFE> KELIOHBBPLF;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly global::CDIEOIIFDFO<List<KIIGHHCAAJP>> NFLDALAOOFL;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int MDNMFDBKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	internal readonly Dictionary<TClaimant, TNode> MPPDMHCHOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	internal readonly Dictionary<TNode, BJBPCPAEFFE> IFFDAOPDOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private COEFOABPMJN BANMLNILNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool CCJNDKMKPHD;

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EFDBFPFFGOC(TNode OBJPKPCAKNL);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NBKNGOKCKFN(TNode OBJPKPCAKNL, TClaimant LNAFMMGNCCN, TClaimant LMFKALIJBEC);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F1E0", Offset = "0x2F5DFE0", VA = "0x182F5F1E0")]
	public AENNNJPEKCK(COEFOABPMJN BANMLNILNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DDA0", Offset = "0x2F5CBA0", VA = "0x182F5DDA0")]
	public void EAICLLNDIJO(TNode OBJPKPCAKNL, TNode MIOILDJFLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E890", Offset = "0x2F5D690", VA = "0x182F5E890")]
	public void PAKJDNEEKCF(TClaimant GDACKPEKCGE, TNode FPFGGONKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DB40", Offset = "0x2F5C940", VA = "0x182F5DB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E5B0", Offset = "0x2F5D3B0", VA = "0x182F5E5B0")]
	private void MJOLOHNLAAA(TClaimant GDACKPEKCGE, TNode FIJIFGEHIOA, TNode FPFGGONKMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DAD0", Offset = "0x2F5C8D0", VA = "0x182F5DAD0")]
	private int DOGNABCDOOF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E990", Offset = "0x2F5D790", VA = "0x182F5E990")]
	private void PIKMNINCMOK(TClaimant GDACKPEKCGE, TNode ALKLOELGFCN, TNode IPPDJHANIBM, int NLILIKNJCBB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D980", Offset = "0x2F5C780", VA = "0x182F5D980")]
	private void BCFNDICCBOF(KIIGHHCAAJP MMNCMBGBLHB, BJBPCPAEFFE BNBFIFKHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E270", Offset = "0x2F5D070", VA = "0x182F5E270")]
	private void KBHIHKCMBGA(TClaimant GDACKPEKCGE, TNode ALKLOELGFCN, TNode IPPDJHANIBM, int NLILIKNJCBB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E790", Offset = "0x2F5D590", VA = "0x182F5E790")]
	private void OFFGEHGIJPE(KIIGHHCAAJP MMNCMBGBLHB, TNode OBJPKPCAKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DFE0", Offset = "0x2F5CDE0", VA = "0x182F5DFE0")]
	private void HAMOBOCKMNN(KIIGHHCAAJP MMNCMBGBLHB, BJBPCPAEFFE BNBFIFKHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E650", Offset = "0x2F5D450", VA = "0x182F5E650")]
	private void MLHHKOGLCDJ(BJBPCPAEFFE BNBFIFKHION, bool HLNHKECKKCG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2F5EC40", Offset = "0x2F5DA40", VA = "0x182F5EC40")]
	private void POKMNGPMNKN(BJBPCPAEFFE BNBFIFKHION, TNode MIOILDJFLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E4E0", Offset = "0x2F5D2E0", VA = "0x182F5E4E0")]
	[IteratorStateMachine(typeof(global::AENNNJPEKCK<, >.ALPGFGCHFPO))]
	private IEnumerable<TNode> MFGGIBGBNJP(TNode ALKLOELGFCN, TNode IPPDJHANIBM, bool ACAEKLNOMOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DA10", Offset = "0x2F5C810", VA = "0x182F5DA10")]
	private BJBPCPAEFFE DOCKKDEPJIG(TNode OBJPKPCAKNL, TNode ABHIDEANEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E0E0", Offset = "0x2F5CEE0", VA = "0x182F5E0E0")]
	private BJBPCPAEFFE HPDOFJCLKJG(TNode OBJPKPCAKNL, TNode ABHIDEANEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DE20", Offset = "0x2F5CC20", VA = "0x182F5DE20")]
	private void EGCGHDLIIGO(BJBPCPAEFFE BNBFIFKHION)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public class KOGNPMHADMF<T> : IEnumerable<global::KOGNPMHADMF<T>.AAIGADBFNJN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct AAIGADBFNJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T PEPOHKCFAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int IMDCPBGFCMD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class MKPPMAAKGIM : IEnumerator<AAIGADBFNJN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private global::KOGNPMHADMF<T> CFJDCNGHLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private int IMDCPBGFCMD;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x2EE92A0", Offset = "0x2EE80A0", VA = "0x182EE92A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public AAIGADBFNJN JOCOBLKMMHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x2FC6F60", Offset = "0x2FC5D60", VA = "0x182FC6F60", Slot = "4")]
			get
			{
				return default(AAIGADBFNJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x596C30", Offset = "0x595A30", VA = "0x180596C30")]
		public MKPPMAAKGIM(global::KOGNPMHADMF<T> CFJDCNGHLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2FC6ED0", Offset = "0x2FC5CD0", VA = "0x182FC6ED0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x596C20", Offset = "0x595A20", VA = "0x180596C20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xBA09C0", Offset = "0xB9F7C0", VA = "0x180BA09C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	private struct APFAFPLONDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool LIFOMKACJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public T PEPOHKCFAOG;
	}

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private const int BNDFMLCOKCM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Dictionary<T, int> CCICPHHNGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private APFAFPLONDH[] KHMBPOGDLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int OOCMKCGOIPA;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2F6B6D0", Offset = "0x2F6A4D0", VA = "0x182F6B6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBE90", Offset = "0x2FBAC90", VA = "0x182FBBE90")]
	public static global::KOGNPMHADMF<T> LCGBOMLNPLN(AAIGADBFNJN[] INBNKMKLNCF, bool IIDCEBPEFLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC770", Offset = "0x2FBB570", VA = "0x182FBC770")]
	public KOGNPMHADMF(int IMNCEOIPJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBE00", Offset = "0x2FBAC00", VA = "0x182FBBE00")]
	public bool HCNAGKLNILC(T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBE30", Offset = "0x2FBAC30", VA = "0x182FBBE30")]
	public bool INGELKPOEFO(int IMDCPBGFCMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC540", Offset = "0x2FBB340", VA = "0x182FBC540")]
	public bool OKCEKAKCNAH(Func<T, bool> DJBODHOMOKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC6A0", Offset = "0x2FBB4A0", VA = "0x182FBC6A0")]
	public int PHAGHOLMEBE(T PEPOHKCFAOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBCA0", Offset = "0x2FBAAA0", VA = "0x182FBBCA0")]
	public T DGDPGKGOGNL(int IMDCPBGFCMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBD60", Offset = "0x2FBAB60", VA = "0x182FBBD60")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC270", Offset = "0x2FBB070", VA = "0x182FBC270")]
	public bool LLIEDMKLNJB(T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC290", Offset = "0x2FBB090", VA = "0x182FBC290")]
	public bool LLIEDMKLNJB(T PEPOHKCFAOG, int IMDCPBGFCMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC4C0", Offset = "0x2FBB2C0", VA = "0x182FBC4C0")]
	public bool OGCMIFMLPGF(T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBD10", Offset = "0x2FBAB10", VA = "0x182FBBD10")]
	public bool GAIMKPILCFO(int IMDCPBGFCMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC5F0", Offset = "0x2FBB3F0", VA = "0x182FBC5F0")]
	private void PFDMCPCLADJ(int IMDCPBGFCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBB30", Offset = "0x2FBA930", VA = "0x182FBBB30")]
	public AAIGADBFNJN[] CBCMPCCLAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x2FBBDB0", Offset = "0x2FBABB0", VA = "0x182FBBDB0")]
	private int HCLOBBBIJIJ(int CHMJDGBLLOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC6F0", Offset = "0x2FBB4F0", VA = "0x182FBC6F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC6F0", Offset = "0x2FBB4F0", VA = "0x182FBC6F0", Slot = "4")]
	private IEnumerator<AAIGADBFNJN> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class CDIEOIIFDFO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly Stack<T> NJPCAAIABLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<T> AAIKIFAFBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int FMLGACAANEH;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int AJMKNAPLAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA620", Offset = "0x2BB9420", VA = "0x182BBA620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int EOOIKDBHGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBE1D0", Offset = "0x2BBCFD0", VA = "0x182BBE1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E920", Offset = "0x2E1D720", VA = "0x182E1E920")]
	public static global::CDIEOIIFDFO<T> LPDMBNIFMBC(int IMNCEOIPJNE = 0, int FMLGACAANEH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E490", Offset = "0x2E1D290", VA = "0x182E1E490")]
	public static global::CDIEOIIFDFO<T> DMKIONCEEDF(int IMNCEOIPJNE = 0, int FMLGACAANEH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EDF0", Offset = "0x2E1DBF0", VA = "0x182E1EDF0")]
	public CDIEOIIFDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EC60", Offset = "0x2E1DA60", VA = "0x182E1EC60")]
	public CDIEOIIFDFO(int IMNCEOIPJNE, int FMLGACAANEH = int.MaxValue, bool HABCDNGJCIB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E670", Offset = "0x2E1D470", VA = "0x182E1E670")]
	public T HMIANEFBMKB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E3D0", Offset = "0x2E1D1D0", VA = "0x182E1E3D0")]
	public void CMEJFGDJIKJ(T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E860", Offset = "0x2E1D660", VA = "0x182E1E860")]
	private void LCBCLDGLPKH(T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E7A0", Offset = "0x2E1D5A0", VA = "0x182E1E7A0")]
	private void JDDKCLHBOMH(T PEPOHKCFAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E7C0", Offset = "0x2E1D5C0", VA = "0x182E1E7C0")]
	[Conditional("DEBUG_BUILD")]
	private void LBPJDPJKCON(T HCGEBCIDPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E9F0", Offset = "0x2E1D7F0", VA = "0x182E1E9F0")]
	[Conditional("DEBUG_BUILD")]
	private void MIBPCGGHNHB(T HCGEBCIDPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2E1E560", Offset = "0x2E1D360", VA = "0x182E1E560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2E1EAA0", Offset = "0x2E1D8A0", VA = "0x182E1EAA0")]
	private void MJIMFCEAHPB(IEnumerable<T> JPDIOLMENIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class BFKFLEKFNFF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private Dictionary<int, T> KINFAGOEHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private T PKPKAODIJHA;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public virtual T NALNONKHIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5221C0", Offset = "0x520FC0", VA = "0x1805221C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5224A0", Offset = "0x5212A0", VA = "0x1805224A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool HBIIOMPOFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C03F70", Offset = "0x3C02D70", VA = "0x183C03F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x3C03780", Offset = "0x3C02580", VA = "0x183C03780")]
	public bool BNLCMKMOKMD(T PEPOHKCFAOG, int DGODDCKMMAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3C038A0", Offset = "0x3C026A0", VA = "0x183C038A0")]
	public bool HAFJKALOKLK(int DGODDCKMMAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3C03B70", Offset = "0x3C02970", VA = "0x183C03B70")]
	public T MDLOFBOHPOL(int CEHIMDABOGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3C03840", Offset = "0x3C02640", VA = "0x183C03840")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3C03EE0", Offset = "0x3C02CE0", VA = "0x183C03EE0")]
	private bool MONKJIBIIHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3C03FB0", Offset = "0x3C02DB0", VA = "0x183C03FB0")]
	public bool PDIMMFIGHEA(int DGODDCKMMAE, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x345BF60", Offset = "0x345AD60", VA = "0x18345BF60")]
	public BFKFLEKFNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class KPNKDFOEJIM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	protected struct PAJIONIKBAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public T NMGHIPGAEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int KAOJKMBPCIL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	protected readonly List<PAJIONIKBAL> HIBKHIHBJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private T DJIDCAOOEKL;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x28CB1E0", Offset = "0x28C9FE0", VA = "0x1828CB1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCB70", Offset = "0x2FBB970", VA = "0x182FBCB70")]
	public bool OKCEKAKCNAH(T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC9B0", Offset = "0x2FBB7B0", VA = "0x182FBC9B0")]
	public void NGPIMMKGFMI(T PEPOHKCFAOG, int DGODDCKMMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCA50", Offset = "0x2FBB850", VA = "0x182FBCA50")]
	public bool OGCMIFMLPGF(T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC950", Offset = "0x2FBB750", VA = "0x182FBC950")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC8C0", Offset = "0x2FBB6C0", VA = "0x182FBC8C0")]
	public T EHNAGEAHHOI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2FBC850", Offset = "0x2FBB650", VA = "0x182FBC850")]
	public T EFMIOCCNKJN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCDC0", Offset = "0x2FBBBC0", VA = "0x182FBCDC0")]
	private void PKAECGHLOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCFD0", Offset = "0x2FBBDD0", VA = "0x182FBCFD0")]
	public KPNKDFOEJIM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[MHEMHMNNFNI(ILJAFDCKKEB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x4B57EB0", Offset = "0x4B56CB0", VA = "0x184B57EB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x4B58380", Offset = "0x4B57180", VA = "0x184B58380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x4B581A0", Offset = "0x4B56FA0", VA = "0x184B581A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x4B58520", Offset = "0x4B57320", VA = "0x184B58520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x4B57D70", Offset = "0x4B56B70", VA = "0x184B57D70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x4B58240", Offset = "0x4B57040", VA = "0x184B58240")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x4B58060", Offset = "0x4B56E60", VA = "0x184B58060")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4B57CD0", Offset = "0x4B56AD0", VA = "0x184B57CD0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public interface LJBKNBIOEPH
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public abstract class ResourcePrefabReference<T> : LJBKNBIOEPH where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCE90", Offset = "0x2BCBC90", VA = "0x182BCCE90", Slot = "4")]
		public virtual T FNEDHGPHICA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x25FD1B0", Offset = "0x25FBFB0", VA = "0x1825FD1B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class LKEPLGEGNJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Dictionary<byte, MILNICGFCHO> AMGGLMMLMNL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MILNICGFCHO FNBHBIHLMND
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5221D0", Offset = "0x520FD0", VA = "0x1805221D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x522490", Offset = "0x521290", VA = "0x180522490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector2 ACMDFIPCHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xD32DE0", Offset = "0xD31BE0", VA = "0x180D32DE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1541810", Offset = "0x1540610", VA = "0x181541810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Vector2 PNGGFDEPBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xBCFE10", Offset = "0xBCEC10", VA = "0x180BCFE10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xBCFE30", Offset = "0xBCEC30", VA = "0x180BCFE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector2 MJDOGGLABCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x105C250", Offset = "0x105B050", VA = "0x18105C250")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x105C270", Offset = "0x105B070", VA = "0x18105C270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int MOOBCIMBMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x54D7E0", Offset = "0x54C5E0", VA = "0x18054D7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5739A0", Offset = "0x5727A0", VA = "0x1805739A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B56530", Offset = "0x4B55330", VA = "0x184B56530")]
	public LKEPLGEGNJN(Bounds HOKMPDBOCGO, Vector2[] AEBGMKELHHC, int HKCAHJJKHBH, byte CHMJDGBLLOG, float NOJGHJNFNOL = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B564D0", Offset = "0x4B552D0", VA = "0x184B564D0")]
	public MILNICGFCHO PJLPPDKLDEB(byte IMDCPBGFCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B562B0", Offset = "0x4B550B0", VA = "0x184B562B0")]
	public void LFCMKEMDJJH(Vector3 ANCLOMCNDAP, float JCJEFFFHKDI, float GLHCBHMIIJL, ref List<byte> NOCOEHINGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x4B56290", Offset = "0x4B55090", VA = "0x184B56290")]
	public void GKPMGACGOBI(MILNICGFCHO.BKPECAPFCEL HPJCKBIFKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x4B563A0", Offset = "0x4B551A0", VA = "0x184B563A0")]
	private MILNICGFCHO OIOLGIGBLGK(byte IMDCPBGFCMD, MILNICGFCHO.IPOJKOMDJEC POEGJKFMMAB, MILNICGFCHO ABHIDEANEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4B55D70", Offset = "0x4B54B70", VA = "0x184B55D70")]
	private void CICGNHFOJLO(MILNICGFCHO ABHIDEANEGM, Vector2[] AEBGMKELHHC, int PJPDCGINDPH, int EBBLNALJBAN, int APDCCEDIJEB, int INALAAMCKJI, float NOJGHJNFNOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class MILNICGFCHO
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum IPOJKOMDJEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum BKPECAPFCEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte AOIJNBBEAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 JAPECFAMPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 JHKKINIGJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector3 CCMILHBGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3 LDKFMBFPMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public IPOJKOMDJEC PCMEPKMFOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public MILNICGFCHO IFHOJLIAHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public List<MILNICGFCHO> MIMNNEALPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool OKJGNPOAOIH;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4B57180", Offset = "0x4B55F80", VA = "0x184B57180")]
	public MILNICGFCHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4B571A0", Offset = "0x4B55FA0", VA = "0x184B571A0")]
	public MILNICGFCHO(byte NKFKNPEOIHO, IPOJKOMDJEC POEGJKFMMAB, MILNICGFCHO ABHIDEANEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x4B570A0", Offset = "0x4B55EA0", VA = "0x184B570A0")]
	public void LNHGKKHAHGG(MILNICGFCHO IGAFKFBKEOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80")]
	public void GKPMGACGOBI(int JFLINFLCPNA, BKPECAPFCEL HPJCKBIFKLI, int DLOLDFPCOHG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x4B56E10", Offset = "0x4B55C10", VA = "0x184B56E10")]
	public void LFCMKEMDJJH(List<byte> NOCOEHINGDM, Vector3 ANCLOMCNDAP, float JCJEFFFHKDI, float GLHCBHMIIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x4B56DB0", Offset = "0x4B55BB0", VA = "0x184B56DB0")]
	public bool KEIKAFOCEAF(Vector3 JBDAPFGHENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B57140", Offset = "0x4B55F40", VA = "0x184B57140")]
	public bool MGGIHBPIFIM(Vector3 JBDAPFGHENJ, float AFJHHKMBCAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class KJKMMOJIPHK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Dictionary<T, object> FMHABEANNOM;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2718170", Offset = "0x2716F70", VA = "0x182718170")]
	public bool OMKJNOGBMKB(T JJNBMCOHHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3A30", Offset = "0x2AC2830", VA = "0x182AC3A30")]
	public bool OMKJNOGBMKB(T JJNBMCOHHMG, object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3A70", Offset = "0x2AC2870", VA = "0x182AC3A70")]
	public bool OMKJNOGBMKB(T JJNBMCOHHMG, object JFEIMLLHKDD, out object DDKAOHLPOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AC39F0", Offset = "0x2AC27F0", VA = "0x182AC39F0")]
	public bool MGDLBOFEDDD(T JJNBMCOHHMG, object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3880", Offset = "0x2AC2680", VA = "0x182AC3880")]
	public bool CDGHPBLCDHA(T JJNBMCOHHMG, object JFEIMLLHKDD, out object DDKAOHLPOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3960", Offset = "0x2AC2760", VA = "0x182AC3960")]
	public bool MGDLBOFEDDD(T JJNBMCOHHMG, object JFEIMLLHKDD, out object DDKAOHLPOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3850", Offset = "0x2AC2650", VA = "0x182AC3850")]
	public void AIMBDMINCDP(T JJNBMCOHHMG, object JFEIMLLHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AC38C0", Offset = "0x2AC26C0", VA = "0x182AC38C0")]
	public void KJHMGFGCIJG(T JJNBMCOHHMG, object JFEIMLLHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3AD0", Offset = "0x2AC28D0", VA = "0x182AC3AD0")]
	public KJKMMOJIPHK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public struct OEAPMFJLCIC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly List<Component> KBFCGHDEKBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private readonly bool KMDHDEHMBDA;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x97AFE0", Offset = "0x979DE0", VA = "0x18097AFE0")]
			public OEAPMFJLCIC(List<Component> KBFCGHDEKBD, bool KMDHDEHMBDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE080", Offset = "0x2BBCE80", VA = "0x182BBE080")]
			public HGLECAILKAO<T> LPPJAAHLHFO()
			{
				return default(HGLECAILKAO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE0F0", Offset = "0x2BBCEF0", VA = "0x182BBE0F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2BBE0F0", Offset = "0x2BBCEF0", VA = "0x182BBE0F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public struct HGLECAILKAO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			private readonly List<Component> KBFCGHDEKBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			private readonly bool KMDHDEHMBDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			private int IMDCPBGFCMD;

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public T JOCOBLKMMHI
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCAC0", Offset = "0x2BBB8C0", VA = "0x182BBCAC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x2BBCA50", Offset = "0x2BBB850", VA = "0x182BBCA50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2BBCA90", Offset = "0x2BBB890", VA = "0x182BBCA90")]
			public HGLECAILKAO(List<Component> KBFCGHDEKBD, bool KMDHDEHMBDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x2BBC980", Offset = "0x2BBB780", VA = "0x182BBC980", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2BBC990", Offset = "0x2BBB790", VA = "0x182BBC990", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x2BBCA40", Offset = "0x2BBB840", VA = "0x182BBCA40", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x4B5A1E0", Offset = "0x4B58FE0", VA = "0x184B5A1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B5A1A0", Offset = "0x4B58FA0", VA = "0x184B5A1A0")]
		public ToolHierarchyCache(GameObject GCBLMGEMCOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4B59BD0", Offset = "0x4B589D0", VA = "0x184B59BD0")]
		private void LNBLCEPPLFK(GameObject GCBLMGEMCOM, bool ANDMDMBPIBE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4B59B40", Offset = "0x4B58940", VA = "0x184B59B40")]
		public static void LNBLCEPPLFK(GameObject GCBLMGEMCOM, ref ToolHierarchyCache BBEJNPHIANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x4B59980", Offset = "0x4B58780", VA = "0x184B59980")]
		public void EPKNDECJMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4B5A0F0", Offset = "0x4B58EF0", VA = "0x184B5A0F0")]
		public void PGKMPCCBADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x29BF3F0", Offset = "0x29BE1F0", VA = "0x1829BF3F0")]
		public void GNKALAJKDEK<T>(Action<T> DIKCECEKHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B5A030", Offset = "0x4B58E30", VA = "0x184B5A030")]
		public Component ODNBHOMOFCF(Type FEGCMBEFABH, bool KMDHDEHMBDA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x266EAE0", Offset = "0x266D8E0", VA = "0x18266EAE0")]
		public T ODNBHOMOFCF<T>(bool KMDHDEHMBDA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4B59FA0", Offset = "0x4B58DA0", VA = "0x184B59FA0")]
		public OEAPMFJLCIC<Component> MLKAHNMCCEM(Type FEGCMBEFABH, bool KMDHDEHMBDA = false)
		{
			return default(OEAPMFJLCIC<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x27F4E80", Offset = "0x27F3C80", VA = "0x1827F4E80")]
		public OEAPMFJLCIC<T> MLKAHNMCCEM<T>(bool KMDHDEHMBDA = false) where T : class
		{
			return default(OEAPMFJLCIC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4B59CF0", Offset = "0x4B58AF0", VA = "0x184B59CF0")]
		public List<Component> MLAHBABMKOE(Type FEGCMBEFABH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x4B59A50", Offset = "0x4B58850", VA = "0x184B59A50", Slot = "4")]
		public bool Equals(ToolHierarchyCache DCMLOLBECIB, ToolHierarchyCache FNPBMEBCJAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x4B59AD0", Offset = "0x4B588D0", VA = "0x184B59AD0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache AHLFMJPCIDI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class AJKGJKDLKPL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int IMNCEOIPJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private int NKOOBHMAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<T> ENLBELNOGJH;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA620", Offset = "0x2BB9420", VA = "0x182BBA620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public T CHNIPAPIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x3288D90", Offset = "0x3287B90", VA = "0x183288D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public T GPEHLMMMGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x3288F80", Offset = "0x3287D80", VA = "0x183288F80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public T PKPOIPCDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x3288E50", Offset = "0x3287C50", VA = "0x183288E50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3289270", Offset = "0x3288070", VA = "0x183289270")]
	public AJKGJKDLKPL(int IMNCEOIPJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x32890A0", Offset = "0x3287EA0", VA = "0x1832890A0")]
	public void NGPIMMKGFMI(T DAPCLAFFJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3288E10", Offset = "0x3287C10", VA = "0x183288E10")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x32891D0", Offset = "0x3287FD0", VA = "0x1832891D0")]
	public void PJALGNKDPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3289170", Offset = "0x3287F70", VA = "0x183289170")]
	public void NJKHCBDKIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x32891C0", Offset = "0x3287FC0", VA = "0x1832891C0")]
	public void OAPLLOJKMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class EMJAHFAEANP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private bool EABOHJCFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Action DIKCECEKHKC;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public static EMJAHFAEANP CACDHKNAFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4B546E0", Offset = "0x4B534E0", VA = "0x184B546E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool OMCHJFIANBF
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x54D7B0", Offset = "0x54C5B0", VA = "0x18054D7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xA66010", Offset = "0xA64E10", VA = "0x180A66010")]
	public EMJAHFAEANP(Action DIKCECEKHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4B546C0", Offset = "0x4B534C0", VA = "0x184B546C0")]
	public void ALCOILIHPJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4B546C0", Offset = "0x4B534C0", VA = "0x184B546C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class EKFMJKMNCDF
{
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80")]
	public static void AAEPOGHHMCG(PEKLNOOPPED ONMJHDFCEGB, string PKBPPIBCKOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class IKLOFBNCKGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	private struct JEADMLIBBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int KAOJKMBPCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public T NMGHIPGAEHB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Dictionary<object, JEADMLIBBAH> KINFAGOEHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private T PKPKAODIJHA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public virtual T NALNONKHIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xD32DE0", Offset = "0xD31BE0", VA = "0x180D32DE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1541810", Offset = "0x1540610", VA = "0x181541810", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool HBIIOMPOFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x345B880", Offset = "0x345A680", VA = "0x18345B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public object FJNCCNGKIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x524DF0", Offset = "0x523BF0", VA = "0x180524DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x54CD70", Offset = "0x54BB70", VA = "0x18054CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3456A30", Offset = "0x3455830", VA = "0x183456A30")]
	public bool BNLCMKMOKMD(T PEPOHKCFAOG, object JFEIMLLHKDD, int DGODDCKMMAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3456B80", Offset = "0x3455980", VA = "0x183456B80")]
	public bool HAFJKALOKLK(object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x345BCD0", Offset = "0x345AAD0", VA = "0x18345BCD0")]
	public bool PDIMMFIGHEA(object JFEIMLLHKDD, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1E30", Offset = "0x2AB0C30", VA = "0x182AB1E30")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x345A720", Offset = "0x3459520", VA = "0x18345A720")]
	private bool MONKJIBIIHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x345BF60", Offset = "0x345AD60", VA = "0x18345BF60")]
	public IKLOFBNCKGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class HHLBPOMGMGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private Dictionary<object, float> KINFAGOEHKO;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public float KJJEEDNIJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AE0", Offset = "0x8D38E0", VA = "0x1808D4AE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B20", Offset = "0x8D3920", VA = "0x1808D4B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4B55910", Offset = "0x4B54710", VA = "0x184B55910")]
	public void BNLCMKMOKMD(float PEPOHKCFAOG, object JFEIMLLHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4B55980", Offset = "0x4B54780", VA = "0x184B55980")]
	public void HAFJKALOKLK(object JFEIMLLHKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x4B559F0", Offset = "0x4B547F0", VA = "0x184B559F0")]
	private void MKINLNMOPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4B55B10", Offset = "0x4B54910", VA = "0x184B55B10")]
	public HHLBPOMGMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public sealed class PEKLNOOPPED
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public sealed class JMJFEKENHPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly string GCNPNALLLGC;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		private JMJFEKENHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x593550", Offset = "0x592350", VA = "0x180593550")]
		public JMJFEKENHPP(string GCNPNALLLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4B55D20", Offset = "0x4B54B20", VA = "0x184B55D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class IOJEBLLKGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public IOJEBLLKGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4B55C70", Offset = "0x4B54A70", VA = "0x184B55C70")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly HashSet<object> PLIHOGLEPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private int IAEJGCIGKHL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool PGNJGNIKGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x4B57390", Offset = "0x4B56190", VA = "0x184B57390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int PJJBNMLIMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x595210", Offset = "0x594010", VA = "0x180595210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4B573A0", Offset = "0x4B561A0", VA = "0x184B573A0")]
	public bool NGPIMMKGFMI(object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4B57420", Offset = "0x4B56220", VA = "0x184B57420")]
	public bool OGCMIFMLPGF(object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4B574A0", Offset = "0x4B562A0", VA = "0x184B574A0")]
	public bool OKCEKAKCNAH(object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4B57330", Offset = "0x4B56130", VA = "0x184B57330")]
	public void GGKGLPENCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4B57500", Offset = "0x4B56300", VA = "0x184B57500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4B57670", Offset = "0x4B56470", VA = "0x184B57670")]
	public PEKLNOOPPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class KDEEFPLHJGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct FJCLBKAHFNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float BOOPJOMNHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public T NMGHIPGAEHB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Dictionary<object, FJCLBKAHFNA> KINFAGOEHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private T JMGPJDAEIMB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public virtual T NDGMKBCGGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x22B1780", Offset = "0x22B0580", VA = "0x1822B1780", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3A00", Offset = "0x2AB2800", VA = "0x182AB3A00", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public object LKEPDPNKNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x54AA30", Offset = "0x549830", VA = "0x18054AA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5CDBE0", Offset = "0x5CC9E0", VA = "0x1805CDBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool HBIIOMPOFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3720", Offset = "0x2AB2520", VA = "0x182AB3720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1D30", Offset = "0x2AB0B30", VA = "0x182AB1D30")]
	public bool BNLCMKMOKMD(T PEPOHKCFAOG, object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1E60", Offset = "0x2AB0C60", VA = "0x182AB1E60")]
	public bool HAFJKALOKLK(object JFEIMLLHKDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1E30", Offset = "0x2AB0C30", VA = "0x182AB1E30")]
	public void GJNEFCAFABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3830", Offset = "0x2AB2630", VA = "0x182AB3830")]
	public bool PDIMMFIGHEA(object JFEIMLLHKDD, out T PEPOHKCFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1EC0", Offset = "0x2AB0CC0", VA = "0x182AB1EC0")]
	private bool MONKJIBIIHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3A20", Offset = "0x2AB2820", VA = "0x182AB3A20")]
	public KDEEFPLHJGA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4B576E0", Offset = "0x4B564E0", VA = "0x184B576E0")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x4B577E0", Offset = "0x4B565E0", VA = "0x184B577E0")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
}
namespace Cpp2IlInjected
{
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
}
