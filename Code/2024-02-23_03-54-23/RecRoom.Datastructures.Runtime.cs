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
	[Cpp2IlInjected.Address(RVA = "0x7B7100", Offset = "0x7B5B00", VA = "0x1807B7100")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x877270", Offset = "0x875C70", VA = "0x180877270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LCDAKKLMACI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x861500", Offset = "0x85FF00", VA = "0x180861500")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F9D0E0", Offset = "0x5F9BAE0", VA = "0x185F9D0E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D0A0", Offset = "0x5F9BAA0", VA = "0x185F9D0A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D120", Offset = "0x5F9BB20", VA = "0x185F9D120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D2D0", Offset = "0x5F9BCD0", VA = "0x185F9D2D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D240", Offset = "0x5F9BC40", VA = "0x185F9D240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C63A0", Offset = "0x8C4DA0", VA = "0x1808C63A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9436D0", Offset = "0x9420D0", VA = "0x1809436D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D060", Offset = "0x5F9BA60", VA = "0x185F9D060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D1B0", Offset = "0x5F9BBB0", VA = "0x185F9D1B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CAD0", Offset = "0x5F9B4D0", VA = "0x185F9CAD0")]
	public void CopyBounds(SavedExtents AAMIMDAKFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CFB0", Offset = "0x5F9B9B0", VA = "0x185F9CFB0")]
	public void SetLocalSpaceBounds(Bounds NFOGKDCKMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x990C10", Offset = "0x98F610", VA = "0x180990C10")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CFA0", Offset = "0x5F9B9A0", VA = "0x185F9CFA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CBC0", Offset = "0x5F9B5C0", VA = "0x185F9CBC0")]
	private void MNBCAFBGGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CD80", Offset = "0x5F9B780", VA = "0x185F9CD80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9C460", Offset = "0x5F9AE60", VA = "0x185F9C460")]
	public static void CalculateLocalBoundsFor(GameObject IPBNGJILMJD, [Out] Bounds NFOGKDCKMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CB00", Offset = "0x5F9B500", VA = "0x185F9CB00")]
	private static void DBMCMIHIAMM(Bounds LFCFPOEDJCH, Color AICLPFMLBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9CFD0", Offset = "0x5F9B9D0", VA = "0x185F9CFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A6180", Offset = "0x7A4B80", VA = "0x1807A6180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CF0", Offset = "0x7B46F0", VA = "0x1807B5CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xDC39E0", Offset = "0xDC23E0", VA = "0x180DC39E0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41DFC80", Offset = "0x41DE680", VA = "0x1841DFC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
	public virtual void BCGNIFIPCBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x41DF860", Offset = "0x41DE260", VA = "0x1841DF860", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41DE500", Offset = "0x41DCF00", VA = "0x1841DE500", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41DFBB0", Offset = "0x41DE5B0", VA = "0x1841DFBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public HPDFJLLKHOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3743940", Offset = "0x3742340", VA = "0x183743940")]
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
		[Cpp2IlInjected.Address(RVA = "0x326DCD0", Offset = "0x326C6D0", VA = "0x18326DCD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x326DD20", Offset = "0x326C720", VA = "0x18326DD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x326DBD0", Offset = "0x326C5D0", VA = "0x18326DBD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey KCGLPAPOILB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x326DC70", Offset = "0x326C670", VA = "0x18326DC70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x326DAB0", Offset = "0x326C4B0", VA = "0x18326DAB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x326D7D0", Offset = "0x326C1D0", VA = "0x18326D7D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x326CC70", Offset = "0x326B670", VA = "0x18326CC70", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x326CBE0", Offset = "0x326B5E0", VA = "0x18326CBE0", Slot = "14")]
	protected virtual string HNJGPKJPNBO(TKeyVal CGEDIGMJHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x326CAF0", Offset = "0x326B4F0", VA = "0x18326CAF0", Slot = "4")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x326D970", Offset = "0x326C370", VA = "0x18326D970", Slot = "5")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x326CB40", Offset = "0x326B540", VA = "0x18326CB40", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x326CB40", Offset = "0x326B540", VA = "0x18326CB40", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x326D9C0", Offset = "0x326C3C0", VA = "0x18326D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public KNIOJFEAMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7240", Offset = "0x3AC5C40", VA = "0x183AC7240")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E144F0", Offset = "0x3E12EF0", VA = "0x183E144F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3E145D0", Offset = "0x3E12FD0", VA = "0x183E145D0")]
	public NACAHDFFKHI(float ENKHLKOMGOM, float IKJADMKEAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3E13B30", Offset = "0x3E12530", VA = "0x183E13B30")]
	public bool ALFMJHMFICK(float BEBEFOHACKO, T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3E13FF0", Offset = "0x3E129F0", VA = "0x183E13FF0")]
	public IEnumerable<T> DGJHKJLNOEA(float BEBEFOHACKO, [Optional] float? IDFDMDFDHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3E14320", Offset = "0x3E12D20", VA = "0x183E14320")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3E14390", Offset = "0x3E12D90", VA = "0x183E14390")]
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
		[Cpp2IlInjected.Address(RVA = "0xB58D00", Offset = "0xB57700", VA = "0x180B58D00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB58CF0", Offset = "0xB576F0", VA = "0x180B58CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x367D700", Offset = "0x367C100", VA = "0x18367D700")]
	public AGMDFDBHBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x367D720", Offset = "0x367C120", VA = "0x18367D720")]
	public AGMDFDBHBPA(int BFFGCOIILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x367C820", Offset = "0x367B220", VA = "0x18367C820")]
	public void FLOHBAGDPJC(float BEBEFOHACKO, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x367D200", Offset = "0x367BC00", VA = "0x18367D200")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x367CFB0", Offset = "0x367B9B0", VA = "0x18367CFB0")]
	public bool HCJKFLBJPOE(float HJNMDPFOKNI, float DJIIGFIILID, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x367C9A0", Offset = "0x367B3A0", VA = "0x18367C9A0")]
	public bool HAABPBKPJCH(float HJNMDPFOKNI, float DJIIGFIILID, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x367D3E0", Offset = "0x367BDE0", VA = "0x18367D3E0")]
	public void NKJCHKCCFBP(float HJNMDPFOKNI, float DJIIGFIILID, List<T> BGIIPDEPEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x367D670", Offset = "0x367C070", VA = "0x18367D670")]
	private int PNPKICPLPIJ(int OFPODMCIPGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x367D1B0", Offset = "0x367BBB0", VA = "0x18367D1B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6390", VA = "0x1807B7990", Slot = "4")]
	protected override Vector3 EINDGDLMGEC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F98CA0", Offset = "0x5F976A0", VA = "0x185F98CA0", Slot = "5")]
	protected override Vector3 NPFONBILKKF(Vector3 FDFHGIHHGHO, float FENMDPNPDJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5F98C50", Offset = "0x5F97650", VA = "0x185F98C50", Slot = "6")]
	protected override Vector3 LAACBOABDGL(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F98BD0", Offset = "0x5F975D0", VA = "0x185F98BD0", Slot = "7")]
	protected override Vector3 BBIBAANHCBB(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F98CE0", Offset = "0x5F976E0", VA = "0x185F98CE0")]
	public AFPDIHLBPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PECNOJHPOHL
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27F4D60", Offset = "0x27F3760", VA = "0x1827F4D60")]
	public static IFEOPNGOGPP<T1, T2> NDFPICIGPEG<T1, T2>(T1 JMEIENDPDHG, T2 BJEDKGGKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27F4DE0", Offset = "0x27F37E0", VA = "0x1827F4DE0")]
	public static IBCBDEIEBAK<T1, T2, T3> NDFPICIGPEG<T1, T2, T3>(T1 JMEIENDPDHG, T2 BJEDKGGKJJA, T3 BLEDDBCNNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFE880", Offset = "0x3DFD280", VA = "0x183DFE880")]
	internal static int JLHFONMPBGN(int MFMHFGFDJCC, int APMPIAEEHBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x53D06C0", Offset = "0x53CF0C0", VA = "0x1853D06C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x37D4810", Offset = "0x37D3210", VA = "0x1837D4810")]
	public IFEOPNGOGPP(T1 JMEIENDPDHG, T2 BJEDKGGKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x37D2F90", Offset = "0x37D1990", VA = "0x1837D2F90", Slot = "4")]
	public int CompareTo(IFEOPNGOGPP<T1, T2> AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37D3920", Offset = "0x37D2320", VA = "0x1837D3920", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x37D3CC0", Offset = "0x37D26C0", VA = "0x1837D3CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x37D3F50", Offset = "0x37D2950", VA = "0x1837D3F50", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x37C5810", Offset = "0x37C4210", VA = "0x1837C5810")]
	public IBCBDEIEBAK(T1 JMEIENDPDHG, T2 BJEDKGGKJJA, T3 BLEDDBCNNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x37C4ED0", Offset = "0x37C38D0", VA = "0x1837C4ED0", Slot = "4")]
	public int CompareTo(IBCBDEIEBAK<T1, T2, T3> AAMIMDAKFMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x37C5260", Offset = "0x37C3C60", VA = "0x1837C5260", Slot = "0")]
	public override bool Equals(object AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x37C5410", Offset = "0x37C3E10", VA = "0x1837C5410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x37C5540", Offset = "0x37C3F40", VA = "0x1837C5540", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x2081CC0", Offset = "0x20806C0", VA = "0x182081CC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2081C10", Offset = "0x2080610", VA = "0x182081C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float OJHADNPDKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB20780", Offset = "0xB1F180", VA = "0x180B20780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x43CB140", Offset = "0x43C9B40", VA = "0x1843CB140")]
	public T JIHJLCAGNPO(float FENMDPNPDJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x43CACB0", Offset = "0x43C96B0", VA = "0x1843CACB0")]
	public T EIKAHCABGHI(float FENMDPNPDJP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BJBGGFFNDCI(T CGDDINAJAOB, T GIFBDNCPDKC, float FENMDPNPDJP);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5F99DF0", Offset = "0x5F987F0", VA = "0x185F99DF0", Slot = "4")]
	protected override float BJBGGFFNDCI(float CGDDINAJAOB, float GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5F99E30", Offset = "0x5F98830", VA = "0x185F99E30")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xC81CC0", Offset = "0xC806C0", VA = "0x180C81CC0", Slot = "4")]
	protected override Vector3 BJBGGFFNDCI(Vector3 CGDDINAJAOB, Vector3 GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5F9DFB0", Offset = "0x5F9C9B0", VA = "0x185F9DFB0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5F99150", Offset = "0x5F97B50", VA = "0x185F99150", Slot = "4")]
	protected override Color BJBGGFFNDCI(Color CGDDINAJAOB, Color GIFBDNCPDKC, float FENMDPNPDJP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5F99210", Offset = "0x5F97C10", VA = "0x185F99210")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ADBIDCIIGBO : GKMJFENNOOD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5F98B80", Offset = "0x5F97580", VA = "0x185F98B80")]
	public ADBIDCIIGBO(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5F98B10", Offset = "0x5F97510", VA = "0x185F98B10", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A95BF0", Offset = "0x3A945F0", VA = "0x183A95BF0")]
	private DOMPGNALJAI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AKDPLNKMLHF, int DPFIGJNMEMA, int GHGHPMALHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4F23B20", Offset = "0x4F22520", VA = "0x184F23B20")]
	public static DOMPGNALJAI<T> JKJFENIAMEL()
	{
		return default(DOMPGNALJAI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4F23C20", Offset = "0x4F22620", VA = "0x184F23C20")]
	public (int, int, Task<T>) LELJJADJDGD(int OHLLMKBPNCN, [Optional] CancellationToken HNLFPBLPOKJ, double EDBFKNKJGAL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4F23930", Offset = "0x4F22330", VA = "0x184F23930")]
	public void DHHFAFENKEN(int OHLLMKBPNCN, int GHGHPMALHMN, [In] T MNKBHKEBOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KGHAIEGNIDK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AF70", Offset = "0x5F99970", VA = "0x185F9AF70")]
	public static DOMPGNALJAI<PJHBHBBODGG> JKJFENIAMEL()
	{
		return default(DOMPGNALJAI<PJHBHBBODGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AEF0", Offset = "0x5F998F0", VA = "0x185F9AEF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x303C1D0", Offset = "0x303ABD0", VA = "0x18303C1D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> PHNAAMFGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x36BFF50", Offset = "0x36BE950", VA = "0x1836BFF50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> GIBFJBENMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B918E0", Offset = "0x3B902E0", VA = "0x183B918E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3B91880", Offset = "0x3B90280", VA = "0x183B91880", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3B91920", Offset = "0x3B90320", VA = "0x183B91920", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B911A0", Offset = "0x3B8FBA0", VA = "0x183B911A0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B90FE0", Offset = "0x3B8F9E0", VA = "0x183B90FE0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B916B0", Offset = "0x3B900B0", VA = "0x183B916B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B90DC0", Offset = "0x3B8F7C0", VA = "0x183B90DC0", Slot = "9")]
	public void Add(TKey KCGLPAPOILB, TVal FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B90DF0", Offset = "0x3B8F7F0", VA = "0x183B90DF0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AA63C0", Offset = "0x3AA4DC0", VA = "0x183AA63C0", Slot = "8")]
	public bool ContainsKey(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B910A0", Offset = "0x3B8FAA0", VA = "0x183B910A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B91580", Offset = "0x3B8FF80", VA = "0x183B91580", Slot = "10")]
	public bool Remove(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B915B0", Offset = "0x3B8FFB0", VA = "0x183B915B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3B91700", Offset = "0x3B90100", VA = "0x183B91700", Slot = "11")]
	public bool TryGetValue(TKey KCGLPAPOILB, [Out] TVal FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3B911F0", Offset = "0x3B8FBF0", VA = "0x183B911F0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3B910D0", Offset = "0x3B8FAD0", VA = "0x183B910D0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B914E0", Offset = "0x3B8FEE0", VA = "0x183B914E0")]
	public bool MFCFPLHBNLD(TVal KCGLPAPOILB, [Out] TKey FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B90EB0", Offset = "0x3B8F8B0", VA = "0x183B90EB0")]
	private void CIDCOGCFLKI(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B91320", Offset = "0x3B8FD20", VA = "0x183B91320")]
	private void HHIEDMMEMHO(TKey KCGLPAPOILB, TVal HHFKHHNHDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B90C80", Offset = "0x3B8F680", VA = "0x183B90C80")]
	private bool AADKCBDLBJK(TKey KCGLPAPOILB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B91740", Offset = "0x3B90140", VA = "0x183B91740")]
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
			[Cpp2IlInjected.Address(RVA = "0x32BA3F0", Offset = "0x32B8DF0", VA = "0x1832BA3F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x32C4900", Offset = "0x32C3300", VA = "0x1832C4900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x32C6060", Offset = "0x32C4A60", VA = "0x1832C6060")]
		public Enumerator(KPOBAOAEHPH<T> BGIIPDEPEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x32C3470", Offset = "0x32C1E70", VA = "0x1832C3470", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x32C3DA0", Offset = "0x32C27A0", VA = "0x1832C3DA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x32C25C0", Offset = "0x32C0FC0", VA = "0x1832C25C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3ACF0B0", Offset = "0x3ACDAB0", VA = "0x183ACF0B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3ACEB10", Offset = "0x3ACD510", VA = "0x183ACEB10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3ACEDC0", Offset = "0x3ACD7C0", VA = "0x183ACEDC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFE00", Offset = "0x3ACE800", VA = "0x183ACFE00")]
	public KPOBAOAEHPH(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE050", Offset = "0x3ACCA50", VA = "0x183ACE050")]
	public void FLOHBAGDPJC(T FENMDPNPDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF220", Offset = "0x3ACDC20", VA = "0x183ACF220")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDED0", Offset = "0x3ACC8D0", VA = "0x183ACDED0")]
	public void DKNDEEGFLEB(int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF690", Offset = "0x3ACE090", VA = "0x183ACF690")]
	public void NLBPJJJIFLM(T[] NIKMHLBDDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF1E0", Offset = "0x3ACDBE0", VA = "0x183ACF1E0")]
	public Enumerator MFONJKCHJIL()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFB10", Offset = "0x3ACE510", VA = "0x183ACFB10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFB10", Offset = "0x3ACE510", VA = "0x183ACFB10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ACE8F0", Offset = "0x3ACD2F0", VA = "0x183ACE8F0")]
	private int GCODLMKIMNP(int OJANCMLFDOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ACFAE0", Offset = "0x3ACE4E0", VA = "0x183ACFAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E35FF0", Offset = "0x3E349F0", VA = "0x183E35FF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3E35FA0", Offset = "0x3E349A0", VA = "0x183E35FA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7B5BD0", Offset = "0x7B45D0", VA = "0x1807B5BD0")]
	public NIKMCCMKPLE(Func<Internal, External> CIKHLCDDLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E35F50", Offset = "0x3E34950", VA = "0x183E35F50")]
	public NIKMCCMKPLE(IReadOnlyList<Internal> EPNEAFACLDA, Func<Internal, External> CIKHLCDDLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E35ED0", Offset = "0x3E348D0", VA = "0x183E35ED0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34BDDB0", Offset = "0x34BC7B0", VA = "0x1834BDDB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3677080", Offset = "0x3675A80", VA = "0x183677080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan FKJIJMGJPBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x36771D0", Offset = "0x3675BD0", VA = "0x1836771D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4022B60", Offset = "0x4021560", VA = "0x184022B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4863160", Offset = "0x4861B60", VA = "0x184863160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x48635A0", Offset = "0x4861FA0", VA = "0x1848635A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3233C00", Offset = "0x3232600", VA = "0x183233C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3234DD0", Offset = "0x32337D0", VA = "0x183234DD0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A975B0", Offset = "0x3A95FB0", VA = "0x183A975B0")]
	public KGMFKEHFLIE(LAOFILPBCAJ GIELMLPDDLH, [Optional] AENBDFPKNKP IJADLGOMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A96C80", Offset = "0x3A95680", VA = "0x183A96C80")]
	public Task<TResult> GCBDEKMOOID(TRequest NCCHHGAPAOP, CancellationToken HNLFPBLPOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A96520", Offset = "0x3A94F20", VA = "0x183A96520")]
	private void BNJANPFPDAC(POPKHAHMFLO BDDMCLBDMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A97140", Offset = "0x3A95B40", VA = "0x183A97140")]
	[AsyncStateMachine(typeof(KGMFKEHFLIE<, >.CDFEFHLPJKK))]
	private Task MHLLPJKGJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A96290", Offset = "0x3A94C90", VA = "0x183A96290")]
	private POPKHAHMFLO BBCBHJIEHOK()
	{
		return default(POPKHAHMFLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A96750", Offset = "0x3A95150", VA = "0x183A96750")]
	[AsyncStateMachine(typeof(KGMFKEHFLIE<, >.ELKHDCDHNOH))]
	private Task GAEJNOAMKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A972E0", Offset = "0x3A95CE0", VA = "0x183A972E0")]
	private void POANDLPJOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A96710", Offset = "0x3A95110", VA = "0x183A96710", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x303C1D0", Offset = "0x303ABD0", VA = "0x18303C1D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OAMNHFOMJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x36BF7B0", Offset = "0x36BE1B0", VA = "0x1836BF7B0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3741FD0", Offset = "0x37409D0", VA = "0x183741FD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x361FDB0", Offset = "0x361E7B0", VA = "0x18361FDB0", Slot = "11")]
	public void Add(T ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3741780", Offset = "0x3740180", VA = "0x183741780")]
	public bool AMOFEKFEHHG(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3741DA0", Offset = "0x37407A0", VA = "0x183741DA0", Slot = "15")]
	public bool Remove(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3741910", Offset = "0x3740310", VA = "0x183741910", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x363A680", Offset = "0x3639080", VA = "0x18363A680", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3741840", Offset = "0x3740240", VA = "0x183741840", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37418A0", Offset = "0x37402A0", VA = "0x1837418A0", Slot = "13")]
	public bool Contains(T ELCFHMHMPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37418E0", Offset = "0x37402E0", VA = "0x1837418E0", Slot = "14")]
	public void CopyTo(T[] NIKMHLBDDHG, int HHFBBAINCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37419A0", Offset = "0x37403A0", VA = "0x1837419A0", Slot = "6")]
	public int IndexOf(T ELCFHMHMPMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3741AD0", Offset = "0x37404D0", VA = "0x183741AD0", Slot = "7")]
	public void Insert(int OJANCMLFDOJ, T ELCFHMHMPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3741BB0", Offset = "0x37405B0", VA = "0x183741BB0", Slot = "8")]
	public void RemoveAt(int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3741EE0", Offset = "0x37408E0", VA = "0x183741EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1EEA3D0", Offset = "0x1EE8DD0", VA = "0x181EEA3D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1963FA0", Offset = "0x19629A0", VA = "0x181963FA0")]
		public SerializedGuid([In] Guid INAIFGAIEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D540", Offset = "0x5F9BF40", VA = "0x185F9D540")]
		public static SerializedGuid OBPDDHFCBGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D4D0", Offset = "0x5F9BED0", VA = "0x185F9D4D0")]
		public static SerializedGuid JBJPAMMHNHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D470", Offset = "0x5F9BE70", VA = "0x185F9D470")]
		public bool INMLDJBGPFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D640", Offset = "0x5F9C040", VA = "0x185F9D640", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D5C0", Offset = "0x5F9BFC0", VA = "0x185F9D5C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D390", Offset = "0x5F9BD90", VA = "0x185F9D390", Slot = "7")]
		public bool Equals(SerializedGuid AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D3D0", Offset = "0x5F9BDD0", VA = "0x185F9D3D0", Slot = "0")]
		public override bool Equals(object MBCPMMHPENP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D460", Offset = "0x5F9BE60", VA = "0x185F9D460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D360", Offset = "0x5F9BD60", VA = "0x185F9D360", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x5F99EF0", Offset = "0x5F988F0", VA = "0x185F99EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x35A09C0", Offset = "0x359F3C0", VA = "0x1835A09C0")]
		public FCDCIJJPBCM(long DKDPBEJKPHG, int DLGIFELBMAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35A0990", Offset = "0x359F390", VA = "0x1835A0990")]
		public FCDCIJJPBCM(long DKDPBEJKPHG, long KICEOOLHBMH, int DLGIFELBMAM, int LLFIDKPOGKO, bool OCKHHLHPBBM, string HJNILDEJBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35A08A0", Offset = "0x359F2A0", VA = "0x1835A08A0")]
		public int KHCLFKJIJNF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x35A0880", Offset = "0x359F280", VA = "0x1835A0880")]
		public int EKKAKEGPMMO(int GFIFCCPAOHM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x35A0820", Offset = "0x359F220", VA = "0x1835A0820")]
		public double DOLDPOPCGLD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x35A08F0", Offset = "0x359F2F0", VA = "0x1835A08F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3676430", Offset = "0x3674E30", VA = "0x183676430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3676950", Offset = "0x3675350", VA = "0x183676950", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A30CF0", Offset = "0x3A2F6F0", VA = "0x183A30CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<JNCJJIKLGBC> DNIIMHNKHNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3A30A80", Offset = "0x3A2F480", VA = "0x183A30A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public FCDCIJJPBCM BKDAMHMPCLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3A30E80", Offset = "0x3A2F880", VA = "0x183A30E80")]
			[CompilerGenerated]
			get
			{
				return default(FCDCIJJPBCM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3A30AC0", Offset = "0x3A2F4C0", VA = "0x183A30AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3A30EA0", Offset = "0x3A2F8A0", VA = "0x183A30EA0")]
		internal JNCJJIKLGBC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, TKey KCGLPAPOILB, AMCJMMGFCLE HILPECKCPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A30D20", Offset = "0x3A2F720", VA = "0x183A30D20")]
		public JNCJJIKLGBC KNILBGICBCG(TKey KCGLPAPOILB, [Optional] AMCJMMGFCLE? NNMBLDHDEJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2504A70", Offset = "0x2503470", VA = "0x182504A70")]
		[AsyncStateMachine(typeof(ADMAPBIAJII<>))]
		public Task<T> HDCJIKIFMLC<T>(TKey KCGLPAPOILB, Func<JNCJJIKLGBC, Task<T>> BINBFFLGBGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A30AF0", Offset = "0x3A2F4F0", VA = "0x183A30AF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1EDCD50", Offset = "0x1EDB750", VA = "0x181EDCD50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3FCDF90", Offset = "0x3FCC990", VA = "0x183FCDF90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1EDCE40", Offset = "0x1EDB840", VA = "0x181EDCE40")]
		[DebuggerHidden]
		public PDALPHEDIEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x34BA360", Offset = "0x34B8D60", VA = "0x1834BA360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDAE0", Offset = "0x3FCC4E0", VA = "0x183FCDAE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDA90", Offset = "0x3FCC490", VA = "0x183FCDA90")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDF40", Offset = "0x3FCC940", VA = "0x183FCDF40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDE80", Offset = "0x3FCC880", VA = "0x183FCDE80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x35B8DC0", Offset = "0x35B77C0", VA = "0x1835B8DC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x1EDCD50", Offset = "0x1EDB750", VA = "0x181EDCD50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3680D90", Offset = "0x367F790", VA = "0x183680D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1EDCE40", Offset = "0x1EDB840", VA = "0x181EDCE40")]
		[DebuggerHidden]
		public AIBEHAMJBJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3680DF0", Offset = "0x367F7F0", VA = "0x183680DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3680480", Offset = "0x367EE80", VA = "0x183680480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x36803C0", Offset = "0x367EDC0", VA = "0x1836803C0")]
		private void DHKGKCPFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3680420", Offset = "0x367EE20", VA = "0x183680420")]
		private void GPHLLGKPILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3680D40", Offset = "0x367F740", VA = "0x183680D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3680C30", Offset = "0x367F630", VA = "0x183680C30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, FCDCIJJPBCM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3680D10", Offset = "0x367F710", VA = "0x183680D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A91A0", Offset = "0x7A7BA0", VA = "0x1807A91A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E40630", Offset = "0x3E3F030", VA = "0x183E40630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E40690", Offset = "0x3E3F090", VA = "0x183E40690")]
	public NKOLFLIKMKN(TKey NCLBGGMPLFJ, AMCJMMGFCLE HILPECKCPNP, [Optional] int? DLGIFELBMAM, [Optional][CanBeNull] Stopwatch CDMEECINLMA, [Optional] Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> KDMJEBHLAFL, [Optional] Action<TKey, FCDCIJJPBCM, AMCJMMGFCLE> NALHAJOFBDD, [Optional] Action<NKOLFLIKMKN<TKey>, AMCJMMGFCLE> AEMMBAEEICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E40520", Offset = "0x3E3EF20", VA = "0x183E40520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E40490", Offset = "0x3E3EE90", VA = "0x183E40490")]
	[IteratorStateMachine(typeof(NKOLFLIKMKN<>.PDALPHEDIEC))]
	public IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)> DAIDJMCEFKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E403C0", Offset = "0x3E3EDC0", VA = "0x183E403C0")]
	[IteratorStateMachine(typeof(NKOLFLIKMKN<>.AIBEHAMJBJA))]
	private IEnumerable<(TKey, List<TKey>, FCDCIJJPBCM)> DAIDJMCEFKE(List<TKey> KGIHKOADMFC, JNCJJIKLGBC BJJBBPCCKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E405B0", Offset = "0x3E3EFB0", VA = "0x183E405B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
	[Cpp2IlInjected.Address(RVA = "0x35C8B50", Offset = "0x35C7550", VA = "0x1835C8B50")]
	private static string ADPNIODKIOF(TKey KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x35C8CE0", Offset = "0x35C76E0", VA = "0x1835C8CE0", Slot = "4")]
	public override string EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x35C8B90", Offset = "0x35C7590", VA = "0x1835C8B90")]
	public string EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, [NotNull] OBLPDLFLDPJ BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PHCBNNCAEFM(NKOLFLIKMKN<TKey> CBPCKBLKEKD, [NotNull] OBLPDLFLDPJ BMEEPLKLOCG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x35C8DA0", Offset = "0x35C77A0", VA = "0x1835C8DA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A9E280", Offset = "0x3A9CC80", VA = "0x183A9E280")]
	private static string ADPNIODKIOF(TKey KCGLPAPOILB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EDF0", Offset = "0x3A9D7F0", VA = "0x183A9EDF0")]
	public KIDKNMLKPJP(string GCJEDCLNDLH = "F2", double CPLPMEJPMDB = double.MaxValue, bool GKOACIKIGCK = false, int EDHAIGECBIN = int.MaxValue, [Optional] ISet<string> PJLBFCLIKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EA10", Offset = "0x3A9D410", VA = "0x183A9EA10", Slot = "4")]
	public override Dictionary<string, string> EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A9ED10", Offset = "0x3A9D710", VA = "0x183A9ED10")]
	private bool NBJMHNHGMIE(string ECCJGJFNCFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E420", Offset = "0x3A9CE20", VA = "0x183A9E420")]
	public Dictionary<string, string> EGIDBMMBENC(NKOLFLIKMKN<TKey> CBPCKBLKEKD, JFECHMPOKON BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EAD0", Offset = "0x3A9D4D0", VA = "0x183A9EAD0")]
	private string MMPLCBDDBPO(StringBuilder ANCAFFABAIF, List<TKey> NGENCAJHHFK, JFECHMPOKON BMEEPLKLOCG, bool PDGPMGMDBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E2C0", Offset = "0x3A9CCC0", VA = "0x183A9E2C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DCF0D0", Offset = "0x3DCDAD0", VA = "0x183DCF0D0")]
	private MNNBHBGDHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE160", Offset = "0x3DCCB60", VA = "0x183DCE160", Slot = "5")]
	protected override string PHCBNNCAEFM(NKOLFLIKMKN<TKey> CBPCKBLKEKD, OBLPDLFLDPJ BMEEPLKLOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE070", Offset = "0x3DCCA70", VA = "0x183DCE070")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public EHGMOCMBPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5F99780", Offset = "0x5F98180", VA = "0x185F99780")]
		internal void AJOAJGPKKAD(NKOLFLIKMKN<string> timer, AMCJMMGFCLE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A020", Offset = "0x5F98A20", VA = "0x185F9A020")]
	public HPLMAOOKDKB(AMCJMMGFCLE HILPECKCPNP, [Optional] string EAHDAFDPDCF, [Optional] int? DLGIFELBMAM, [Optional] Stopwatch CDMEECINLMA, [Optional] Action<string, FCDCIJJPBCM, AMCJMMGFCLE> KDMJEBHLAFL, [Optional] Action<string, FCDCIJJPBCM, AMCJMMGFCLE> NALHAJOFBDD, [Optional] Action<HPLMAOOKDKB, AMCJMMGFCLE> AEMMBAEEICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5F99F60", Offset = "0x5F98960", VA = "0x185F99F60")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F99810", Offset = "0x5F98210", VA = "0x185F99810")]
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
			[Cpp2IlInjected.Address(RVA = "0x1D3B700", Offset = "0x1D3A100", VA = "0x181D3B700", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5F99910", Offset = "0x5F98310", VA = "0x185F99910")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F98FE0", Offset = "0x5F979E0", VA = "0x185F98FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4A203F0", Offset = "0x4A1EDF0", VA = "0x184A203F0")]
	public CLCEMLCANJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3685030", Offset = "0x3683A30", VA = "0x183685030")]
	public AJEDBKKLCAH(Exception KMJIPKGNLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x998D90", Offset = "0x997790", VA = "0x180998D90", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x36A1EC0", Offset = "0x36A08C0", VA = "0x1836A1EC0")]
	public GAKFLCPPNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x36A1DC0", Offset = "0x36A07C0", VA = "0x1836A1DC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x302CB10", Offset = "0x302B510", VA = "0x18302CB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x302CDE0", Offset = "0x302B7E0", VA = "0x18302CDE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public DHNEFHHPDKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9330", Offset = "0x4EF7D30", VA = "0x184EF9330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C320", Offset = "0x3B8AD20", VA = "0x183B8C320")]
	protected LIJCPGEOJII(TTask CKAKCFLCDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3B8C130", Offset = "0x3B8AB30", VA = "0x183B8C130", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x35998A0", Offset = "0x35982A0", VA = "0x1835998A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override JMGBCNAMNAH<T> DGCIHDBGHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4667780", Offset = "0x4666180", VA = "0x184667780")]
	public BMAJPGAEGPG(DKOAJFJKKBO<Task<T>> GAJHIHLLEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x4667760", Offset = "0x4666160", VA = "0x184667760", Slot = "10")]
	protected override void LDIIDNOOKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DEOBFDNNDFH
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5F99710", Offset = "0x5F98110", VA = "0x185F99710")]
	[NotNull]
	public static byte[] IAAPGPFJNPC(this CIFCMCOICPJ ONBMJNJNMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5F996A0", Offset = "0x5F980A0", VA = "0x185F996A0")]
	[NotNull]
	public static byte[] IAAPGPFJNPC(this CIFCMCOICPJ ONBMJNJNMCF, HashAlgorithmName MGHOAPLEGLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5F99370", Offset = "0x5F97D70", VA = "0x185F99370")]
	public static bool CMBBLHOIPDE([CanBeNull] this CIFCMCOICPJ ONBMJNJNMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5F99500", Offset = "0x5F97F00", VA = "0x185F99500")]
	public static bool CMBBLHOIPDE([CanBeNull] this CIFCMCOICPJ ONBMJNJNMCF, [Out] string JKDHCOHJJFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5F99250", Offset = "0x5F97C50", VA = "0x185F99250")]
	private static bool BGNPCLJENKM([NotNull] CIFCMCOICPJ ONBMJNJNMCF, [Out][CanBeNull] byte[] DEJCIHCGBDP, [Out][CanBeNull] byte[] NHFDCBABDMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class APGNBOLEAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5F98D40", Offset = "0x5F97740", VA = "0x185F98D40")]
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
	[Cpp2IlInjected.Address(RVA = "0x5F9A340", Offset = "0x5F98D40", VA = "0x185F9A340")]
	public static void EIFLDJDLFDD(this IncrementalHash CCINMDKLNHD, [CanBeNull] GameObject IPBNGJILMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x26FDDC0", Offset = "0x26FC7C0", VA = "0x1826FDDC0")]
	public static void EIFLDJDLFDD<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] T EGDKIFALJBD) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x26FE3A0", Offset = "0x26FCDA0", VA = "0x1826FE3A0")]
	public static void IOMCDFBBAGC<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] T KDJNLKENKCA) where T : AGAHOOCGNLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x26FDE80", Offset = "0x26FC880", VA = "0x1826FDE80")]
	public static void GLNLCMDGNHE<T>(this IncrementalHash CCINMDKLNHD, [CanBeNull] IList<T> MNMHALJEOLK) where T : AGAHOOCGNLG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A480", Offset = "0x5F98E80", VA = "0x185F9A480")]
	private static bool HEGMBGLDIEG([CanBeNull] AGAHOOCGNLG KDJNLKENKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A8B0", Offset = "0x5F992B0", VA = "0x185F9A8B0")]
	public static void KDHNHANNIDE(this IncrementalHash LCDAKKLMACI, [CanBeNull] string MKEENCLJDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AA40", Offset = "0x5F99440", VA = "0x185F9AA40")]
	public static void LKLAONDMOHJ(this IncrementalHash LCDAKKLMACI, long PKJJAJOFCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A680", Offset = "0x5F99080", VA = "0x185F9A680")]
	public static void JMGLMLEFEAL(this IncrementalHash LCDAKKLMACI, int LNIEPINKNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A170", Offset = "0x5F98B70", VA = "0x185F9A170")]
	public static void BCPBCPMHJAN(this IncrementalHash LCDAKKLMACI, short EONKNLBCMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A570", Offset = "0x5F98F70", VA = "0x185F9A570")]
	public static void JDNDJBHFLEO(this IncrementalHash LCDAKKLMACI, byte DOLGPFMIJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AC10", Offset = "0x5F99610", VA = "0x185F9AC10")]
	public static void MOLKOFDAMKJ(this IncrementalHash LCDAKKLMACI, bool DAEJIKLECMG, bool JDPFAEPNJIL = false, bool LIBDKMDKNPG = false, bool CFCAIMLLPLB = false, bool BHDJEEMHHFO = false, bool GKDFCJGLINJ = false, bool GFFJOLKBPGI = false, bool NDBDBEPACIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26FD790", Offset = "0x26FC190", VA = "0x1826FD790")]
	public static void EBDABJCJLDE<T>(this IncrementalHash LCDAKKLMACI, T EPPCBJOAABF) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A850", Offset = "0x5F99250", VA = "0x185F9A850")]
	public static void JOANHBCDMPM(this IncrementalHash LCDAKKLMACI, float AAKFBLALGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A510", Offset = "0x5F98F10", VA = "0x185F9A510")]
	public static void IEIBNONKDPI(this IncrementalHash LCDAKKLMACI, ulong FCGEMOMALOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AD80", Offset = "0x5F99780", VA = "0x185F9AD80")]
	public static void PNPNMOOENGA(this IncrementalHash LCDAKKLMACI, uint KKBPPNEEMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A420", Offset = "0x5F98E20", VA = "0x185F9A420")]
	public static void GCALIGEJJMD(this IncrementalHash LCDAKKLMACI, ushort FBLDHGFEHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A910", Offset = "0x5F99310", VA = "0x185F9A910")]
	public static void LGIHPDANDBH(this IncrementalHash LCDAKKLMACI, Vector3 HIGOILIBABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class APLKCODFJME : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5F98F80", Offset = "0x5F97980", VA = "0x185F98F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0xBAADD0", Offset = "0xBA97D0", VA = "0x180BAADD0")]
		public EPAJKEJCDIK(int ODKHDABOADA, TClaimant OBMAFLBLDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3264540", Offset = "0x3262F40", VA = "0x183264540")]
		public bool OKIENCOFDMM([In] EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x32645A0", Offset = "0x3262FA0", VA = "0x1832645A0")]
		public bool OLGPHMGNBJB([In] EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3264530", Offset = "0x3262F30", VA = "0x183264530", Slot = "4")]
		public int CompareTo(EPAJKEJCDIK AAMIMDAKFMC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x32645B0", Offset = "0x3262FB0", VA = "0x1832645B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x93FD90", Offset = "0x93E790", VA = "0x18093FD90")]
		[DebuggerHidden]
		public PINEFEFFENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x400CF00", Offset = "0x400B900", VA = "0x18400CF00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x400D0C0", Offset = "0x400BAC0", VA = "0x18400D0C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x400CFE0", Offset = "0x400B9E0", VA = "0x18400CFE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x34BB7D0", Offset = "0x34BA1D0", VA = "0x1834BB7D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3AC8CB0", Offset = "0x3AC76B0", VA = "0x183AC8CB0")]
	public KOBGPFBONGN(JGCMADMIHPP GBFDMJLKPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3AC89F0", Offset = "0x3AC73F0", VA = "0x183AC89F0")]
	public void PMKFMFIAAFM(TNode JACJPEOECBN, TNode ANPHHFMKKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3AC80E0", Offset = "0x3AC6AE0", VA = "0x183AC80E0")]
	public void JJLKLFCNEFP(TClaimant OBMAFLBLDOK, TNode MECNJGJFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7820", Offset = "0x3AC6220", VA = "0x183AC7820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7490", Offset = "0x3AC5E90", VA = "0x183AC7490")]
	private void BLNIECMJILI(TClaimant OBMAFLBLDOK, TNode FOCGMHOCFAE, TNode MECNJGJFILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8A80", Offset = "0x3AC7480", VA = "0x183AC8A80")]
	private int PMPBPIBKFME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3AC86B0", Offset = "0x3AC70B0", VA = "0x183AC86B0")]
	private void NODFBCIDHNC(TClaimant OBMAFLBLDOK, TNode FCCCHGJMOFA, TNode PKEMEACBKBP, int LFJEEDADMFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7790", Offset = "0x3AC6190", VA = "0x183AC7790")]
	private void CLBCLJELBGE(EPAJKEJCDIK GBCFFLIJDHF, NBBJOLKFIBO HLLJNBMNEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7B20", Offset = "0x3AC6520", VA = "0x183AC7B20")]
	private void HGPFFEBAEOJ(TClaimant OBMAFLBLDOK, TNode FCCCHGJMOFA, TNode PKEMEACBKBP, int LFJEEDADMFJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7E00", Offset = "0x3AC6800", VA = "0x183AC7E00")]
	private void IGEIMFFOFIC(EPAJKEJCDIK GBCFFLIJDHF, TNode JACJPEOECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7FF0", Offset = "0x3AC69F0", VA = "0x183AC7FF0")]
	private void JJIFFBPJKIC(EPAJKEJCDIK GBCFFLIJDHF, NBBJOLKFIBO HLLJNBMNEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3AC79F0", Offset = "0x3AC63F0", VA = "0x183AC79F0")]
	private void FMKBKFMNBGJ(NBBJOLKFIBO HLLJNBMNEIN, bool COMLFJBGOJN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8370", Offset = "0x3AC6D70", VA = "0x183AC8370")]
	private void NLBJLKNJMKG(NBBJOLKFIBO HLLJNBMNEIN, TNode ANPHHFMKKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7F10", Offset = "0x3AC6910", VA = "0x183AC7F10")]
	[IteratorStateMachine(typeof(KOBGPFBONGN<, >.PINEFEFFENB))]
	private IEnumerable<TNode> ILECMPAPDPC(TNode FCCCHGJMOFA, TNode PKEMEACBKBP, bool KHIKMILLNOL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7530", Offset = "0x3AC5F30", VA = "0x183AC7530")]
	private NBBJOLKFIBO CBHLJONKCHH(TNode JACJPEOECBN, TNode BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7620", Offset = "0x3AC6020", VA = "0x183AC7620")]
	private NBBJOLKFIBO CFKAPFNIJAG(TNode JACJPEOECBN, TNode BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC8200", Offset = "0x3AC6C00", VA = "0x183AC8200")]
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
			[Cpp2IlInjected.Address(RVA = "0x320BC80", Offset = "0x320A680", VA = "0x18320BC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public MKKHHIIAOPD FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x320BDF0", Offset = "0x320A7F0", VA = "0x18320BDF0", Slot = "4")]
			get
			{
				return default(MKKHHIIAOPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x320BD00", Offset = "0x320A700", VA = "0x18320BD00")]
		public EFADCHLKFCK(GKMJFENNOOD<T> NNIDGPDMKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x320BB70", Offset = "0x320A570", VA = "0x18320BB70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x320BC70", Offset = "0x320A670", VA = "0x18320BC70", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xC52830", Offset = "0xC51230", VA = "0x180C52830", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E68F0", Offset = "0x7E52F0", VA = "0x1807E68F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7E6410", Offset = "0x7E4E10", VA = "0x1807E6410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x303C1D0", Offset = "0x303ABD0", VA = "0x18303C1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x36B5DD0", Offset = "0x36B47D0", VA = "0x1836B5DD0")]
	public GKMJFENNOOD(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x36B5EB0", Offset = "0x36B48B0", VA = "0x1836B5EB0")]
	public GKMJFENNOOD(MKKHHIIAOPD[] KOJMOIDCENN, bool CFGOOFIDDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x36B5C90", Offset = "0x36B4690", VA = "0x1836B5C90")]
	public int PFLCPCGFOPO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x36B5920", Offset = "0x36B4320", VA = "0x1836B5920")]
	private int DGHONKFAEOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x36B5D20", Offset = "0x36B4720", VA = "0x1836B5D20", Slot = "6")]
	protected virtual uint PPOEEMPMPBC(uint LCDAKKLMACI, T FDFHGIHHGHO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x36B5B10", Offset = "0x36B4510", VA = "0x1836B5B10")]
	public bool HDJGLIAEGFK(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x36B5BB0", Offset = "0x36B45B0", VA = "0x1836B5BB0")]
	public int MIIMNLFBFLM(T FDFHGIHHGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x36B5C20", Offset = "0x36B4620", VA = "0x1836B5C20")]
	public T MMNGEILPGIO(int OJANCMLFDOJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x36B58D0", Offset = "0x36B42D0", VA = "0x1836B58D0")]
	public bool AMOFEKFEHHG(T FDFHGIHHGHO, bool DKNJCKKBPHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x36B56C0", Offset = "0x36B40C0", VA = "0x1836B56C0")]
	public bool AMOFEKFEHHG(T FDFHGIHHGHO, int OJANCMLFDOJ, bool DKNJCKKBPHD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x36B5B60", Offset = "0x36B4560", VA = "0x1836B5B60")]
	private int KGIIAENAOEC(int DAGOHCNFGEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x36B5D50", Offset = "0x36B4750", VA = "0x1836B5D50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x36B5D50", Offset = "0x36B4750", VA = "0x1836B5D50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DC13C0", Offset = "0x3DBFDC0", VA = "0x183DC13C0")]
	public static MKJAGKBNDJE<T> NOFMACCNDBH(int NOOJMJOLDPD = 0, int EOKNBDGLEMM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0E50", Offset = "0x3DBF850", VA = "0x183DC0E50")]
	public static MKJAGKBNDJE<T> AKFJOFNCOMH(int NOOJMJOLDPD = 0, int EOKNBDGLEMM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DC14A0", Offset = "0x3DBFEA0", VA = "0x183DC14A0")]
	public MKJAGKBNDJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DC14D0", Offset = "0x3DBFED0", VA = "0x183DC14D0")]
	public MKJAGKBNDJE(int NOOJMJOLDPD, int EOKNBDGLEMM = int.MaxValue, bool DFALBBJBEPP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1150", Offset = "0x3DBFB50", VA = "0x183DC1150")]
	public T FJPADMGMHOB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC12D0", Offset = "0x3DBFCD0", VA = "0x183DC12D0")]
	public void FLLAKBFBGHI(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0F30", Offset = "0x3DBF930", VA = "0x183DC0F30")]
	private void ANAGJHLGHLO(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC13A0", Offset = "0x3DBFDA0", VA = "0x183DC13A0")]
	private void NKELDGBIOAI(T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1010", Offset = "0x3DBFA10", VA = "0x183DC1010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3DC0C50", Offset = "0x3DBF650", VA = "0x183DC0C50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A91B0", Offset = "0x7A7BB0", VA = "0x1807A91B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x37167C0", Offset = "0x37151C0", VA = "0x1837167C0")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3716C90", Offset = "0x3715690", VA = "0x183716C90")]
	public bool KFIFCFIPLDK(int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x37168B0", Offset = "0x37152B0", VA = "0x1837168B0")]
	public T JCNPCPMLLNE(int PEBIBIKIFAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3716610", Offset = "0x3715010", VA = "0x183716610")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3716D00", Offset = "0x3715700", VA = "0x183716D00")]
	public bool MFCFPLHBNLD(int ODKHDABOADA, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3716D50", Offset = "0x3715750", VA = "0x183716D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x303C1D0", Offset = "0x303ABD0", VA = "0x18303C1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x398FD30", Offset = "0x398E730", VA = "0x18398FD30")]
	public bool NBEEIKJCOIK(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x398FB30", Offset = "0x398E530", VA = "0x18398FB30")]
	public void FLOHBAGDPJC(T FDFHGIHHGHO, int ODKHDABOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x398FEB0", Offset = "0x398E8B0", VA = "0x18398FEB0")]
	public bool NJHEJNEGCKN(T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3990000", Offset = "0x398EA00", VA = "0x183990000")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x398FAB0", Offset = "0x398E4B0", VA = "0x18398FAB0")]
	public T DGAGHOOFINN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x398FBD0", Offset = "0x398E5D0", VA = "0x18398FBD0")]
	private void JLKLAMILBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3990060", Offset = "0x398EA60", VA = "0x183990060")]
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
			[Cpp2IlInjected.Address(RVA = "0x5F9C060", Offset = "0x5F9AA60", VA = "0x185F9C060")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5F9C330", Offset = "0x5F9AD30", VA = "0x185F9C330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5F9C240", Offset = "0x5F9AC40", VA = "0x185F9C240")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5F9BFB0", Offset = "0x5F9A9B0", VA = "0x185F9BFB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5F9C280", Offset = "0x5F9AC80", VA = "0x185F9C280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5F9C190", Offset = "0x5F9AB90", VA = "0x185F9C190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BF20", Offset = "0x5F9A920", VA = "0x185F9BF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x41A8AB0", Offset = "0x41A74B0", VA = "0x1841A8AB0", Slot = "4")]
		public virtual T LNJJLNCAPBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 PHJAJPELCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB33720", Offset = "0xB32120", VA = "0x180B33720")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xE2FF80", Offset = "0xE2E980", VA = "0x180E2FF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 CHOKGEFPGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xE56B80", Offset = "0xE55580", VA = "0x180E56B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HHGPHMOPIKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B170", Offset = "0x5F99B70", VA = "0x185F9B170")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A9140", Offset = "0x7A7B40", VA = "0x1807A9140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int KHGKJHGCOHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FB0", Offset = "0x7B09B0", VA = "0x1807B1FB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B2160", Offset = "0x7B0B60", VA = "0x1807B2160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5F9BA90", Offset = "0x5F9A490", VA = "0x185F9BA90")]
	public OBNGKHIKIFD(Bounds MIHHAJALDDO, Vector2[] IDEIABOCHBO, int LLHDPEJKBBJ, byte DAGOHCNFGEF, float DNPJMDMPDAJ = 0f, [Optional] MKJAGKBNDJE<FLIGOANMBNO> FKAPMHCAOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B110", Offset = "0x5F99B10", VA = "0x185F9B110")]
	public FLIGOANMBNO EPBBEPBNOOH(byte OJANCMLFDOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B1F0", Offset = "0x5F99BF0", VA = "0x185F9B1F0")]
	public void IHMPCGGNHLK(Vector3 HGKJDOIPDNM, float OHEOLFGKDJO, float BCDDNDPIHDN, List<byte> IDEIMILGKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5C7C510", Offset = "0x5C7AF10", VA = "0x185C7C510")]
	public void IGMHHGGPHCI(FLIGOANMBNO.IPIIIMLOGHP NGKKEAMMCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AFC0", Offset = "0x5F999C0", VA = "0x185F9AFC0")]
	public static int APLJIJLAFDE(Vector2[] IDEIABOCHBO, int LLHDPEJKBBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B890", Offset = "0x5F9A290", VA = "0x185F9B890")]
	private FLIGOANMBNO PMMIDAKHGFN(byte OJANCMLFDOJ, FLIGOANMBNO.AEMKKDOGHKF PCHANGGJHIL, FLIGOANMBNO BBCCHMIJNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B4E0", Offset = "0x5F99EE0", VA = "0x185F9B4E0")]
	private void OCCKBAKBKHO(FLIGOANMBNO BBCCHMIJNJG, Vector2[] IDEIABOCHBO, int PDIEOELBCBA, int HCFPBHPKJKM, int ELLMANDPMKM, int AELNLDHLHAP, float DNPJMDMPDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B2C0", Offset = "0x5F99CC0", VA = "0x185F9B2C0")]
	private void OBMPJOOOBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B0B0", Offset = "0x5F99AB0", VA = "0x185F9B0B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5F9B190", Offset = "0x5F99B90", VA = "0x185F9B190", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x5F99DD0", Offset = "0x5F987D0", VA = "0x185F99DD0")]
	public FLIGOANMBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5F99990", Offset = "0x5F98390", VA = "0x185F99990")]
	public void AMKDDMPMJOF(FLIGOANMBNO NDPOCNKCALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
	public void IGMHHGGPHCI(int EHCAHFJPNBP, IPIIIMLOGHP NGKKEAMMCBG, int FNELMHIJBBO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F99AE0", Offset = "0x5F984E0", VA = "0x185F99AE0")]
	public void IHMPCGGNHLK(List<byte> IDEIMILGKJA, Vector3 HGKJDOIPDNM, float OHEOLFGKDJO, float BCDDNDPIHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5F99960", Offset = "0x5F98360", VA = "0x185F99960")]
	public bool AMHKAOBMHGP(Vector3 INKDDDGDGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5F99AB0", Offset = "0x5F984B0", VA = "0x185F99AB0")]
	public bool HFPBCBIPPND(Vector3 INKDDDGDGBD, float AOPCPDJBIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5F99D40", Offset = "0x5F98740", VA = "0x185F99D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x35B9FD0", Offset = "0x35B89D0", VA = "0x1835B9FD0")]
			public OFCAKHDMLDN(List<Component> EPNEAFACLDA, bool ICHFDDIKMIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x3F22070", Offset = "0x3F20A70", VA = "0x183F22070")]
			public BEPGOMEGGDO<T> MFONJKCHJIL()
			{
				return default(BEPGOMEGGDO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F220E0", Offset = "0x3F20AE0", VA = "0x183F220E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x3F220E0", Offset = "0x3F20AE0", VA = "0x183F220E0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x46255E0", Offset = "0x4623FE0", VA = "0x1846255E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x4625570", Offset = "0x4623F70", VA = "0x184625570", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x46255B0", Offset = "0x4623FB0", VA = "0x1846255B0")]
			public BEPGOMEGGDO(List<Component> EPNEAFACLDA, bool ICHFDDIKMIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x46254B0", Offset = "0x4623EB0", VA = "0x1846254B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x46254C0", Offset = "0x4623EC0", VA = "0x1846254C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x32B08C0", Offset = "0x32AF2C0", VA = "0x1832B08C0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DC70", Offset = "0x5F9C670", VA = "0x185F9DC70")]
		private void NGFHLNOOHDK(GameObject NMIGJPFCDKB, bool DBCFABNBIEE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DAB0", Offset = "0x5F9C4B0", VA = "0x185F9DAB0")]
		public static void NGFHLNOOHDK(GameObject NMIGJPFCDKB, ToolHierarchyCache KLBHFGGIOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x29448A0", Offset = "0x29432A0", VA = "0x1829448A0")]
		public void NIFEPKIKEBO<T>(Action<T> MCLCEMNNOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2944830", Offset = "0x2943230", VA = "0x182944830")]
		public T DHMPPGLJIIO<T>(bool ICHFDDIKMIJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2944AC0", Offset = "0x29434C0", VA = "0x182944AC0")]
		public OFCAKHDMLDN<T> NKCHHHMOMJF<T>(bool ICHFDDIKMIJ = false) where T : class
		{
			return default(OFCAKHDMLDN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D6F0", Offset = "0x5F9C0F0", VA = "0x185F9D6F0")]
		public List<Component> FLNDOCHGDBL(Type ADAMDPHPFAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F9D670", Offset = "0x5F9C070", VA = "0x185F9D670", Slot = "4")]
		public bool Equals(ToolHierarchyCache LGHEBJJLAGD, ToolHierarchyCache FGIFEPPMILE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9DA40", Offset = "0x5F9C440", VA = "0x185F9DA40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x35998A0", Offset = "0x35982A0", VA = "0x1835998A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T OBADPIAFNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3702BA0", Offset = "0x37015A0", VA = "0x183702BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T AGDDDDHKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3702CC0", Offset = "0x37016C0", VA = "0x183702CC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T KOPKFGLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3702D90", Offset = "0x3701790", VA = "0x183702D90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3702F30", Offset = "0x3701930", VA = "0x183702F30")]
	public HEPJABPCING(int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3702900", Offset = "0x3701300", VA = "0x183702900")]
	public void FLOHBAGDPJC(T OKPDMHFGNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3702EF0", Offset = "0x37018F0", VA = "0x183702EF0")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3702E20", Offset = "0x3701820", VA = "0x183702E20")]
	public void MMIOIBBDAHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x37028A0", Offset = "0x37012A0", VA = "0x1837028A0")]
	public void AEHFIAHEDHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3702E10", Offset = "0x3701810", VA = "0x183702E10")]
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
		[Cpp2IlInjected.Address(RVA = "0xEEEDE0", Offset = "0xEED7E0", VA = "0x180EEEDE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3801A90", Offset = "0x3800490", VA = "0x183801A90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool GFBKHLIEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3801AB0", Offset = "0x38004B0", VA = "0x183801AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object GDJKPHAHAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x38016F0", Offset = "0x38000F0", VA = "0x1838016F0")]
	public bool JCJIKHJCHHK(T FDFHGIHHGHO, object FACMOGNGACN, int ODKHDABOADA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3801850", Offset = "0x3800250", VA = "0x183801850")]
	public bool KFIFCFIPLDK(object FACMOGNGACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x38019D0", Offset = "0x38003D0", VA = "0x1838019D0")]
	public bool MFCFPLHBNLD(object FACMOGNGACN, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3801A60", Offset = "0x3800460", VA = "0x183801A60")]
	public void NJLBNDAIMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3801380", Offset = "0x37FFD80", VA = "0x183801380")]
	private bool FHLDKHHAFIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3801B00", Offset = "0x3800500", VA = "0x183801B00")]
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
