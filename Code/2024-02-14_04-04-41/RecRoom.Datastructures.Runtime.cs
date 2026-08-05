using System;
using System.Buffers;
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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MADJIGLMNEO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AD100", Offset = "0x7AC500", VA = "0x1807AD100")]
	public MADJIGLMNEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, CIFCMCOICPJ, AGAHOOCGNLG, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LCDAKKLMACI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x857600", Offset = "0x856A00", VA = "0x180857600")]
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
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[HMICOAINBIM]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HideInInspector]
	[SerializeField]
	[HMICOAINBIM]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F23890", Offset = "0x5F22C90", VA = "0x185F23890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F23850", Offset = "0x5F22C50", VA = "0x185F23850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F238D0", Offset = "0x5F22CD0", VA = "0x185F238D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F23A80", Offset = "0x5F22E80", VA = "0x185F23A80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F239F0", Offset = "0x5F22DF0", VA = "0x185F239F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BB7D0", Offset = "0x8BABD0", VA = "0x1808BB7D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x938010", Offset = "0x937410", VA = "0x180938010")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F23810", Offset = "0x5F22C10", VA = "0x185F23810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F23960", Offset = "0x5F22D60", VA = "0x185F23960")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F23280", Offset = "0x5F22680", VA = "0x185F23280")]
	public void CopyBounds(SavedExtents AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F23760", Offset = "0x5F22B60", VA = "0x185F23760")]
	public void SetLocalSpaceBounds(Bounds NFOGKDCKMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x985550", Offset = "0x984950", VA = "0x180985550")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F23750", Offset = "0x5F22B50", VA = "0x185F23750")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F23370", Offset = "0x5F22770", VA = "0x185F23370")]
	private void MNBCAFBGGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F23530", Offset = "0x5F22930", VA = "0x185F23530")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F22C10", Offset = "0x5F22010", VA = "0x185F22C10")]
	public static void CalculateLocalBoundsFor(GameObject IPBNGJILMJD, [Out] Bounds NFOGKDCKMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F232B0", Offset = "0x5F226B0", VA = "0x185F232B0")]
	private static void DBMCMIHIAMM(Bounds LFCFPOEDJCH, Color AICLPFMLBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F23780", Offset = "0x5F22B80", VA = "0x185F23780")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x79C180", Offset = "0x79B580", VA = "0x18079C180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCF0", Offset = "0x7AB0F0", VA = "0x1807ABCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDB3A10", Offset = "0xDB2E10", VA = "0x180DB3A10")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41A5F10", Offset = "0x41A5310", VA = "0x1841A5F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	public virtual void BCGNIFIPCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[MADJIGLMNEO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41A5AF0", Offset = "0x41A4EF0", VA = "0x1841A5AF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41A4790", Offset = "0x41A3B90", VA = "0x1841A4790", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41A5E40", Offset = "0x41A5240", VA = "0x1841A5E40")]
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
	private sealed class HPDFJLLKHOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public HPDFJLLKHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3704190", Offset = "0x3703590", VA = "0x183704190")]
		internal int MFMDGAOHBJC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[MADJIGLMNEO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x323E560", Offset = "0x323D960", VA = "0x18323E560", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x323E5B0", Offset = "0x323D9B0", VA = "0x18323E5B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x323E460", Offset = "0x323D860", VA = "0x18323E460", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey KCGLPAPOILB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x323E500", Offset = "0x323D900", VA = "0x18323E500", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x323E340", Offset = "0x323D740", VA = "0x18323E340", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x323E060", Offset = "0x323D460", VA = "0x18323E060", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x323D500", Offset = "0x323C900", VA = "0x18323D500", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x323D470", Offset = "0x323C870", VA = "0x18323D470", Slot = "14")]
	protected virtual string HNJGPKJPNBO(TKeyVal CGEDIGMJHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x323D380", Offset = "0x323C780", VA = "0x18323D380", Slot = "4")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x323E200", Offset = "0x323D600", VA = "0x18323E200", Slot = "5")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x323D3D0", Offset = "0x323C7D0", VA = "0x18323D3D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x323D3D0", Offset = "0x323C7D0", VA = "0x18323D3D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x323E250", Offset = "0x323D650", VA = "0x18323E250")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NACAHDFFKHI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class PFJKMICPBNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float PMANHGKMGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public T NAJOFLHMBPO;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public PFJKMICPBNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KNIOJFEAMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public KNIOJFEAMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A9BB90", Offset = "0x3A9AF90", VA = "0x183A9BB90")]
		internal bool BAIGDEDNLPA(PFJKMICPBNK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float DADCBDBNMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PEFMHEMBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<PFJKMICPBNK> JMEICCLAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MKJAGKBNDJE<PFJKMICPBNK> KEBDGPKPKFA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int MFKPJBGGPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE0F0", Offset = "0x3DDD4F0", VA = "0x183DDE0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDE1D0", Offset = "0x3DDD5D0", VA = "0x183DDE1D0")]
	public NACAHDFFKHI(float ENKHLKOMGOM, float IKJADMKEAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3DDD730", Offset = "0x3DDCB30", VA = "0x183DDD730")]
	public bool ALFMJHMFICK(float BEBEFOHACKO, T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDBF0", Offset = "0x3DDCFF0", VA = "0x183DDDBF0")]
	public IEnumerable<T> DGJHKJLNOEA(float BEBEFOHACKO, [Optional] float? IDFDMDFDHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDF20", Offset = "0x3DDD320", VA = "0x183DDDF20")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDF90", Offset = "0x3DDD390", VA = "0x183DDDF90")]
	private void NKMMAHDJFGG(float BEBEFOHACKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class AGMDFDBHBPA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NCLENNAHFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public T NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float GGACJIFFJPI;
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static float JDABFCKKEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private List<T> IDOLBHMDFAO;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private const int ALBJLLJFDGJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NCLENNAHFBF[] NIKMHLBDDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int JAMBJBPCFEL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float OOKJPJLNNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB4CE90", Offset = "0xB4C290", VA = "0x180B4CE90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB4CE80", Offset = "0xB4C280", VA = "0x180B4CE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x36388C0", Offset = "0x3637CC0", VA = "0x1836388C0")]
	public AGMDFDBHBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x36388E0", Offset = "0x3637CE0", VA = "0x1836388E0")]
	public AGMDFDBHBPA(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x36379E0", Offset = "0x3636DE0", VA = "0x1836379E0")]
	public void FLOHBAGDPJC(float BEBEFOHACKO, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x36383C0", Offset = "0x36377C0", VA = "0x1836383C0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3638170", Offset = "0x3637570", VA = "0x183638170")]
	public bool HCJKFLBJPOE(float HJNMDPFOKNI, float DJIIGFIILID, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3637B60", Offset = "0x3636F60", VA = "0x183637B60")]
	public bool HAABPBKPJCH(float HJNMDPFOKNI, float DJIIGFIILID, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x36385A0", Offset = "0x36379A0", VA = "0x1836385A0")]
	public void NKJCHKCCFBP(float HJNMDPFOKNI, float DJIIGFIILID, List<T> BGIIPDEPEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3638830", Offset = "0x3637C30", VA = "0x183638830")]
	private int PNPKICPLPIJ(int OFPODMCIPGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3638370", Offset = "0x3637770", VA = "0x183638370")]
	private void IOHMEBFNJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EINDGDLMGEC();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NPFONBILKKF(T FDFHGIHHGHO, float FENMDPNPDJP);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T LAACBOABDGL(T CGDDINAJAOB, T GIFBDNCPDKC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BBIBAANHCBB(T CGDDINAJAOB, T GIFBDNCPDKC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AFPDIHLBPCG : AGMDFDBHBPA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AD990", Offset = "0x7ACD90", VA = "0x1807AD990", Slot = "4")]
	protected override Vector3 EINDGDLMGEC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F450", Offset = "0x5F1E850", VA = "0x185F1F450", Slot = "5")]
	protected override Vector3 NPFONBILKKF(Vector3 FDFHGIHHGHO, float FENMDPNPDJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F400", Offset = "0x5F1E800", VA = "0x185F1F400", Slot = "6")]
	protected override Vector3 LAACBOABDGL(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F380", Offset = "0x5F1E780", VA = "0x185F1F380", Slot = "7")]
	protected override Vector3 BBIBAANHCBB(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F490", Offset = "0x5F1E890", VA = "0x185F1F490")]
	public AFPDIHLBPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PECNOJHPOHL
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x279ED30", Offset = "0x279E130", VA = "0x18279ED30")]
	public static IFEOPNGOGPP<T1, T2> NDFPICIGPEG<T1, T2>(T1 JMEIENDPDHG, T2 BJEDKGGKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x279EDB0", Offset = "0x279E1B0", VA = "0x18279EDB0")]
	public static IBCBDEIEBAK<T1, T2, T3> NDFPICIGPEG<T1, T2, T3>(T1 JMEIENDPDHG, T2 BJEDKGGKJJA, T3 BLEDDBCNNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DC84C0", Offset = "0x3DC78C0", VA = "0x183DC84C0")]
	internal static int JLHFONMPBGN(int MFMHFGFDJCC, int APMPIAEEHBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5368650", Offset = "0x5367A50", VA = "0x185368650")]
	internal static int JLHFONMPBGN(int MFMHFGFDJCC, int APMPIAEEHBF, int LKIEGJLLHBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IFEOPNGOGPP<T1, T2> : IComparable<IFEOPNGOGPP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T1 LLGJHLGMEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T2 KCFLNGBJPII;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x379B450", Offset = "0x379A850", VA = "0x18379B450")]
	public IFEOPNGOGPP(T1 JMEIENDPDHG, T2 BJEDKGGKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3799BD0", Offset = "0x3798FD0", VA = "0x183799BD0", Slot = "4")]
	public int CompareTo(IFEOPNGOGPP<T1, T2> AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x379A560", Offset = "0x3799960", VA = "0x18379A560", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x379A900", Offset = "0x3799D00", VA = "0x18379A900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x379AB90", Offset = "0x3799F90", VA = "0x18379AB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IBCBDEIEBAK<T1, T2, T3> : IComparable<IBCBDEIEBAK<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 LLGJHLGMEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 KCFLNGBJPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T3 NODDMGNLHGK;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x378C3C0", Offset = "0x378B7C0", VA = "0x18378C3C0")]
	public IBCBDEIEBAK(T1 JMEIENDPDHG, T2 BJEDKGGKJJA, T3 BLEDDBCNNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x378BA80", Offset = "0x378AE80", VA = "0x18378BA80", Slot = "4")]
	public int CompareTo(IBCBDEIEBAK<T1, T2, T3> AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x378BE10", Offset = "0x378B210", VA = "0x18378BE10", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x378BFC0", Offset = "0x378B3C0", VA = "0x18378BFC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x378C0F0", Offset = "0x378B4F0", VA = "0x18378C0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T NAJOFLHMBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x20672F0", Offset = "0x20666F0", VA = "0x1820672F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2067240", Offset = "0x2066640", VA = "0x182067240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float OJHADNPDKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB14D20", Offset = "0xB14120", VA = "0x180B14D20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x438EFE0", Offset = "0x438E3E0", VA = "0x18438EFE0")]
	public T JIHJLCAGNPO(float FENMDPNPDJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x438EB50", Offset = "0x438DF50", VA = "0x18438EB50")]
	public T EIKAHCABGHI(float FENMDPNPDJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BJBGGFFNDCI(T CGDDINAJAOB, T GIFBDNCPDKC, float FENMDPNPDJP);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F205A0", Offset = "0x5F1F9A0", VA = "0x185F205A0", Slot = "4")]
	protected override float BJBGGFFNDCI(float CGDDINAJAOB, float GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F205E0", Offset = "0x5F1F9E0", VA = "0x185F205E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC78C90", Offset = "0xC78090", VA = "0x180C78C90", Slot = "4")]
	protected override Vector3 BJBGGFFNDCI(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F24760", Offset = "0x5F23B60", VA = "0x185F24760")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F900", Offset = "0x5F1ED00", VA = "0x185F1F900", Slot = "4")]
	protected override Color BJBGGFFNDCI(Color CGDDINAJAOB, Color GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F9C0", Offset = "0x5F1EDC0", VA = "0x185F1F9C0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ADBIDCIIGBO : GKMJFENNOOD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F330", Offset = "0x5F1E730", VA = "0x185F1F330")]
	public ADBIDCIIGBO(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F2C0", Offset = "0x5F1E6C0", VA = "0x185F1F2C0", Slot = "6")]
	protected override uint PPOEEMPMPBC(uint LCDAKKLMACI, string FDFHGIHHGHO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GHBEBAMBFBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly IDisposable MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public GHBEBAMBFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DOMPGNALJAI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MFDJNFANAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int MJPAEIMIJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int GCPAPMEDLCL;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AB80", Offset = "0x3A69F80", VA = "0x183A6AB80")]
	private DOMPGNALJAI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AKDPLNKMLHF, int DPFIGJNMEMA, int GHGHPMALHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9A70", Offset = "0x4EB8E70", VA = "0x184EB9A70")]
	public static DOMPGNALJAI<T> JKJFENIAMEL()
	{
		return default(DOMPGNALJAI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9B70", Offset = "0x4EB8F70", VA = "0x184EB9B70")]
	public (int, int, Task<T>) LELJJADJDGD(int OHLLMKBPNCN, [Optional] CancellationToken HNLFPBLPOKJ, double EDBFKNKJGAL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9880", Offset = "0x4EB8C80", VA = "0x184EB9880")]
	public void DHHFAFENKEN(int OHLLMKBPNCN, int GHGHPMALHMN, [In] T MNKBHKEBOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KGHAIEGNIDK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F21720", Offset = "0x5F20B20", VA = "0x185F21720")]
	public static DOMPGNALJAI<PJHBHBBODGG> JKJFENIAMEL()
	{
		return default(DOMPGNALJAI<PJHBHBBODGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5F216A0", Offset = "0x5F20AA0", VA = "0x185F216A0")]
	public static void DHHFAFENKEN([In] this DOMPGNALJAI<PJHBHBBODGG> NHHBAHIFHJK, int OHLLMKBPNCN, int GHGHPMALHMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class LJJFEELPDOG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Dictionary<TKey, TVal> DHGBBNPELCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly Dictionary<TVal, TKey> DMMHIIEOHLD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3014C10", Offset = "0x3014010", VA = "0x183014C10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> PHNAAMFGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x36A2000", Offset = "0x36A1400", VA = "0x1836A2000", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B61C30", Offset = "0x3B61030", VA = "0x183B61C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B61BD0", Offset = "0x3B60FD0", VA = "0x183B61BD0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3B61C70", Offset = "0x3B61070", VA = "0x183B61C70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B614F0", Offset = "0x3B608F0", VA = "0x183B614F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B61330", Offset = "0x3B60730", VA = "0x183B61330", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A00", Offset = "0x3B60E00", VA = "0x183B61A00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B61110", Offset = "0x3B60510", VA = "0x183B61110", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B61140", Offset = "0x3B60540", VA = "0x183B61140", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A7AF50", Offset = "0x3A7A350", VA = "0x183A7AF50", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B613F0", Offset = "0x3B607F0", VA = "0x183B613F0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B618D0", Offset = "0x3B60CD0", VA = "0x183B618D0", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B61900", Offset = "0x3B60D00", VA = "0x183B61900", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A50", Offset = "0x3B60E50", VA = "0x183B61A50", Slot = "11")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B61540", Offset = "0x3B60940", VA = "0x183B61540", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3B61420", Offset = "0x3B60820", VA = "0x183B61420", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B61830", Offset = "0x3B60C30", VA = "0x183B61830")]
	public bool MFCFPLHBNLD(TVal KCGLPAPOILB, [Out] TKey FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B61200", Offset = "0x3B60600", VA = "0x183B61200")]
	private void CIDCOGCFLKI(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B61670", Offset = "0x3B60A70", VA = "0x183B61670")]
	private void HHIEDMMEMHO(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B60FD0", Offset = "0x3B603D0", VA = "0x183B60FD0")]
	private bool AADKCBDLBJK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B61A90", Offset = "0x3B60E90", VA = "0x183B61A90")]
	public LJJFEELPDOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DefaultMember("Item")]
public class KPOBAOAEHPH<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private KPOBAOAEHPH<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3288E30", Offset = "0x3288230", VA = "0x183288E30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3293240", Offset = "0x3292640", VA = "0x183293240", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3294EF0", Offset = "0x32942F0", VA = "0x183294EF0")]
		public Enumerator(KPOBAOAEHPH<T> BGIIPDEPEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3291820", Offset = "0x3290C20", VA = "0x183291820", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3292460", Offset = "0x3291860", VA = "0x183292460", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x32906B0", Offset = "0x328FAB0", VA = "0x1832906B0")]
		private void EKILFKLOCGA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T[] BAFLFHMOJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int DAGOHCNFGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int CIGCECNJNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int OMDPMMKPCNP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3730", Offset = "0x3AA2B30", VA = "0x183AA3730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3AA32C0", Offset = "0x3AA26C0", VA = "0x183AA32C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA34E0", Offset = "0x3AA28E0", VA = "0x183AA34E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4220", Offset = "0x3AA3620", VA = "0x183AA4220")]
	public KPOBAOAEHPH(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2A10", Offset = "0x3AA1E10", VA = "0x183AA2A10")]
	public void FLOHBAGDPJC(T FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3860", Offset = "0x3AA2C60", VA = "0x183AA3860")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2890", Offset = "0x3AA1C90", VA = "0x183AA2890")]
	public void DKNDEEGFLEB(int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3B60", Offset = "0x3AA2F60", VA = "0x183AA3B60")]
	public void NLBPJJJIFLM(T[] NIKMHLBDDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3820", Offset = "0x3AA2C20", VA = "0x183AA3820")]
	public Enumerator MFONJKCHJIL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3FE0", Offset = "0x3AA33E0", VA = "0x183AA3FE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3FE0", Offset = "0x3AA33E0", VA = "0x183AA3FE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA30A0", Offset = "0x3AA24A0", VA = "0x183AA30A0")]
	private int GCODLMKIMNP(int OJANCMLFDOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3FB0", Offset = "0x3AA33B0", VA = "0x183AA3FB0")]
	private int PDBJCKDLPDC(int OJANCMLFDOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NIKMCCMKPLE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Func<Internal, External> CIKHLCDDLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IReadOnlyList<Internal> EPNEAFACLDA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFAF0", Offset = "0x3DFEEF0", VA = "0x183DFFAF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFAA0", Offset = "0x3DFEEA0", VA = "0x183DFFAA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7ABBD0", Offset = "0x7AAFD0", VA = "0x1807ABBD0")]
	public NIKMCCMKPLE(Func<Internal, External> CIKHLCDDLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFA50", Offset = "0x3DFEE50", VA = "0x183DFFA50")]
	public NIKMCCMKPLE(IReadOnlyList<Internal> EPNEAFACLDA, Func<Internal, External> CIKHLCDDLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFF9D0", Offset = "0x3DFEDD0", VA = "0x183DFF9D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34A6660", Offset = "0x34A5A60", VA = "0x1834A6660", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KGMFKEHFLIE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate Task<TResult> LAOFILPBCAJ(TRequest NCCHHGAPAOP, CancellationToken HNLFPBLPOKJ);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum GFPODGALEOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AENBDFPKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float HFPIJIODHOF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan GEMDMPKFCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int JAPPIIEFACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GFPODGALEOF DJFELJKFHEK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly AENBDFPKNKP KBJBMEBJHNF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float PHLEFBBAFCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3632240", Offset = "0x3631640", VA = "0x183632240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan FKJIJMGJPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3632390", Offset = "0x3631790", VA = "0x183632390")]
		public AENBDFPKNKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private readonly struct POPKHAHMFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest NCCHHGAPAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken HNLFPBLPOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> EEDJEJGKNFJ;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FDEBA0", Offset = "0x3FDDFA0", VA = "0x183FDEBA0")]
		public POPKHAHMFLO(TRequest NCCHHGAPAOP, TaskCompletionSource<TResult> EEDJEJGKNFJ, CancellationToken HNLFPBLPOKJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CDFEFHLPJKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KGMFKEHFLIE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4870E30", Offset = "0x4870230", VA = "0x184870E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4871270", Offset = "0x4870670", VA = "0x184871270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ELKHDCDHNOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KGMFKEHFLIE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private POPKHAHMFLO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x32043A0", Offset = "0x32037A0", VA = "0x1832043A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3205570", Offset = "0x3204970", VA = "0x183205570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource FLKFBJAEBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<POPKHAHMFLO> ECCADEHFEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly AENBDFPKNKP IJADLGOMIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LAOFILPBCAJ GIELMLPDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task MAGDJMDGKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FJIGKAJBAOA;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C540", Offset = "0x3A6B940", VA = "0x183A6C540")]
	public KGMFKEHFLIE(LAOFILPBCAJ GIELMLPDDLH, [Optional] AENBDFPKNKP IJADLGOMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A6BC10", Offset = "0x3A6B010", VA = "0x183A6BC10")]
	public Task<TResult> GCBDEKMOOID(TRequest NCCHHGAPAOP, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B4B0", Offset = "0x3A6A8B0", VA = "0x183A6B4B0")]
	private void BNJANPFPDAC(POPKHAHMFLO BDDMCLBDMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C0D0", Offset = "0x3A6B4D0", VA = "0x183A6C0D0")]
	[AsyncStateMachine(typeof(KGMFKEHFLIE<, >.CDFEFHLPJKK))]
	private Task MHLLPJKGJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B220", Offset = "0x3A6A620", VA = "0x183A6B220")]
	private POPKHAHMFLO BBCBHJIEHOK()
	{
		return default(POPKHAHMFLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B6E0", Offset = "0x3A6AAE0", VA = "0x183A6B6E0")]
	[AsyncStateMachine(typeof(KGMFKEHFLIE<, >.ELKHDCDHNOH))]
	private Task GAEJNOAMKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C270", Offset = "0x3A6B670", VA = "0x183A6C270")]
	private void POANDLPJOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B6A0", Offset = "0x3A6AAA0", VA = "0x183A6B6A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class HOAHDOOJJNM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> EPNEAFACLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> IBKEJNEFBNA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3014C10", Offset = "0x3014010", VA = "0x183014C10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x36A1860", Offset = "0x36A0C60", VA = "0x1836A1860", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3702820", Offset = "0x3701C20", VA = "0x183702820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x35F11D0", Offset = "0x35F05D0", VA = "0x1835F11D0", Slot = "11")]
	public void Add(T ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3701FD0", Offset = "0x37013D0", VA = "0x183701FD0")]
	public bool AMOFEKFEHHG(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37025F0", Offset = "0x37019F0", VA = "0x1837025F0", Slot = "15")]
	public bool Remove(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3702160", Offset = "0x3701560", VA = "0x183702160", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x35CEC10", Offset = "0x35CE010", VA = "0x1835CEC10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3702090", Offset = "0x3701490", VA = "0x183702090", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37020F0", Offset = "0x37014F0", VA = "0x1837020F0", Slot = "13")]
	public bool Contains(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3702130", Offset = "0x3701530", VA = "0x183702130", Slot = "14")]
	public void CopyTo(T[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37021F0", Offset = "0x37015F0", VA = "0x1837021F0", Slot = "6")]
	public int IndexOf(T ELCFHMHMPMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3702320", Offset = "0x3701720", VA = "0x183702320", Slot = "7")]
	public void Insert(int OJANCMLFDOJ, T ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3702400", Offset = "0x3701800", VA = "0x183702400", Slot = "8")]
	public void RemoveAt(int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3702730", Offset = "0x3701B30", VA = "0x183702730")]
	public HOAHDOOJJNM()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1ECDD70", Offset = "0x1ECD170", VA = "0x181ECDD70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x194B620", Offset = "0x194AA20", VA = "0x18194B620")]
		public SerializedGuid([In] Guid INAIFGAIEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F23CF0", Offset = "0x5F230F0", VA = "0x185F23CF0")]
		public static SerializedGuid OBPDDHFCBGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F23C80", Offset = "0x5F23080", VA = "0x185F23C80")]
		public static SerializedGuid JBJPAMMHNHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F23C20", Offset = "0x5F23020", VA = "0x185F23C20")]
		public bool INMLDJBGPFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F23DF0", Offset = "0x5F231F0", VA = "0x185F23DF0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F23D70", Offset = "0x5F23170", VA = "0x185F23D70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F23B40", Offset = "0x5F22F40", VA = "0x185F23B40", Slot = "7")]
		public bool Equals(SerializedGuid AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F23B80", Offset = "0x5F22F80", VA = "0x185F23B80", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F23C10", Offset = "0x5F23010", VA = "0x185F23C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F23B10", Offset = "0x5F22F10", VA = "0x185F23B10", Slot = "6")]
		public int CompareTo(SerializedGuid AAMIMDAKFMC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HFBFIHAAODH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type ONJFKEFNINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string DHDILOKGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool EIELDKDGOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool BKDKJHBMNII;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5F206A0", Offset = "0x5F1FAA0", VA = "0x185F206A0")]
	public HFBFIHAAODH(Type NAGMOFGIEOL, string HEPIBIKAJDK, bool CBAFCEGKKMO = false, bool PFPLLANEMKF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NKOLFLIKMKN<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct FCDCIJJPBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long DKDPBEJKPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long KICEOOLHBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int DLGIFELBMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int LLFIDKPOGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool OCKHHLHPBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string HJNILDEJBFE;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35758B0", Offset = "0x3574CB0", VA = "0x1835758B0")]
		public FCDCIJJPBCM(long DKDPBEJKPHG, int DLGIFELBMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3575880", Offset = "0x3574C80", VA = "0x183575880")]
		public FCDCIJJPBCM(long DKDPBEJKPHG, long KICEOOLHBMH, int DLGIFELBMAM, int LLFIDKPOGKO, bool OCKHHLHPBBM, string HJNILDEJBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3575790", Offset = "0x3574B90", VA = "0x183575790")]
		public int KHCLFKJIJNF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3575770", Offset = "0x3574B70", VA = "0x183575770")]
		public int EKKAKEGPMMO(int GFIFCCPAOHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3575710", Offset = "0x3574B10", VA = "0x183575710")]
		public double DOLDPOPCGLD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x35757E0", Offset = "0x3574BE0", VA = "0x1835757E0")]
		public FCDCIJJPBCM MKIFMMPFLMO(long KICEOOLHBMH, int LLFIDKPOGKO)
		{
			return default(FCDCIJJPBCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JNCJJIKLGBC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct ADMAPBIAJII<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public JNCJJIKLGBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<JNCJJIKLGBC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private JNCJJIKLGBC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3631C10", Offset = "0x3631010", VA = "0x183631C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3632130", Offset = "0x3631530", VA = "0x183632130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey JFBDDAMOHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NKOLFLIKMKN<TKey> CBPCKBLKEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly AMCJMMGFCLE HILPECKCPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<JNCJJIKLGBC> DAEMLBINCBC;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string HOFGNJAPCDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x39E7DB0", Offset = "0x39E71B0", VA = "0x1839E7DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<JNCJJIKLGBC> DNIIMHNKHNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x39E7B40", Offset = "0x39E6F40", VA = "0x1839E7B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public FCDCIJJPBCM BKDAMHMPCLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x39E7F40", Offset = "0x39E7340", VA = "0x1839E7F40")]
			[CompilerGenerated]
			get
			{
				return default(FCDCIJJPBCM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x39E7B80", Offset = "0x39E6F80", VA = "0x1839E7B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x39E7F60", Offset = "0x39E7360", VA = "0x1839E7F60")]
		internal JNCJJIKLGBC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, TKey KCGLPAPOILB, AMCJMMGFCLE HILPECKCPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x39E7DE0", Offset = "0x39E71E0", VA = "0x1839E7DE0")]
		public JNCJJIKLGBC KNILBGICBCG(TKey KCGLPAPOILB, [Optional] AMCJMMGFCLE? NNMBLDHDEJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x24D6750", Offset = "0x24D5B50", VA = "0x1824D6750")]
		[AsyncStateMachine(typeof(ADMAPBIAJII<>))]
		public Task<T> HDCJIKIFMLC<T>(TKey KCGLPAPOILB, Func<JNCJJIKLGBC, Task<T>> BINBFFLGBGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x39E7BB0", Offset = "0x39E6FB0", VA = "0x1839E7BB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class PDALPHEDIEC : IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, FCDCIJJPBCM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NKOLFLIKMKN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, FCDCIJJPBCM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, FCDCIJJPBCM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1EBFDA0", Offset = "0x1EBF1A0", VA = "0x181EBFDA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FCDCIJJPBCM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3F96FC0", Offset = "0x3F963C0", VA = "0x183F96FC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1EBFE90", Offset = "0x1EBF290", VA = "0x181EBFE90")]
		[DebuggerHidden]
		public PDALPHEDIEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x34A1050", Offset = "0x34A0450", VA = "0x1834A1050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F96B10", Offset = "0x3F95F10", VA = "0x183F96B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F96AC0", Offset = "0x3F95EC0", VA = "0x183F96AC0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F96F70", Offset = "0x3F96370", VA = "0x183F96F70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3F96EB0", Offset = "0x3F962B0", VA = "0x183F96EB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x34AA010", Offset = "0x34A9410", VA = "0x1834AA010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AIBEHAMJBJA : IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, FCDCIJJPBCM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private JNCJJIKLGBC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public JNCJJIKLGBC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NKOLFLIKMKN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<JNCJJIKLGBC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, FCDCIJJPBCM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, FCDCIJJPBCM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x1EBFDA0", Offset = "0x1EBF1A0", VA = "0x181EBFDA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, FCDCIJJPBCM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x364BDE0", Offset = "0x364B1E0", VA = "0x18364BDE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1EBFE90", Offset = "0x1EBF290", VA = "0x181EBFE90")]
		[DebuggerHidden]
		public AIBEHAMJBJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x364BE40", Offset = "0x364B240", VA = "0x18364BE40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x364B4D0", Offset = "0x364A8D0", VA = "0x18364B4D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x364B410", Offset = "0x364A810", VA = "0x18364B410")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x364B470", Offset = "0x364A870", VA = "0x18364B470")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x364BD90", Offset = "0x364B190", VA = "0x18364BD90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x364BC80", Offset = "0x364B080", VA = "0x18364BC80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x364BD60", Offset = "0x364B160", VA = "0x18364BD60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> KDMJEBHLAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> NALHAJOFBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<NKOLFLIKMKN<TKey>, AMCJMMGFCLE> AEMMBAEEICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly AMCJMMGFCLE HILPECKCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JNCJJIKLGBC JGNJNFEIBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool APMGFBPMLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int AHLCAAFDFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch CDMEECINLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int DFNKKICGIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string FINDOCALKJK;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JNCJJIKLGBC KIJAJFGEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string HOFGNJAPCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x79F1A0", Offset = "0x79E5A0", VA = "0x18079F1A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A130", Offset = "0x3E09530", VA = "0x183E0A130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A190", Offset = "0x3E09590", VA = "0x183E0A190")]
	public NKOLFLIKMKN(TKey NCLBGGMPLFJ, AMCJMMGFCLE HILPECKCPNP, [Optional] int? DLGIFELBMAM, [Optional][CanBeNull] Stopwatch CDMEECINLMA, [Optional] Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> KDMJEBHLAFL, [Optional] Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> NALHAJOFBDD, [Optional] Action<NKOLFLIKMKN<TKey>, AMCJMMGFCLE> AEMMBAEEICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A020", Offset = "0x3E09420", VA = "0x183E0A020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E09F90", Offset = "0x3E09390", VA = "0x183E09F90")]
	[IteratorStateMachine(typeof(NKOLFLIKMKN<>.PDALPHEDIEC))]
	public IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)> DAIDJMCEFKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E09EC0", Offset = "0x3E092C0", VA = "0x183E09EC0")]
	[IteratorStateMachine(typeof(NKOLFLIKMKN<>.AIBEHAMJBJA))]
	private IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)> DAIDJMCEFKE(List<TKey> KGIHKOADMFC, JNCJJIKLGBC BJJBBPCCKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E0A0B0", Offset = "0x3E094B0", VA = "0x183E0A0B0")]
	private (long, int) EADDNKPBDCD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class EAJIEFNAEFL<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected EAJIEFNAEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public abstract class FPBPGHDBNCJ<TKey> : EAJIEFNAEFL<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate string OBLPDLFLDPJ(TKey KCGLPAPOILB);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x359BD70", Offset = "0x359B170", VA = "0x18359BD70")]
	private static string ADPNIODKIOF(TKey KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x359BF00", Offset = "0x359B300", VA = "0x18359BF00", Slot = "4")]
	public override string EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x359BDB0", Offset = "0x359B1B0", VA = "0x18359BDB0")]
	public string EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, [NotNull] OBLPDLFLDPJ BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PHCBNNCAEFM(NKOLFLIKMKN<TKey> CBPCKBLKEKD, [NotNull] OBLPDLFLDPJ BMEEPLKLOCG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x359BFC0", Offset = "0x359B3C0", VA = "0x18359BFC0")]
	protected FPBPGHDBNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KIDKNMLKPJP<TKey> : EAJIEFNAEFL<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string JFECHMPOKON(TKey KCGLPAPOILB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string GCJEDCLNDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double CPLPMEJPMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool GKOACIKIGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int EDHAIGECBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> PJLBFCLIKLM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A72E10", Offset = "0x3A72210", VA = "0x183A72E10")]
	private static string ADPNIODKIOF(TKey KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A73980", Offset = "0x3A72D80", VA = "0x183A73980")]
	public KIDKNMLKPJP(string GCJEDCLNDLH = "F2", double CPLPMEJPMDB = double.MaxValue, bool GKOACIKIGCK = false, int EDHAIGECBIN = int.MaxValue, [Optional] ISet<string> PJLBFCLIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A735A0", Offset = "0x3A729A0", VA = "0x183A735A0", Slot = "4")]
	public override Dictionary<string, string> EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A738A0", Offset = "0x3A72CA0", VA = "0x183A738A0")]
	private bool NBJMHNHGMIE(string ECCJGJFNCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A72FB0", Offset = "0x3A723B0", VA = "0x183A72FB0")]
	public Dictionary<string, string> EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, JFECHMPOKON BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A73660", Offset = "0x3A72A60", VA = "0x183A73660")]
	private string MMPLCBDDBPO(StringBuilder ANCAFFABAIF, List<TKey> NGENCAJHHFK, JFECHMPOKON BMEEPLKLOCG, bool PDGPMGMDBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A72E50", Offset = "0x3A72250", VA = "0x183A72E50")]
	private static void EBLLJGAEODK(StringBuilder GICFLNDLDKB, string IEFKIGIALBM, bool LKPLIBNGIMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MNNBHBGDHNK<TKey> : FPBPGHDBNCJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct FLEPGJDMNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OBLPDLFLDPJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static MNNBHBGDHNK<TKey> MEGHANKAOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] IACHJFADKHF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D98CA0", Offset = "0x3D980A0", VA = "0x183D98CA0")]
	private MNNBHBGDHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3D97D30", Offset = "0x3D97130", VA = "0x183D97D30", Slot = "5")]
	protected override string PHCBNNCAEFM(NKOLFLIKMKN<TKey> CBPCKBLKEKD, OBLPDLFLDPJ BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3D97C40", Offset = "0x3D97040", VA = "0x183D97C40")]
	[CompilerGenerated]
	internal static string JPLKHAPCLOO(string HMCLCHPGHHB, TKey KCGLPAPOILB, FLEPGJDMNCJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class HPLMAOOKDKB : NKOLFLIKMKN<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class EHGMOCMBPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<HPLMAOOKDKB, AMCJMMGFCLE> callback;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public EHGMOCMBPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F1FF30", Offset = "0x5F1F330", VA = "0x185F1FF30")]
		internal void AJOAJGPKKAD(NKOLFLIKMKN<string> timer, AMCJMMGFCLE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F207D0", Offset = "0x5F1FBD0", VA = "0x185F207D0")]
	public HPLMAOOKDKB(AMCJMMGFCLE HILPECKCPNP, [Optional] string EAHDAFDPDCF, [Optional] int? DLGIFELBMAM, [Optional] Stopwatch CDMEECINLMA, [Optional] Action<string, FCDCIJJPBCM, AMCJMMGFCLE> KDMJEBHLAFL, [Optional] Action<string, FCDCIJJPBCM, AMCJMMGFCLE> NALHAJOFBDD, [Optional] Action<HPLMAOOKDKB, AMCJMMGFCLE> AEMMBAEEICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F20710", Offset = "0x5F1FB10", VA = "0x185F20710")]
	private static Action<NKOLFLIKMKN<string>, AMCJMMGFCLE> DLFNIDDGHFL(Action<HPLMAOOKDKB, AMCJMMGFCLE> DBIEPHLOFKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class CDFLCCDODBN
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class ELLHKJJIFKA : CDFLCCDODBN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static CDFLCCDODBN MEGHANKAOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5F1FFC0", Offset = "0x5F1F3C0", VA = "0x185F1FFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float OAMPGJAMHPH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x1D21A30", Offset = "0x1D20E30", VA = "0x181D21A30", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5F200C0", Offset = "0x5F1F4C0", VA = "0x185F200C0")]
		public ELLHKJJIFKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static CDFLCCDODBN MJJPGFOFMGI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static CDFLCCDODBN KBJBMEBJHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5F1F790", Offset = "0x5F1EB90", VA = "0x185F1F790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float OAMPGJAMHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	protected CDFLCCDODBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CLCEMLCANJI<T> : GAKFLCPPNMB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4961A60", Offset = "0x4960E60", VA = "0x184961A60")]
	public CLCEMLCANJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "10")]
	protected override void LDIIDNOOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AJEDBKKLCAH<T> : GAKFLCPPNMB<T> where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public override Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x364FF90", Offset = "0x364F390", VA = "0x18364FF90")]
	public AJEDBKKLCAH(Exception KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "10")]
	protected override void LDIIDNOOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IHJOMCHBHKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CAHFEKLEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface NGHKODLOGKF<T> : IHJOMCHBHKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class GAKFLCPPNMB<T> : NGHKODLOGKF<T>, IHJOMCHBHKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly JFHNBCMMCBM BOHKPGIFMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool APMGFBPMLGF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CAHFEKLEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x98D6D0", Offset = "0x98CAD0", VA = "0x18098D6D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3683CA0", Offset = "0x36830A0", VA = "0x183683CA0")]
	public GAKFLCPPNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3683BA0", Offset = "0x3682FA0", VA = "0x183683BA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LDIIDNOOKAH();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public abstract class LIJCPGEOJII<TTask, T> : GAKFLCPPNMB<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class DHNEFHHPDKF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public DHNEFHHPDKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3005580", Offset = "0x3004980", VA = "0x183005580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3005850", Offset = "0x3004C50", VA = "0x183005850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public LIJCPGEOJII<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public DHNEFHHPDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4E8EBF0", Offset = "0x4E8DFF0", VA = "0x184E8EBF0")]
		[AsyncStateMachine(typeof(LIJCPGEOJII<, >.DHNEFHHPDKF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OEJNJLMAEDL(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Task<T> CKAKCFLCDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	protected readonly CancellationTokenSource MFNNECHIHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C670", Offset = "0x3B5BA70", VA = "0x183B5C670")]
	protected LIJCPGEOJII(TTask CKAKCFLCDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3B5C480", Offset = "0x3B5B880", VA = "0x183B5C480", Slot = "10")]
	protected override void LDIIDNOOKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T ANJPPJJHMPM(TTask BBJKKLINEEF);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OILCGOGDJGI();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BMAJPGAEGPG<T> : GAKFLCPPNMB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DKOAJFJKKBO<Task<T>> FDIGPLCGJCM;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> NECKPDCDMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x356E700", Offset = "0x356DB00", VA = "0x18356E700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x461CAE0", Offset = "0x461BEE0", VA = "0x18461CAE0")]
	public BMAJPGAEGPG(DKOAJFJKKBO<Task<T>> GAJHIHLLEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x461CAC0", Offset = "0x461BEC0", VA = "0x18461CAC0", Slot = "10")]
	protected override void LDIIDNOOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DEOBFDNNDFH
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FEC0", Offset = "0x5F1F2C0", VA = "0x185F1FEC0")]
	[NotNull]
	public static byte[] IAAPGPFJNPC(this CIFCMCOICPJ ONBMJNJNMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FE50", Offset = "0x5F1F250", VA = "0x185F1FE50")]
	[NotNull]
	public static byte[] IAAPGPFJNPC(this CIFCMCOICPJ ONBMJNJNMCF, HashAlgorithmName MGHOAPLEGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FB20", Offset = "0x5F1EF20", VA = "0x185F1FB20")]
	public static bool CMBBLHOIPDE([CanBeNull] this CIFCMCOICPJ ONBMJNJNMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FCB0", Offset = "0x5F1F0B0", VA = "0x185F1FCB0")]
	public static bool CMBBLHOIPDE([CanBeNull] this CIFCMCOICPJ ONBMJNJNMCF, [Out] string JKDHCOHJJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F1FA00", Offset = "0x5F1EE00", VA = "0x185F1FA00")]
	private static bool BGNPCLJENKM([NotNull] CIFCMCOICPJ ONBMJNJNMCF, [Out][CanBeNull] byte[] DEJCIHCGBDP, [Out][CanBeNull] byte[] NHFDCBABDMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class APGNBOLEAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F4F0", Offset = "0x5F1E8F0", VA = "0x185F1F4F0")]
	[NotNull]
	public static byte[] IAAPGPFJNPC(this AGAHOOCGNLG KDJNLKENKCA, HashAlgorithmName MGHOAPLEGLH, byte[] OMINIJAKEJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AGAHOOCGNLG
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LCDAKKLMACI);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CIFCMCOICPJ : AGAHOOCGNLG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] CEMAPFGPAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] PGODNGOAMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class JJBMFGFCNIK
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static readonly ArrayPool<byte> FBAGFMIOMHE;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private static bool BJHJAOPEGGH;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5F20AF0", Offset = "0x5F1FEF0", VA = "0x185F20AF0")]
	public static void EIFLDJDLFDD(this IncrementalHash CCINMDKLNHD, [CanBeNull] GameObject IPBNGJILMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2697020", Offset = "0x2696420", VA = "0x182697020")]
	public static void EIFLDJDLFDD<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] T EGDKIFALJBD) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2697600", Offset = "0x2696A00", VA = "0x182697600")]
	public static void IOMCDFBBAGC<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] T KDJNLKENKCA) where T : AGAHOOCGNLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x26970E0", Offset = "0x26964E0", VA = "0x1826970E0")]
	public static void GLNLCMDGNHE<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] IList<T> MNMHALJEOLK) where T : AGAHOOCGNLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F20C30", Offset = "0x5F20030", VA = "0x185F20C30")]
	private static bool HEGMBGLDIEG([CanBeNull] AGAHOOCGNLG KDJNLKENKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5F21060", Offset = "0x5F20460", VA = "0x185F21060")]
	public static void KDHNHANNIDE(this IncrementalHash LCDAKKLMACI, [CanBeNull] string MKEENCLJDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5F211F0", Offset = "0x5F205F0", VA = "0x185F211F0")]
	public static void LKLAONDMOHJ(this IncrementalHash LCDAKKLMACI, long PKJJAJOFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5F20E30", Offset = "0x5F20230", VA = "0x185F20E30")]
	public static void JMGLMLEFEAL(this IncrementalHash LCDAKKLMACI, int LNIEPINKNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5F20920", Offset = "0x5F1FD20", VA = "0x185F20920")]
	public static void BCPBCPMHJAN(this IncrementalHash LCDAKKLMACI, short EONKNLBCMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5F20D20", Offset = "0x5F20120", VA = "0x185F20D20")]
	public static void JDNDJBHFLEO(this IncrementalHash LCDAKKLMACI, byte DOLGPFMIJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5F213C0", Offset = "0x5F207C0", VA = "0x185F213C0")]
	public static void MOLKOFDAMKJ(this IncrementalHash LCDAKKLMACI, bool DAEJIKLECMG, bool JDPFAEPNJIL = false, bool LIBDKMDKNPG = false, bool CFCAIMLLPLB = false, bool BHDJEEMHHFO = false, bool GKDFCJGLINJ = false, bool GFFJOLKBPGI = false, bool NDBDBEPACIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26969F0", Offset = "0x2695DF0", VA = "0x1826969F0")]
	public static void EBDABJCJLDE<T>(this IncrementalHash LCDAKKLMACI, T EPPCBJOAABF) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5F21000", Offset = "0x5F20400", VA = "0x185F21000")]
	public static void JOANHBCDMPM(this IncrementalHash LCDAKKLMACI, float AAKFBLALGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5F20CC0", Offset = "0x5F200C0", VA = "0x185F20CC0")]
	public static void IEIBNONKDPI(this IncrementalHash LCDAKKLMACI, ulong FCGEMOMALOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5F21530", Offset = "0x5F20930", VA = "0x185F21530")]
	public static void PNPNMOOENGA(this IncrementalHash LCDAKKLMACI, uint KKBPPNEEMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5F20BD0", Offset = "0x5F1FFD0", VA = "0x185F20BD0")]
	public static void GCALIGEJJMD(this IncrementalHash LCDAKKLMACI, ushort FBLDHGFEHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5F210C0", Offset = "0x5F204C0", VA = "0x185F210C0")]
	public static void LGIHPDANDBH(this IncrementalHash LCDAKKLMACI, Vector3 HIGOILIBABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class APLKCODFJME : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5F1F730", Offset = "0x5F1EB30", VA = "0x185F1F730")]
	public APLKCODFJME(string DCKDMGKGDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class KOBGPFBONGN<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class NBBJOLKFIBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public TNode NHHBAHIFHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TNode BBCCHMIJNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public EPAJKEJCDIK DALJKEMOJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public List<EPAJKEJCDIK> HIEFGJEBFKA;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public NBBJOLKFIBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct EPAJKEJCDIK : IComparable<EPAJKEJCDIK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int ODKHDABOADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public TClaimant OBMAFLBLDOK;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB9EF60", Offset = "0xB9E360", VA = "0x180B9EF60")]
		public EPAJKEJCDIK(int ODKHDABOADA, TClaimant OBMAFLBLDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3234DD0", Offset = "0x32341D0", VA = "0x183234DD0")]
		public bool OKIENCOFDMM([In] EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3234E30", Offset = "0x3234230", VA = "0x183234E30")]
		public bool OLGPHMGNBJB([In] EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3234DC0", Offset = "0x32341C0", VA = "0x183234DC0", Slot = "4")]
		public int CompareTo(EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3234E40", Offset = "0x3234240", VA = "0x183234E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum JGCMADMIHPP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class PINEFEFFENB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public KOBGPFBONGN<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9346D0", Offset = "0x933AD0", VA = "0x1809346D0")]
		[DebuggerHidden]
		public PINEFEFFENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8F00", Offset = "0x3FC8300", VA = "0x183FC8F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3FC90C0", Offset = "0x3FC84C0", VA = "0x183FC90C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3FC8FE0", Offset = "0x3FC83E0", VA = "0x183FC8FE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34A24C0", Offset = "0x34A18C0", VA = "0x1834A24C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly MKJAGKBNDJE<NBBJOLKFIBO> AGOLHNONGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly MKJAGKBNDJE<List<EPAJKEJCDIK>> GGIOOKAIELJ;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static int PNJDIDJFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal readonly Dictionary<TClaimant, TNode> JMCPEEKJKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	internal readonly Dictionary<TNode, NBBJOLKFIBO> ANPJNCCGINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JGCMADMIHPP GBFDMJLKPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool KJJCMGKHPAB;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EMNIEHJLIPN(TNode JACJPEOECBN);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DKJOJEAPNAL(TNode JACJPEOECBN, TClaimant BECLOHDDEEB, TClaimant OIHAHCKDGFN);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D600", Offset = "0x3A9CA00", VA = "0x183A9D600")]
	public KOBGPFBONGN(JGCMADMIHPP GBFDMJLKPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D340", Offset = "0x3A9C740", VA = "0x183A9D340")]
	public void PMKFMFIAAFM(TNode JACJPEOECBN, TNode ANPHHFMKKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CA30", Offset = "0x3A9BE30", VA = "0x183A9CA30")]
	public void JJLKLFCNEFP(TClaimant OBMAFLBLDOK, TNode MECNJGJFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C170", Offset = "0x3A9B570", VA = "0x183A9C170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BDE0", Offset = "0x3A9B1E0", VA = "0x183A9BDE0")]
	private void BLNIECMJILI(TClaimant OBMAFLBLDOK, TNode FOCGMHOCFAE, TNode MECNJGJFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D3D0", Offset = "0x3A9C7D0", VA = "0x183A9D3D0")]
	private int PMPBPIBKFME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D000", Offset = "0x3A9C400", VA = "0x183A9D000")]
	private void NODFBCIDHNC(TClaimant OBMAFLBLDOK, TNode FCCCHGJMOFA, TNode PKEMEACBKBP, int LFJEEDADMFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C0E0", Offset = "0x3A9B4E0", VA = "0x183A9C0E0")]
	private void CLBCLJELBGE(EPAJKEJCDIK GBCFFLIJDHF, NBBJOLKFIBO HLLJNBMNEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C470", Offset = "0x3A9B870", VA = "0x183A9C470")]
	private void HGPFFEBAEOJ(TClaimant OBMAFLBLDOK, TNode FCCCHGJMOFA, TNode PKEMEACBKBP, int LFJEEDADMFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C750", Offset = "0x3A9BB50", VA = "0x183A9C750")]
	private void IGEIMFFOFIC(EPAJKEJCDIK GBCFFLIJDHF, TNode JACJPEOECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C940", Offset = "0x3A9BD40", VA = "0x183A9C940")]
	private void JJIFFBPJKIC(EPAJKEJCDIK GBCFFLIJDHF, NBBJOLKFIBO HLLJNBMNEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C340", Offset = "0x3A9B740", VA = "0x183A9C340")]
	private void FMKBKFMNBGJ(NBBJOLKFIBO HLLJNBMNEIN, bool COMLFJBGOJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CCC0", Offset = "0x3A9C0C0", VA = "0x183A9CCC0")]
	private void NLBJLKNJMKG(NBBJOLKFIBO HLLJNBMNEIN, TNode ANPHHFMKKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C860", Offset = "0x3A9BC60", VA = "0x183A9C860")]
	[IteratorStateMachine(typeof(KOBGPFBONGN<, >.PINEFEFFENB))]
	private IEnumerable<TNode> ILECMPAPDPC(TNode FCCCHGJMOFA, TNode PKEMEACBKBP, bool KHIKMILLNOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BE80", Offset = "0x3A9B280", VA = "0x183A9BE80")]
	private NBBJOLKFIBO CBHLJONKCHH(TNode JACJPEOECBN, TNode BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BF70", Offset = "0x3A9B370", VA = "0x183A9BF70")]
	private NBBJOLKFIBO CFKAPFNIJAG(TNode JACJPEOECBN, TNode BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CB50", Offset = "0x3A9BF50", VA = "0x183A9CB50")]
	private void NCFOJLDNCCD(NBBJOLKFIBO HLLJNBMNEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GKMJFENNOOD<T> : IEnumerable<GKMJFENNOOD<T>.MKKHHIIAOPD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct MKKHHIIAOPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public T FDFHGIHHGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int OJANCMLFDOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class EFADCHLKFCK : IEnumerator<MKKHHIIAOPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private GKMJFENNOOD<T> NNIDGPDMKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int OJANCMLFDOJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x31DC420", Offset = "0x31DB820", VA = "0x1831DC420", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MKKHHIIAOPD FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x31DC590", Offset = "0x31DB990", VA = "0x1831DC590", Slot = "4")]
			get
			{
				return default(MKKHHIIAOPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x31DC4A0", Offset = "0x31DB8A0", VA = "0x1831DC4A0")]
		public EFADCHLKFCK(GKMJFENNOOD<T> NNIDGPDMKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x31DC310", Offset = "0x31DB710", VA = "0x1831DC310", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x31DC410", Offset = "0x31DB810", VA = "0x1831DC410", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC45990", Offset = "0xC44D90", VA = "0x180C45990", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct ICNAOKIKAHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public bool HFIOALKKLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public T FDFHGIHHGHO;
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int FOKIGDDFELJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<T, int> OFKAKALALIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private ICNAOKIKAHB[] JADIFEINCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int OAAHKOEKBEH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int GCIOAGMCNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC8F0", Offset = "0x7DBCF0", VA = "0x1807DC8F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC410", Offset = "0x7DB810", VA = "0x1807DC410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3014C10", Offset = "0x3014010", VA = "0x183014C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x36984A0", Offset = "0x36978A0", VA = "0x1836984A0")]
	public GKMJFENNOOD(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3698950", Offset = "0x3697D50", VA = "0x183698950")]
	public GKMJFENNOOD(MKKHHIIAOPD[] KOJMOIDCENN, bool CFGOOFIDDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3698330", Offset = "0x3697730", VA = "0x183698330")]
	public int PFLCPCGFOPO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3697C80", Offset = "0x3697080", VA = "0x183697C80")]
	private int DGHONKFAEOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x36983F0", Offset = "0x36977F0", VA = "0x1836983F0", Slot = "6")]
	protected virtual uint PPOEEMPMPBC(uint LCDAKKLMACI, T FDFHGIHHGHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3698060", Offset = "0x3697460", VA = "0x183698060")]
	public bool HDJGLIAEGFK(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x36981A0", Offset = "0x36975A0", VA = "0x1836981A0")]
	public int MIIMNLFBFLM(T FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3698270", Offset = "0x3697670", VA = "0x183698270")]
	public T MMNGEILPGIO(int OJANCMLFDOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x36979D0", Offset = "0x3696DD0", VA = "0x1836979D0")]
	public bool AMOFEKFEHHG(T FDFHGIHHGHO, bool DKNJCKKBPHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3697770", Offset = "0x3696B70", VA = "0x183697770")]
	public bool AMOFEKFEHHG(T FDFHGIHHGHO, int OJANCMLFDOJ, bool DKNJCKKBPHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3698150", Offset = "0x3697550", VA = "0x183698150")]
	private int KGIIAENAOEC(int DAGOHCNFGEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3698420", Offset = "0x3697820", VA = "0x183698420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3698420", Offset = "0x3697820", VA = "0x183698420", Slot = "4")]
	private IEnumerator<MKKHHIIAOPD> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MKJAGKBNDJE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Stack<T> IKFPJNENKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly List<T> JLCFNGBLIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly int EOKNBDGLEMM;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AE90", Offset = "0x3D8A290", VA = "0x183D8AE90")]
	public static MKJAGKBNDJE<T> NOFMACCNDBH(int NOOJMJOLDPD = 0, int EOKNBDGLEMM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A920", Offset = "0x3D89D20", VA = "0x183D8A920")]
	public static MKJAGKBNDJE<T> AKFJOFNCOMH(int NOOJMJOLDPD = 0, int EOKNBDGLEMM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AF70", Offset = "0x3D8A370", VA = "0x183D8AF70")]
	public MKJAGKBNDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AFA0", Offset = "0x3D8A3A0", VA = "0x183D8AFA0")]
	public MKJAGKBNDJE(int NOOJMJOLDPD, int EOKNBDGLEMM = int.MaxValue, bool DFALBBJBEPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AC20", Offset = "0x3D8A020", VA = "0x183D8AC20")]
	public T FJPADMGMHOB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D8ADA0", Offset = "0x3D8A1A0", VA = "0x183D8ADA0")]
	public void FLLAKBFBGHI(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AA00", Offset = "0x3D89E00", VA = "0x183D8AA00")]
	private void ANAGJHLGHLO(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AE70", Offset = "0x3D8A270", VA = "0x183D8AE70")]
	private void NKELDGBIOAI(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D8AAE0", Offset = "0x3D89EE0", VA = "0x183D8AAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D8A720", Offset = "0x3D89B20", VA = "0x183D8A720")]
	private void AAELJPLFHHG(IEnumerable<T> FNPMCCBNOOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AMMEHNBEPDB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<int, T> PBLEFJPDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private T IOJEDBLGOHK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T NGMIONJIHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x79F1B0", Offset = "0x79E5B0", VA = "0x18079F1B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3667A30", Offset = "0x3666E30", VA = "0x183667A30")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3667F00", Offset = "0x3667300", VA = "0x183667F00")]
	public bool KFIFCFIPLDK(int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3667B20", Offset = "0x3666F20", VA = "0x183667B20")]
	public T JCNPCPMLLNE(int PEBIBIKIFAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3667880", Offset = "0x3666C80", VA = "0x183667880")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3667F70", Offset = "0x3667370", VA = "0x183667F70")]
	public bool MFCFPLHBNLD(int ODKHDABOADA, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3667FC0", Offset = "0x36673C0", VA = "0x183667FC0")]
	public AMMEHNBEPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class JCGFKICEDPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct FBFFIDILHNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T NAJOFLHMBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int APOIIOHDIPA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	protected readonly List<FBFFIDILHNO> BAFLFHMOJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private T PPCIBCFFBNJ;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3014C10", Offset = "0x3014010", VA = "0x183014C10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x395EBF0", Offset = "0x395DFF0", VA = "0x18395EBF0")]
	public bool NBEEIKJCOIK(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x395E9F0", Offset = "0x395DDF0", VA = "0x18395E9F0")]
	public void FLOHBAGDPJC(T FDFHGIHHGHO, int ODKHDABOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x395ED70", Offset = "0x395E170", VA = "0x18395ED70")]
	public bool NJHEJNEGCKN(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x395EEC0", Offset = "0x395E2C0", VA = "0x18395EEC0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x395E970", Offset = "0x395DD70", VA = "0x18395E970")]
	public T DGAGHOOFINN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x395EA90", Offset = "0x395DE90", VA = "0x18395EA90")]
	private void JLKLAMILBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x395EF20", Offset = "0x395E320", VA = "0x18395EF20")]
	public JCGFKICEDPM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[SerializeField]
		[IEOBHDPFGNE(DOCALCFNJLI.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5F22810", Offset = "0x5F21C10", VA = "0x185F22810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5F22AE0", Offset = "0x5F21EE0", VA = "0x185F22AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5F229F0", Offset = "0x5F21DF0", VA = "0x185F229F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5F22760", Offset = "0x5F21B60", VA = "0x185F22760")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5F22A30", Offset = "0x5F21E30", VA = "0x185F22A30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5F22940", Offset = "0x5F21D40", VA = "0x185F22940")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F226D0", Offset = "0x5F21AD0", VA = "0x185F226D0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41703A0", Offset = "0x416F7A0", VA = "0x1841703A0", Slot = "4")]
		public virtual T LNJJLNCAPBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OBNGKHIKIFD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly Dictionary<byte, FLIGOANMBNO> BLMJBNIEFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly MKJAGKBNDJE<FLIGOANMBNO> FKAPMHCAOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly bool CDDPHMFPPGE;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public FLIGOANMBNO BNHOJOCIMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 PHJAJPELCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB27C50", Offset = "0xB27050", VA = "0x180B27C50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE1FFC0", Offset = "0xE1F3C0", VA = "0x180E1FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 CHOKGEFPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xE46BC0", Offset = "0xE45FC0", VA = "0x180E46BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HHGPHMOPIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F21920", Offset = "0x5F20D20", VA = "0x185F21920")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x79F140", Offset = "0x79E540", VA = "0x18079F140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int KHGKJHGCOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A7FB0", Offset = "0x7A73B0", VA = "0x1807A7FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8160", Offset = "0x7A7560", VA = "0x1807A8160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F22240", Offset = "0x5F21640", VA = "0x185F22240")]
	public OBNGKHIKIFD(Bounds MIHHAJALDDO, Vector2[] IDEIABOCHBO, int LLHDPEJKBBJ, byte DAGOHCNFGEF, float DNPJMDMPDAJ = 0f, [Optional] MKJAGKBNDJE<FLIGOANMBNO> FKAPMHCAOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F218C0", Offset = "0x5F20CC0", VA = "0x185F218C0")]
	public FLIGOANMBNO EPBBEPBNOOH(byte OJANCMLFDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F219A0", Offset = "0x5F20DA0", VA = "0x185F219A0")]
	public void IHMPCGGNHLK(Vector3 HGKJDOIPDNM, float OHEOLFGKDJO, float BCDDNDPIHDN, List<byte> IDEIMILGKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C05000", Offset = "0x5C04400", VA = "0x185C05000")]
	public void IGMHHGGPHCI(FLIGOANMBNO.IPIIIMLOGHP NGKKEAMMCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5F21770", Offset = "0x5F20B70", VA = "0x185F21770")]
	public static int APLJIJLAFDE(Vector2[] IDEIABOCHBO, int LLHDPEJKBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F22040", Offset = "0x5F21440", VA = "0x185F22040")]
	private FLIGOANMBNO PMMIDAKHGFN(byte OJANCMLFDOJ, FLIGOANMBNO.AEMKKDOGHKF PCHANGGJHIL, FLIGOANMBNO BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F21C90", Offset = "0x5F21090", VA = "0x185F21C90")]
	private void OCCKBAKBKHO(FLIGOANMBNO BBCCHMIJNJG, Vector2[] IDEIABOCHBO, int PDIEOELBCBA, int HCFPBHPKJKM, int ELLMANDPMKM, int AELNLDHLHAP, float DNPJMDMPDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F21A70", Offset = "0x5F20E70", VA = "0x185F21A70")]
	private void OBMPJOOOBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5F21860", Offset = "0x5F20C60", VA = "0x185F21860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F21940", Offset = "0x5F20D40", VA = "0x185F21940", Slot = "1")]
	~OBNGKHIKIFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FLIGOANMBNO
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum AEMKKDOGHKF
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum IPIIIMLOGHP
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public byte OFPLNGFPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Vector3 GNAGFCEEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Vector3 DPKBEHGMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Vector3 BBAHKJNDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Vector3 EABAAOMGBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public AEMKKDOGHKF JAANKAOKDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public FLIGOANMBNO NMNOBPOLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public List<FLIGOANMBNO> NLEMGFAOBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool LLCCIABHAIL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5F20580", Offset = "0x5F1F980", VA = "0x185F20580")]
	public FLIGOANMBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F20140", Offset = "0x5F1F540", VA = "0x185F20140")]
	public void AMKDDMPMJOF(FLIGOANMBNO NDPOCNKCALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	public void IGMHHGGPHCI(int EHCAHFJPNBP, IPIIIMLOGHP NGKKEAMMCBG, int FNELMHIJBBO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F20290", Offset = "0x5F1F690", VA = "0x185F20290")]
	public void IHMPCGGNHLK(List<byte> IDEIMILGKJA, Vector3 HGKJDOIPDNM, float OHEOLFGKDJO, float BCDDNDPIHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F20110", Offset = "0x5F1F510", VA = "0x185F20110")]
	public bool AMHKAOBMHGP(Vector3 INKDDDGDGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F20260", Offset = "0x5F1F660", VA = "0x185F20260")]
	public bool HFPBCBIPPND(Vector3 INKDDDGDGBD, float AOPCPDJBIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F204F0", Offset = "0x5F1F8F0", VA = "0x185F204F0")]
	public void NGFHLNOOHDK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct OFCAKHDMLDN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly List<Component> EPNEAFACLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private readonly bool ICHFDDIKMIJ;

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x358EE60", Offset = "0x358E260", VA = "0x18358EE60")]
			public OFCAKHDMLDN(List<Component> EPNEAFACLDA, bool ICHFDDIKMIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3EED360", Offset = "0x3EEC760", VA = "0x183EED360")]
			public BEPGOMEGGDO<T> MFONJKCHJIL()
			{
				return default(BEPGOMEGGDO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3EED3D0", Offset = "0x3EEC7D0", VA = "0x183EED3D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x3EED3D0", Offset = "0x3EEC7D0", VA = "0x183EED3D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct BEPGOMEGGDO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly List<Component> EPNEAFACLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private readonly bool ICHFDDIKMIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private int OJANCMLFDOJ;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T FPOHGHGPMEE
			{
				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0x45EC1D0", Offset = "0x45EB5D0", VA = "0x1845EC1D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x45EC160", Offset = "0x45EB560", VA = "0x1845EC160", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x45EC1A0", Offset = "0x45EB5A0", VA = "0x1845EC1A0")]
			public BEPGOMEGGDO(List<Component> EPNEAFACLDA, bool ICHFDDIKMIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x45EC0A0", Offset = "0x45EB4A0", VA = "0x1845EC0A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x45EC0B0", Offset = "0x45EB4B0", VA = "0x1845EC0B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x3280EC0", Offset = "0x32802C0", VA = "0x183280EC0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F24420", Offset = "0x5F23820", VA = "0x185F24420")]
		private void NGFHLNOOHDK(GameObject NMIGJPFCDKB, bool DBCFABNBIEE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F24260", Offset = "0x5F23660", VA = "0x185F24260")]
		public static void NGFHLNOOHDK(GameObject NMIGJPFCDKB, ToolHierarchyCache KLBHFGGIOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x28EC870", Offset = "0x28EBC70", VA = "0x1828EC870")]
		public void NIFEPKIKEBO<T>(Action<T> MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x28EC800", Offset = "0x28EBC00", VA = "0x1828EC800")]
		public T DHMPPGLJIIO<T>(bool ICHFDDIKMIJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x28ECA90", Offset = "0x28EBE90", VA = "0x1828ECA90")]
		public OFCAKHDMLDN<T> NKCHHHMOMJF<T>(bool ICHFDDIKMIJ = false) where T : class
		{
			return default(OFCAKHDMLDN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F23EA0", Offset = "0x5F232A0", VA = "0x185F23EA0")]
		public List<Component> FLNDOCHGDBL(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F23E20", Offset = "0x5F23220", VA = "0x185F23E20", Slot = "4")]
		public bool Equals(ToolHierarchyCache LGHEBJJLAGD, ToolHierarchyCache FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F241F0", Offset = "0x5F235F0", VA = "0x185F241F0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MBCPMMHPENP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HEPJABPCING<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private int NOOJMJOLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int MDHJDOKCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private List<T> CIBMCDHAIGI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x356E700", Offset = "0x356DB00", VA = "0x18356E700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T OBADPIAFNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x36E4AD0", Offset = "0x36E3ED0", VA = "0x1836E4AD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T AGDDDDHKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x36E4BF0", Offset = "0x36E3FF0", VA = "0x1836E4BF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T KOPKFGLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x36E4CC0", Offset = "0x36E40C0", VA = "0x1836E4CC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x36E4E60", Offset = "0x36E4260", VA = "0x1836E4E60")]
	public HEPJABPCING(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x36E4830", Offset = "0x36E3C30", VA = "0x1836E4830")]
	public void FLOHBAGDPJC(T OKPDMHFGNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x36E4E20", Offset = "0x36E4220", VA = "0x1836E4E20")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x36E4D50", Offset = "0x36E4150", VA = "0x1836E4D50")]
	public void MMIOIBBDAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x36E47D0", Offset = "0x36E3BD0", VA = "0x1836E47D0")]
	public void AEHFIAHEDHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x36E4D40", Offset = "0x36E4140", VA = "0x1836E4D40")]
	public void MIPHILMDBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IMEAJMNIOGO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct BNMDNOPANLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int APOIIOHDIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T NAJOFLHMBPO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Dictionary<object, BNMDNOPANLH> PBLEFJPDFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly EqualityComparer<T> DIAJBLCNANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T IOJEDBLGOHK;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T NGMIONJIHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xEDEF00", Offset = "0xEDE300", VA = "0x180EDEF00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x37CB850", Offset = "0x37CAC50", VA = "0x1837CB850", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool GFBKHLIEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x37CB8C0", Offset = "0x37CACC0", VA = "0x1837CB8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object GDJKPHAHAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x37CAA70", Offset = "0x37C9E70", VA = "0x1837CAA70")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, object FACMOGNGACN, int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x37CAF50", Offset = "0x37CA350", VA = "0x1837CAF50")]
	public bool KFIFCFIPLDK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x37CB630", Offset = "0x37CAA30", VA = "0x1837CB630")]
	public bool MFCFPLHBNLD(object FACMOGNGACN, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x37CB7F0", Offset = "0x37CABF0", VA = "0x1837CB7F0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x37C98A0", Offset = "0x37C8CA0", VA = "0x1837C98A0")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x37CB910", Offset = "0x37CAD10", VA = "0x1837CB910")]
	public IMEAJMNIOGO()
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
