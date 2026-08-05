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
public class HCBGBAAADPE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x77FD00", VA = "0x180781100")]
	public HCBGBAAADPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, OOPHPIGGPLH, EBGKDFGHJKN, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DFNOHOLELKN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5690", VA = "0x1807F6A90")]
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
	[NPKDDAAFBLN]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[NPKDDAAFBLN]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5660", Offset = "0x5DE4260", VA = "0x185DE5660")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5620", Offset = "0x5DE4220", VA = "0x185DE5620")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE56A0", Offset = "0x5DE42A0", VA = "0x185DE56A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5850", Offset = "0x5DE4450", VA = "0x185DE5850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE57C0", Offset = "0x5DE43C0", VA = "0x185DE57C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8720A0", Offset = "0x870CA0", VA = "0x1808720A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9141B0", Offset = "0x912DB0", VA = "0x1809141B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE55E0", Offset = "0x5DE41E0", VA = "0x185DE55E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5730", Offset = "0x5DE4330", VA = "0x185DE5730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5050", Offset = "0x5DE3C50", VA = "0x185DE5050")]
	public void CopyBounds(SavedExtents LLMHBOEDHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5530", Offset = "0x5DE4130", VA = "0x185DE5530")]
	public void SetLocalSpaceBounds(Bounds KIBOHCGGIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x984910", Offset = "0x983510", VA = "0x180984910")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5460", Offset = "0x5DE4060", VA = "0x185DE5460")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5080", Offset = "0x5DE3C80", VA = "0x185DE5080")]
	private void NDEMJOJGABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5240", Offset = "0x5DE3E40", VA = "0x185DE5240")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49E0", Offset = "0x5DE35E0", VA = "0x185DE49E0")]
	public static void CalculateLocalBoundsFor(GameObject LCHNDEILNAI, [Out] Bounds KIBOHCGGIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5470", Offset = "0x5DE4070", VA = "0x185DE5470")]
	private static void PDPNDLCIDMJ(Bounds KNDAEONALIC, Color KIHBPBFELGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5550", Offset = "0x5DE4150", VA = "0x185DE5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77F1E0", Offset = "0x77DDE0", VA = "0x18077F1E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD3C2A0", Offset = "0xD3AEA0", VA = "0x180D3C2A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4096E10", Offset = "0x4095A10", VA = "0x184096E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public virtual void HJBAIPABFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
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
	[HCBGBAAADPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x40969F0", Offset = "0x40955F0", VA = "0x1840969F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4095690", Offset = "0x4094290", VA = "0x184095690", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4096D40", Offset = "0x4095940", VA = "0x184096D40")]
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
	private sealed class LHOCELKMOBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LHOCELKMOBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FF30", Offset = "0x3A3EB30", VA = "0x183A3FF30")]
		internal int KKNHNJLCJEO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[HCBGBAAADPE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3197590", Offset = "0x3196190", VA = "0x183197590", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31975E0", Offset = "0x31961E0", VA = "0x1831975E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3197490", Offset = "0x3196090", VA = "0x183197490", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey PPNDANAOAMK]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3197530", Offset = "0x3196130", VA = "0x183197530", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3197370", Offset = "0x3195F70", VA = "0x183197370", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3197090", Offset = "0x3195C90", VA = "0x183197090", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3196530", Offset = "0x3195130", VA = "0x183196530", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31963B0", Offset = "0x3194FB0", VA = "0x1831963B0", Slot = "14")]
	protected virtual string CKEJIGKKHIO(TKeyVal AIGEFMIBFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3196440", Offset = "0x3195040", VA = "0x183196440", Slot = "4")]
	public bool ContainsKey(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3197230", Offset = "0x3195E30", VA = "0x183197230", Slot = "5")]
	public bool TryGetValue(TKey PPNDANAOAMK, [Out] TVal GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3196490", Offset = "0x3195090", VA = "0x183196490", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3196490", Offset = "0x3195090", VA = "0x183196490", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3197280", Offset = "0x3195E80", VA = "0x183197280")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EFNAJHNIJAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IIABBELFDEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IIABBELFDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37370F0", Offset = "0x3735CF0", VA = "0x1837370F0")]
		internal bool KCJIHKGPBEA(GJOMMIPKPMO<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float JGCKMAADHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BFAABCELHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<GJOMMIPKPMO<float, T>> LENPMEJHNBH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PJAGPPFFCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3161880", Offset = "0x3160480", VA = "0x183161880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3161FF0", Offset = "0x3160BF0", VA = "0x183161FF0")]
	public EFNAJHNIJAM(float EOBFDNCHPGB, float ALMJPMNDAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x31614C0", Offset = "0x31600C0", VA = "0x1831614C0")]
	public bool DFCNADLIHNB(float OJANOJHOJAF, T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3161C00", Offset = "0x3160800", VA = "0x183161C00")]
	public IEnumerable<T> JBGBLLJBFLD(float OJANOJHOJAF, [Optional] float? BFGHECNJDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x31617E0", Offset = "0x31603E0", VA = "0x1831617E0")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3161F10", Offset = "0x3160B10", VA = "0x183161F10")]
	private void OHMLONBFEHM(float OJANOJHOJAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class FODJKKKGFJB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IJEJKPNOKLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T GMFAJOGMKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float GIIJDHHDPBD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float HEHNHFMNCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> IDIOGEFFGHM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int MGHMPMBFHJC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IJEJKPNOKLK[] DAJPKFPFPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int NDDNEGDDHPB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float MOBPODKFCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB36600", Offset = "0xB35200", VA = "0x180B36600")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB36620", Offset = "0xB35220", VA = "0x180B36620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34F3B60", Offset = "0x34F2760", VA = "0x1834F3B60")]
	public FODJKKKGFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34F3A70", Offset = "0x34F2670", VA = "0x1834F3A70")]
	public FODJKKKGFJB(int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34F3670", Offset = "0x34F2270", VA = "0x1834F3670")]
	public void HFMDKEOMMOI(float OJANOJHOJAF, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34F3130", Offset = "0x34F1D30", VA = "0x1834F3130")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x34F2E40", Offset = "0x34F1A40", VA = "0x1834F2E40")]
	public bool DMHKADGCAPC(float KDJHNGNAIOB, float BADANGAFBOC, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34F3410", Offset = "0x34F2010", VA = "0x1834F3410")]
	public bool HEJFOEBFHOA(float KDJHNGNAIOB, float BADANGAFBOC, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34F3880", Offset = "0x34F2480", VA = "0x1834F3880")]
	public void PGCGJFEMPGP(float KDJHNGNAIOB, float BADANGAFBOC, List<T> NJCBLCELFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34F2B90", Offset = "0x34F1790", VA = "0x1834F2B90")]
	private int BEIDNOFAPAF(int BOHMGNMHNNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34F39C0", Offset = "0x34F25C0", VA = "0x1834F39C0")]
	private void PIIJMMJELLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LMILKDONLJK();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T EPPEKKPEMEF(T GCPEEAODAIB, float GHKAOLMKPMN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HEPMPHFONDE(T AGIBINPMDEG, T BBPKFALMKGI);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T PHOJMIEKCEJ(T AGIBINPMDEG, T BBPKFALMKGI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OIBEBHCPOOF : FODJKKKGFJB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780590", VA = "0x180781990", Slot = "4")]
	protected override Vector3 LMILKDONLJK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4330", Offset = "0x5DE2F30", VA = "0x185DE4330", Slot = "5")]
	protected override Vector3 EPPEKKPEMEF(Vector3 GCPEEAODAIB, float GHKAOLMKPMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4370", Offset = "0x5DE2F70", VA = "0x185DE4370", Slot = "6")]
	protected override Vector3 HEPMPHFONDE(Vector3 AGIBINPMDEG, Vector3 BBPKFALMKGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DE43C0", Offset = "0x5DE2FC0", VA = "0x185DE43C0", Slot = "7")]
	protected override Vector3 PHOJMIEKCEJ(Vector3 AGIBINPMDEG, Vector3 BBPKFALMKGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4440", Offset = "0x5DE3040", VA = "0x185DE4440")]
	public OIBEBHCPOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HPNFKMJKFIH
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25228D0", Offset = "0x25214D0", VA = "0x1825228D0")]
	public static GJOMMIPKPMO<T1, T2> PAKONFKLIMF<T1, T2>(T1 HGPGDLAMOIH, T2 HGIIDMFFCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2522950", Offset = "0x2521550", VA = "0x182522950")]
	public static BFADJPEKMKC<T1, T2, T3> PAKONFKLIMF<T1, T2, T3>(T1 HGPGDLAMOIH, T2 HGIIDMFFCLJ, T3 LMFPKBCMCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8E70", Offset = "0x3CE7A70", VA = "0x183CE8E70")]
	internal static int EHOLCCMKLBL(int FCIPHCNBDFG, int IBLGCCCFKJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52B39F0", Offset = "0x52B25F0", VA = "0x1852B39F0")]
	internal static int EHOLCCMKLBL(int FCIPHCNBDFG, int IBLGCCCFKJA, int GHCKIKMKMFB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GJOMMIPKPMO<T1, T2> : IComparable<GJOMMIPKPMO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 PDMDNGIEPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 GCDOCOOMGEB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x35C9850", Offset = "0x35C8450", VA = "0x1835C9850")]
	public GJOMMIPKPMO(T1 HGPGDLAMOIH, T2 HGIIDMFFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x35C7A50", Offset = "0x35C6650", VA = "0x1835C7A50", Slot = "4")]
	public int CompareTo(GJOMMIPKPMO<T1, T2> LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x35C7F30", Offset = "0x35C6B30", VA = "0x1835C7F30", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x35C8B00", Offset = "0x35C7700", VA = "0x1835C8B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x35C94F0", Offset = "0x35C80F0", VA = "0x1835C94F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BFADJPEKMKC<T1, T2, T3> : IComparable<BFADJPEKMKC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 PDMDNGIEPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 GCDOCOOMGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 ALLBKDOBKPF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x458CEC0", Offset = "0x458BAC0", VA = "0x18458CEC0")]
	public BFADJPEKMKC(T1 HGPGDLAMOIH, T2 HGIIDMFFCLJ, T3 LMFPKBCMCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x458C580", Offset = "0x458B180", VA = "0x18458C580", Slot = "4")]
	public int CompareTo(BFADJPEKMKC<T1, T2, T3> LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x458C910", Offset = "0x458B510", VA = "0x18458C910", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x458CB50", Offset = "0x458B750", VA = "0x18458CB50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x458CD00", Offset = "0x458B900", VA = "0x18458CD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F250C0", Offset = "0x1F23CC0", VA = "0x181F250C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F25210", Offset = "0x1F23E10", VA = "0x181F25210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HKPDNLFGKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80DA90", Offset = "0x80C690", VA = "0x18080DA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x42A60F0", Offset = "0x42A4CF0", VA = "0x1842A60F0")]
	public T AKNDEIEADBJ(float GHKAOLMKPMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x42A6400", Offset = "0x42A5000", VA = "0x1842A6400")]
	public T KLLJMJMIOJN(float GHKAOLMKPMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LMNCKEHFKLB(T AGIBINPMDEG, T BBPKFALMKGI, float GHKAOLMKPMN);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C40", Offset = "0x5DE1840", VA = "0x185DE2C40", Slot = "4")]
	protected override float LMNCKEHFKLB(float AGIBINPMDEG, float BBPKFALMKGI, float GHKAOLMKPMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C80", Offset = "0x5DE1880", VA = "0x185DE2C80")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC35C40", Offset = "0xC34840", VA = "0x180C35C40", Slot = "4")]
	protected override Vector3 LMNCKEHFKLB(Vector3 AGIBINPMDEG, Vector3 BBPKFALMKGI, float GHKAOLMKPMN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6670", Offset = "0x5DE5270", VA = "0x185DE6670")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1590", Offset = "0x5DE0190", VA = "0x185DE1590", Slot = "4")]
	protected override Color LMNCKEHFKLB(Color AGIBINPMDEG, Color BBPKFALMKGI, float GHKAOLMKPMN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1650", Offset = "0x5DE0250", VA = "0x185DE1650")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GFNGPENMGOC : FCLGKLICGIB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2D30", Offset = "0x5DE1930", VA = "0x185DE2D30")]
	public GFNGPENMGOC(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2CC0", Offset = "0x5DE18C0", VA = "0x185DE2CC0", Slot = "6")]
	protected override uint AKANHAHCOMN(uint DFNOHOLELKN, string GCPEEAODAIB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KNFDEKBBLCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KNFDEKBBLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IDGELGOGCOD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MDGHMFPBPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ODJMAGJNNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int AOGKPPKBNEB;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3711760", Offset = "0x3710360", VA = "0x183711760")]
	private IDGELGOGCOD(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LHFLJBPJHIK, int EGBIDHOILED, int CKPPKACNFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3711660", Offset = "0x3710260", VA = "0x183711660")]
	public static IDGELGOGCOD<T> OOMHMBNJBCG()
	{
		return default(IDGELGOGCOD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3710FA0", Offset = "0x370FBA0", VA = "0x183710FA0")]
	public (int, int, Task<T>) NDGNMEPCIHP(int IDHFNKBLHKA, [Optional] CancellationToken BJFJMBIBKLL, double FOGEGHJNDKP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x370FE90", Offset = "0x370EA90", VA = "0x18370FE90")]
	public void HKEJFFBIHKE(int IDHFNKBLHKA, int CKPPKACNFNF, [In] T HNCONAMCFGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class OCEMGPJEPFC
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE40A0", Offset = "0x5DE2CA0", VA = "0x185DE40A0")]
	public static IDGELGOGCOD<JNKPKLDONNF> OOMHMBNJBCG()
	{
		return default(IDGELGOGCOD<JNKPKLDONNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4020", Offset = "0x5DE2C20", VA = "0x185DE4020")]
	public static void HKEJFFBIHKE([In] this IDGELGOGCOD<JNKPKLDONNF> HHHLENOMLMP, int IDHFNKBLHKA, int CKPPKACNFNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class IOALBOALGGP<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> EFKALIEABBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> EMKCFCCGLDD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F86040", Offset = "0x2F84C40", VA = "0x182F86040", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool GNNIBHGIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> BJKBPODNNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x371F9C0", Offset = "0x371E5C0", VA = "0x18371F9C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> JJJPEOBCNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x374FF00", Offset = "0x374EB00", VA = "0x18374FF00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x374FEA0", Offset = "0x374EAA0", VA = "0x18374FEA0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x374FF60", Offset = "0x374EB60", VA = "0x18374FF60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x374F390", Offset = "0x374DF90", VA = "0x18374F390")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x374F3E0", Offset = "0x374DFE0", VA = "0x18374F3E0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x374FC80", Offset = "0x374E880", VA = "0x18374FC80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x374F100", Offset = "0x374DD00", VA = "0x18374F100", Slot = "9")]
	public void Add(TKey PPNDANAOAMK, TVal GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x374F150", Offset = "0x374DD50", VA = "0x18374F150", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x374F440", Offset = "0x374E040", VA = "0x18374F440", Slot = "8")]
	public bool ContainsKey(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x374F480", Offset = "0x374E080", VA = "0x18374F480", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x374FBD0", Offset = "0x374E7D0", VA = "0x18374FBD0", Slot = "10")]
	public bool Remove(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x374FBA0", Offset = "0x374E7A0", VA = "0x18374FBA0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x374FD20", Offset = "0x374E920", VA = "0x18374FD20", Slot = "11")]
	public bool TryGetValue(TKey PPNDANAOAMK, [Out] TVal GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x374F590", Offset = "0x374E190", VA = "0x18374F590", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x374F510", Offset = "0x374E110", VA = "0x18374F510", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DAJPKFPFPMI, int DOCPNNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x374F8D0", Offset = "0x374E4D0", VA = "0x18374F8D0")]
	public bool IKGDLKABABA(TVal PPNDANAOAMK, [Out] TKey GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x374F6C0", Offset = "0x374E2C0", VA = "0x18374F6C0")]
	private void IADDIGOKENE(TKey PPNDANAOAMK, TVal FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x374F210", Offset = "0x374DE10", VA = "0x18374F210")]
	private void CINKGADJKKK(TKey PPNDANAOAMK, TVal FEGNLFKFNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x374F920", Offset = "0x374E520", VA = "0x18374F920")]
	private bool MOLCOPJNLBD(TKey PPNDANAOAMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x374FD60", Offset = "0x374E960", VA = "0x18374FD60")]
	public IOALBOALGGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class EDLEEJIAANP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private EDLEEJIAANP<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x31F1C00", Offset = "0x31F0800", VA = "0x1831F1C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x31F2720", Offset = "0x31F1320", VA = "0x1831F2720")]
		public Enumerator(EDLEEJIAANP<T> NJCBLCELFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x31EFC90", Offset = "0x31EE890", VA = "0x1831EFC90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x31F04C0", Offset = "0x31EF0C0", VA = "0x1831F04C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x31EE3A0", Offset = "0x31ECFA0", VA = "0x1831EE3A0")]
		private void KIGNNKJCDGD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] OMHOHOBDCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int EJAHPHIIAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int JKOPJIOIBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int DLBBNPMBKBG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3157260", Offset = "0x3155E60", VA = "0x183157260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3157210", Offset = "0x3155E10", VA = "0x183157210")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3157CD0", Offset = "0x31568D0", VA = "0x183157CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x31584B0", Offset = "0x31570B0", VA = "0x1831584B0")]
	public EDLEEJIAANP(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3157450", Offset = "0x3156050", VA = "0x183157450")]
	public void HFMDKEOMMOI(T GHKAOLMKPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x31572A0", Offset = "0x3155EA0", VA = "0x1831572A0")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x31575F0", Offset = "0x31561F0", VA = "0x1831575F0")]
	public void HHCNIKANJOJ(int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x31581C0", Offset = "0x3156DC0", VA = "0x1831581C0")]
	public void OMHHIGKMMEM(T[] DAJPKFPFPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x31576A0", Offset = "0x31562A0", VA = "0x1831576A0")]
	public Enumerator IFFPMJIPELE()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3158330", Offset = "0x3156F30", VA = "0x183158330", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3158330", Offset = "0x3156F30", VA = "0x183158330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3157750", Offset = "0x3156350", VA = "0x183157750")]
	private int KHCFJJBDODN(int DCGGFHOCGGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3157D40", Offset = "0x3156940", VA = "0x183157D40")]
	private int OILMJMEDGAP(int DCGGFHOCGGH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class JNBJMBCEEHI<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> HNOCIHKBLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> ALFGCABNDNK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x391D520", Offset = "0x391C120", VA = "0x18391D520", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x391D4D0", Offset = "0x391C0D0", VA = "0x18391D4D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public JNBJMBCEEHI(Func<Internal, External> HNOCIHKBLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x391D480", Offset = "0x391C080", VA = "0x18391D480")]
	public JNBJMBCEEHI(IReadOnlyList<Internal> ALFGCABNDNK, Func<Internal, External> HNOCIHKBLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x391D400", Offset = "0x391C000", VA = "0x18391D400", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x330EF50", Offset = "0x330DB50", VA = "0x18330EF50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FPEKHKNBNHH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> HBDMMLJMCED(TRequest NFAAJOAMBMN, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum IDOAMGHNECE
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ICIJLKCIAJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float GOGDIFKNDGO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan LGEAFNJGNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int GPNJJIEJJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public IDOAMGHNECE IMNEFHDJCNI;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly ICIJLKCIAJH IJJIHHKLCNA;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LOIHMEOLODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x370F420", Offset = "0x370E020", VA = "0x18370F420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan ILAAFBCPJBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x370F650", Offset = "0x370E250", VA = "0x18370F650")]
		public ICIJLKCIAJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct HEHCNPDLKLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest NFAAJOAMBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken BJFJMBIBKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> ENLKJJMCJCI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3638150", Offset = "0x3636D50", VA = "0x183638150")]
		public HEHCNPDLKLH(TRequest NFAAJOAMBMN, TaskCompletionSource<TResult> ENLKJJMCJCI, CancellationToken BJFJMBIBKLL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IOKMEHGGBGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public FPEKHKNBNHH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x37517E0", Offset = "0x37503E0", VA = "0x1837517E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3751C80", Offset = "0x3750880", VA = "0x183751C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct HGOFIDDAAKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public FPEKHKNBNHH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HEHCNPDLKLH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3668380", Offset = "0x3666F80", VA = "0x183668380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x36689E0", Offset = "0x36675E0", VA = "0x1836689E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource LEJBJKEJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<HEHCNPDLKLH> HALJFDFFDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly ICIJLKCIAJH IMAGAHOBDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HBDMMLJMCED PDDMLACNFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task BKBLJIBDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int PPBLEBPLNJP;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x34F82F0", Offset = "0x34F6EF0", VA = "0x1834F82F0")]
	public FPEKHKNBNHH(HBDMMLJMCED PDDMLACNFPF, [Optional] ICIJLKCIAJH IMAGAHOBDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x34F6F00", Offset = "0x34F5B00", VA = "0x1834F6F00")]
	public Task<TResult> EGIMEBOOMCN(TRequest NFAAJOAMBMN, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x34F7E00", Offset = "0x34F6A00", VA = "0x1834F7E00")]
	private void NOIIMBKIHEM(HEHCNPDLKLH NNBABPFJIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34F70F0", Offset = "0x34F5CF0", VA = "0x1834F70F0")]
	[AsyncStateMachine(typeof(FPEKHKNBNHH<, >.IOKMEHGGBGP))]
	private Task EJFIMDOGBHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34F7610", Offset = "0x34F6210", VA = "0x1834F7610")]
	private HEHCNPDLKLH GJFCLELDPMA()
	{
		return default(HEHCNPDLKLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34F6980", Offset = "0x34F5580", VA = "0x1834F6980")]
	[AsyncStateMachine(typeof(FPEKHKNBNHH<, >.HGOFIDDAAKC))]
	private Task CGCOIDCCEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x34F7B30", Offset = "0x34F6730", VA = "0x1834F7B30")]
	private void GMJKAMDDAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x34F6A70", Offset = "0x34F5670", VA = "0x1834F6A70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class JFELHIOPEFH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> ALFGCABNDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> LAGBOIHOOAG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F86040", Offset = "0x2F84C40", VA = "0x182F86040", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GNNIBHGIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x38EC5A0", Offset = "0x38EB1A0", VA = "0x1838EC5A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x38EC5E0", Offset = "0x38EB1E0", VA = "0x1838EC5E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x350BF50", Offset = "0x350AB50", VA = "0x18350BF50", Slot = "11")]
	public void Add(T KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x38EC000", Offset = "0x38EAC00", VA = "0x1838EC000")]
	public bool NHIIPPMFJOI(T KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x38EC370", Offset = "0x38EAF70", VA = "0x1838EC370", Slot = "15")]
	public bool Remove(T KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x38EBD60", Offset = "0x38EA960", VA = "0x1838EBD60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3471390", Offset = "0x346FF90", VA = "0x183471390", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x38EBC90", Offset = "0x38EA890", VA = "0x1838EBC90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x38EBCF0", Offset = "0x38EA8F0", VA = "0x1838EBCF0", Slot = "13")]
	public bool Contains(T KADOGPFLCFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x38EBD30", Offset = "0x38EA930", VA = "0x1838EBD30", Slot = "14")]
	public void CopyTo(T[] DAJPKFPFPMI, int DOCPNNGFPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x38EBDF0", Offset = "0x38EA9F0", VA = "0x1838EBDF0", Slot = "6")]
	public int IndexOf(T KADOGPFLCFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x38EBE40", Offset = "0x38EAA40", VA = "0x1838EBE40", Slot = "7")]
	public void Insert(int DCGGFHOCGGH, T KADOGPFLCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x38EC180", Offset = "0x38EAD80", VA = "0x1838EC180", Slot = "8")]
	public void RemoveAt(int DCGGFHOCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x38EC4B0", Offset = "0x38EB0B0", VA = "0x1838EC4B0")]
	public JFELHIOPEFH()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2058420", Offset = "0x2057020", VA = "0x182058420")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5BF0", Offset = "0x5DE47F0", VA = "0x185DE5BF0")]
		public SerializedGuid([In] Guid OGCEPACDHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE58E0", Offset = "0x5DE44E0", VA = "0x185DE58E0")]
		public static SerializedGuid CKKOPOFMIEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5A60", Offset = "0x5DE4660", VA = "0x185DE5A60")]
		public static SerializedGuid GNBOHOHEFGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5B90", Offset = "0x5DE4790", VA = "0x185DE5B90")]
		public bool PJGJGCEHBMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5B60", Offset = "0x5DE4760", VA = "0x185DE5B60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5AE0", Offset = "0x5DE46E0", VA = "0x185DE5AE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5990", Offset = "0x5DE4590", VA = "0x185DE5990", Slot = "7")]
		public bool Equals(SerializedGuid LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE59D0", Offset = "0x5DE45D0", VA = "0x185DE59D0", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5AD0", Offset = "0x5DE46D0", VA = "0x185DE5AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5960", Offset = "0x5DE4560", VA = "0x185DE5960", Slot = "6")]
		public int CompareTo(SerializedGuid LLMHBOEDHFP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EPPDBCMONGK : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type GPJDFKDMNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string JJIHDBFANBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool GIBMIAOLJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool CHIIEGOEJFP;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A80", Offset = "0x5DE1680", VA = "0x185DE2A80")]
	public EPPDBCMONGK(Type KKIMBDGOCDA, string IIJALNEBBMD, bool ALJMDDEAPBO = false, bool GFNKLAHCICH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FIKFBEICCGA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct NLLLJHEEBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long AMAMJACJPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long AJDCOEEDAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int KPLIMFMEEIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int KKPGKJDNNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool OGINKCJPOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string HAANHPOPICE;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D26AF0", Offset = "0x3D256F0", VA = "0x183D26AF0")]
		public NLLLJHEEBIL(long AMAMJACJPLF, int KPLIMFMEEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3D26B60", Offset = "0x3D25760", VA = "0x183D26B60")]
		public NLLLJHEEBIL(long AMAMJACJPLF, long AJDCOEEDAAF, int KPLIMFMEEIB, int KKPGKJDNNOA, bool OGINKCJPOFG, string HAANHPOPICE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A20", Offset = "0x3D25620", VA = "0x183D26A20")]
		public int HFJHAOGCOGI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A70", Offset = "0x3D25670", VA = "0x183D26A70")]
		public int IIDIIEFFJMK(int OGGIOLPINOL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3D26A90", Offset = "0x3D25690", VA = "0x183D26A90")]
		public double NNKOLMDPNJD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D26980", Offset = "0x3D25580", VA = "0x183D26980")]
		public NLLLJHEEBIL FFHMFODPDFA(long AJDCOEEDAAF, int KKPGKJDNNOA)
		{
			return default(NLLLJHEEBIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class DJKJOCCHFDH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct OGLGLMDDBGP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public DJKJOCCHFDH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<DJKJOCCHFDH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private DJKJOCCHFDH <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3DF0120", Offset = "0x3DEED20", VA = "0x183DF0120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x35BB4E0", Offset = "0x35BA0E0", VA = "0x1835BB4E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey PLLFMAPAGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly FIKFBEICCGA<TKey> AEIJEHEMJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly ELHKCOAEACJ CABFMJIIGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<DJKJOCCHFDH> CJBKAGMIEOE;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string BFLOIPHFJAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x4E48B40", Offset = "0x4E47740", VA = "0x184E48B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<DJKJOCCHFDH> JDAJBCIPDMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4E488E0", Offset = "0x4E474E0", VA = "0x184E488E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public NLLLJHEEBIL LDNKJFHJAPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4E48920", Offset = "0x4E47520", VA = "0x184E48920")]
			[CompilerGenerated]
			get
			{
				return default(NLLLJHEEBIL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x4E488B0", Offset = "0x4E474B0", VA = "0x184E488B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E48CD0", Offset = "0x4E478D0", VA = "0x184E48CD0")]
		internal DJKJOCCHFDH(FIKFBEICCGA<TKey> AEIJEHEMJFD, TKey PPNDANAOAMK, ELHKCOAEACJ CABFMJIIGKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4E48B70", Offset = "0x4E47770", VA = "0x184E48B70")]
		public DJKJOCCHFDH KLIAKGJKIMN(TKey PPNDANAOAMK, [Optional] ELHKCOAEACJ? JLMEKOFJMLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D2FEE0", Offset = "0x2D2EAE0", VA = "0x182D2FEE0")]
		[AsyncStateMachine(typeof(OGLGLMDDBGP<>))]
		public Task<T> COJCKKENBHI<T>(TKey PPNDANAOAMK, Func<DJKJOCCHFDH, Task<T>> CPCNABCMKCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4E48940", Offset = "0x4E47540", VA = "0x184E48940", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class PICDCJIDMMM : IEnumerable<(TKey, List<TKey>, NLLLJHEEBIL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NLLLJHEEBIL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, NLLLJHEEBIL timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public FIKFBEICCGA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, NLLLJHEEBIL timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, NLLLJHEEBIL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x204F350", Offset = "0x204DF50", VA = "0x18204F350", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NLLLJHEEBIL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3E9F170", Offset = "0x3E9DD70", VA = "0x183E9F170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x204F440", Offset = "0x204E040", VA = "0x18204F440")]
		[DebuggerHidden]
		public PICDCJIDMMM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3309B10", Offset = "0x3308710", VA = "0x183309B10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E9ECC0", Offset = "0x3E9D8C0", VA = "0x183E9ECC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E9EC70", Offset = "0x3E9D870", VA = "0x183E9EC70")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F120", Offset = "0x3E9DD20", VA = "0x183E9F120", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F060", Offset = "0x3E9DC60", VA = "0x183E9F060", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NLLLJHEEBIL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x316D870", Offset = "0x316C470", VA = "0x18316D870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DHDCBKNJEGK : IEnumerable<(TKey, List<TKey>, NLLLJHEEBIL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NLLLJHEEBIL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, NLLLJHEEBIL timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private DJKJOCCHFDH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DJKJOCCHFDH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FIKFBEICCGA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<DJKJOCCHFDH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, NLLLJHEEBIL timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, NLLLJHEEBIL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x204F350", Offset = "0x204DF50", VA = "0x18204F350", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NLLLJHEEBIL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4E3BB10", Offset = "0x4E3A710", VA = "0x184E3BB10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x204F440", Offset = "0x204E040", VA = "0x18204F440")]
		[DebuggerHidden]
		public DHDCBKNJEGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BB70", Offset = "0x4E3A770", VA = "0x184E3BB70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B230", Offset = "0x4E39E30", VA = "0x184E3B230", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B1D0", Offset = "0x4E39DD0", VA = "0x184E3B1D0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B170", Offset = "0x4E39D70", VA = "0x184E3B170")]
		private void HAIPFOFCHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4E3BAC0", Offset = "0x4E3A6C0", VA = "0x184E3BAC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4E3B9E0", Offset = "0x4E3A5E0", VA = "0x184E3B9E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NLLLJHEEBIL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x40B3E20", Offset = "0x40B2A20", VA = "0x1840B3E20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, NLLLJHEEBIL, ELHKCOAEACJ> FNHHDDHMLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, NLLLJHEEBIL, ELHKCOAEACJ> BFLAGPIMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<FIKFBEICCGA<TKey>, ELHKCOAEACJ> EMLLFBBKBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ELHKCOAEACJ CABFMJIIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly DJKJOCCHFDH DMBAMIMFELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool OCFIKJIDDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int DFJEGOPFJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch KBIHEFNJGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int KJICBCHOHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string MHMCAKMFICA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DJKJOCCHFDH JNKCOOCCAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string BFLOIPHFJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x34E2DC0", Offset = "0x34E19C0", VA = "0x1834E2DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34E2F80", Offset = "0x34E1B80", VA = "0x1834E2F80")]
	public FIKFBEICCGA(TKey FFFCMDLGGFG, ELHKCOAEACJ CABFMJIIGKB, [Optional] int? KPLIMFMEEIB, [Optional][CanBeNull] Stopwatch KBIHEFNJGHG, [Optional] Action<TKey, NLLLJHEEBIL, ELHKCOAEACJ> FNHHDDHMLML, [Optional] Action<TKey, NLLLJHEEBIL, ELHKCOAEACJ> BFLAGPIMIMN, [Optional] Action<FIKFBEICCGA<TKey>, ELHKCOAEACJ> EMLLFBBKBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34E2CB0", Offset = "0x34E18B0", VA = "0x1834E2CB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34E2E20", Offset = "0x34E1A20", VA = "0x1834E2E20")]
	[IteratorStateMachine(typeof(FIKFBEICCGA<>.PICDCJIDMMM))]
	public IEnumerable<(TKey, List<TKey>, NLLLJHEEBIL)> JNJGNNMCCBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34E2EB0", Offset = "0x34E1AB0", VA = "0x1834E2EB0")]
	[IteratorStateMachine(typeof(FIKFBEICCGA<>.DHDCBKNJEGK))]
	private IEnumerable<(TKey, List<TKey>, NLLLJHEEBIL)> JNJGNNMCCBH(List<TKey> ELOBOAALAAG, DJKJOCCHFDH LKDDMBOJIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34E2D40", Offset = "0x34E1940", VA = "0x1834E2D40")]
	private (long, int) HDMGKLJLNIB()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class BEMFLAIOEMH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NJCELAICDHA(FIKFBEICCGA<TKey> AEIJEHEMJFD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected BEMFLAIOEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class DFPJOGLIDCG<TKey> : BEMFLAIOEMH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string LBGFFOANEBM(TKey PPNDANAOAMK);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4E37AE0", Offset = "0x4E366E0", VA = "0x184E37AE0")]
	private static string KCEDJCDOLJE(TKey PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4E37C70", Offset = "0x4E36870", VA = "0x184E37C70", Slot = "4")]
	public override string NJCELAICDHA(FIKFBEICCGA<TKey> AEIJEHEMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4E37B20", Offset = "0x4E36720", VA = "0x184E37B20")]
	public string NJCELAICDHA(FIKFBEICCGA<TKey> AEIJEHEMJFD, [NotNull] LBGFFOANEBM LLBFGHGFPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KNCFMKFJAJJ(FIKFBEICCGA<TKey> AEIJEHEMJFD, [NotNull] LBGFFOANEBM LLBFGHGFPGH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3737D50", Offset = "0x3736950", VA = "0x183737D50")]
	protected DFPJOGLIDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GMJOCCDGNAM<TKey> : BEMFLAIOEMH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string JANBEDBABOL(TKey PPNDANAOAMK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string NBOMOIBPOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double LKIPDADDOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool MBJABMJKBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int JDKGHBABDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> KFAGPJDHKGN;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x35D5310", Offset = "0x35D3F10", VA = "0x1835D5310")]
	private static string KCEDJCDOLJE(TKey PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x35D5D20", Offset = "0x35D4920", VA = "0x1835D5D20")]
	public GMJOCCDGNAM(string NBOMOIBPOIM = "F2", double LKIPDADDOIF = double.MaxValue, bool MBJABMJKBBM = false, int JDKGHBABDNO = int.MaxValue, [Optional] ISet<string> KFAGPJDHKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35D5A20", Offset = "0x35D4620", VA = "0x1835D5A20", Slot = "4")]
	public override Dictionary<string, string> NJCELAICDHA(FIKFBEICCGA<TKey> AEIJEHEMJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35D5350", Offset = "0x35D3F50", VA = "0x1835D5350")]
	private bool KELNBBAPKNH(string KICEKCLGKNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x35D5430", Offset = "0x35D4030", VA = "0x1835D5430")]
	public Dictionary<string, string> NJCELAICDHA(FIKFBEICCGA<TKey> AEIJEHEMJFD, JANBEDBABOL LLBFGHGFPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x35D5AE0", Offset = "0x35D46E0", VA = "0x1835D5AE0")]
	private string OHBMACPBAFF(StringBuilder FNJLOJEEBJM, List<TKey> FEGCFOPHCNF, JANBEDBABOL LLBFGHGFPGH, bool OAJEPDFEDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x35D51B0", Offset = "0x35D3DB0", VA = "0x1835D51B0")]
	private static void GJAAKFIPDPD(StringBuilder LEFHBAEFLEC, string PKBLIIAICBB, bool NGGLNINDFNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DMPHFDONMEI<TKey> : DFPJOGLIDCG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FPIGAHPEGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public LBGFFOANEBM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static DMPHFDONMEI<TKey> IDAIJJLMAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] GFCIDFEJOJO;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E533F0", Offset = "0x4E51FF0", VA = "0x184E533F0")]
	private DMPHFDONMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4E52480", Offset = "0x4E51080", VA = "0x184E52480", Slot = "5")]
	protected override string KNCFMKFJAJJ(FIKFBEICCGA<TKey> AEIJEHEMJFD, LBGFFOANEBM LLBFGHGFPGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4E52390", Offset = "0x4E50F90", VA = "0x184E52390")]
	[CompilerGenerated]
	internal static string BHKFCJEHPKP(string LKOHBLBAJMG, TKey PPNDANAOAMK, FPIGAHPEGLM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class KDDCDIFGDNG : FIKFBEICCGA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class NHBKHOBLFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<KDDCDIFGDNG, ELHKCOAEACJ> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NHBKHOBLFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3F90", Offset = "0x5DE2B90", VA = "0x185DE3F90")]
		internal void KMEJBNIFHND(FIKFBEICCGA<string> timer, ELHKCOAEACJ log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3040", Offset = "0x5DE1C40", VA = "0x185DE3040")]
	public KDDCDIFGDNG(ELHKCOAEACJ CABFMJIIGKB, [Optional] string KEFPHPMAIEP, [Optional] int? KPLIMFMEEIB, [Optional] Stopwatch KBIHEFNJGHG, [Optional] Action<string, NLLLJHEEBIL, ELHKCOAEACJ> FNHHDDHMLML, [Optional] Action<string, NLLLJHEEBIL, ELHKCOAEACJ> BFLAGPIMIMN, [Optional] Action<KDDCDIFGDNG, ELHKCOAEACJ> EMLLFBBKBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2F80", Offset = "0x5DE1B80", VA = "0x185DE2F80")]
	private static Action<FIKFBEICCGA<string>, ELHKCOAEACJ> PMNAJCEFNGG(Action<KDDCDIFGDNG, ELHKCOAEACJ> FCFEFDOJHCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class BPMFLNLFFPN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class FFBMHHLHAOM : BPMFLNLFFPN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static BPMFLNLFFPN IDAIJJLMAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2AF0", Offset = "0x5DE16F0", VA = "0x185DE2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float CPBGANIIHJG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C9F660", Offset = "0x1C9E260", VA = "0x181C9F660", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2BF0", Offset = "0x5DE17F0", VA = "0x185DE2BF0")]
		public FFBMHHLHAOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static BPMFLNLFFPN JHBBAIDGPKI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static BPMFLNLFFPN IJJIHHKLCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0EF0", Offset = "0x5DDFAF0", VA = "0x185DE0EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float CPBGANIIHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected BPMFLNLFFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JBJBPBJOGFG : DHPBCHFMIPI<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2F40", Offset = "0x5DE1B40", VA = "0x185DE2F40")]
	public JBJBPBJOGFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DHPBCHFMIPI<T> : CFFLLKAPPEH<T>, IDOFDFPIDEF, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> DABJJELJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HPJLJGHAIKN<T> DGHEKEOJAHE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4E447E0", Offset = "0x4E433E0", VA = "0x184E447E0")]
	public DHPBCHFMIPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CAFDPHMLFPE<T> : CFFLLKAPPEH<T>, IDOFDFPIDEF, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> DABJJELJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public HPJLJGHAIKN<T> DGHEKEOJAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x487C130", Offset = "0x487AD30", VA = "0x18487C130")]
	public CAFDPHMLFPE(Exception PFNPJMEIKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IDOFDFPIDEF : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CFFLLKAPPEH<T> : IDOFDFPIDEF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> DABJJELJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	HPJLJGHAIKN<T> DGHEKEOJAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class GHGHLJJHCMG
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool NNMONLKGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2DE0", Offset = "0x5DE19E0", VA = "0x185DE2DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2D80", Offset = "0x5DE1980", VA = "0x185DE2D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2E30", Offset = "0x5DE1A30", VA = "0x185DE2E30")]
	static GHGHLJJHCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	protected GHGHLJJHCMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class FAFMALAAOIL<TTask, T> : GHGHLJJHCMG, CFFLLKAPPEH<T>, IDOFDFPIDEF, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class GOBBDICKKNF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public GOBBDICKKNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2F76F30", Offset = "0x2F75B30", VA = "0x182F76F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F77200", Offset = "0x2F75E00", VA = "0x182F77200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public FAFMALAAOIL<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public GOBBDICKKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x35DBE20", Offset = "0x35DAA20", VA = "0x1835DBE20")]
		[AsyncStateMachine(typeof(FAFMALAAOIL<, >.GOBBDICKKNF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NNNCCENBLFN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> IMKPJBJJCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource OEDMIHFDIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool OCFIKJIDDDB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> DABJJELJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HPJLJGHAIKN<T> DGHEKEOJAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CBOMGKLCBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x853290", Offset = "0x851E90", VA = "0x180853290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x34C5A40", Offset = "0x34C4640", VA = "0x1834C5A40")]
	protected FAFMALAAOIL(TTask IMKPJBJJCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x34C5800", Offset = "0x34C4400", VA = "0x1834C5800", Slot = "1")]
	~FAFMALAAOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x34C57E0", Offset = "0x34C43E0", VA = "0x1834C57E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34C5670", Offset = "0x34C4270", VA = "0x1834C5670")]
	private void BAMMMHDNJPA(bool IMHBHODMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T DJLNAPPFPFF(TTask OGJFCBIIEGK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void OLFDBKPBMOD();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CFAMPMNKDFM
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE14B0", Offset = "0x5DE00B0", VA = "0x185DE14B0")]
	[NotNull]
	public static byte[] PGPGLOKFBHO(this OOPHPIGGPLH HCHHJFMNBPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1520", Offset = "0x5DE0120", VA = "0x185DE1520")]
	[NotNull]
	public static byte[] PGPGLOKFBHO(this OOPHPIGGPLH HCHHJFMNBPI, HashAlgorithmName LDGNGEMOMLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1200", Offset = "0x5DDFE00", VA = "0x185DE1200")]
	public static bool DKBECIKJFOB([CanBeNull] this OOPHPIGGPLH HCHHJFMNBPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1060", Offset = "0x5DDFC60", VA = "0x185DE1060")]
	public static bool DKBECIKJFOB([CanBeNull] this OOPHPIGGPLH HCHHJFMNBPI, [Out] string GNLAGDDNMDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1390", Offset = "0x5DDFF90", VA = "0x185DE1390")]
	private static bool NAKFLNBEFDM([NotNull] OOPHPIGGPLH HCHHJFMNBPI, [Out][CanBeNull] byte[] MPECILGEACN, [Out][CanBeNull] byte[] FAMIJPNBJCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OHPLDGKDJED
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DE40F0", Offset = "0x5DE2CF0", VA = "0x185DE40F0")]
	[NotNull]
	public static byte[] PGPGLOKFBHO(this EBGKDFGHJKN GOPBMFLJLNH, HashAlgorithmName LDGNGEMOMLF, byte[] LMHLHDKHONF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface EBGKDFGHJKN
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DFNOHOLELKN);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OOPHPIGGPLH : EBGKDFGHJKN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] OMNDDGJEDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] DGHMJNNHAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MEMDKPFEGLD
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> OBOMCGMHGLE;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool KPJOJPOCHBE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A40", Offset = "0x5DE2640", VA = "0x185DE3A40")]
	public static void MDMIJKJIIEC(this IncrementalHash NIJBJOGHNBM, [CanBeNull] GameObject LCHNDEILNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x258B300", Offset = "0x2589F00", VA = "0x18258B300")]
	public static void MDMIJKJIIEC<T>(this IncrementalHash NIJBJOGHNBM, [CanBeNull] T FNLDGAFEDDH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x258AC40", Offset = "0x2589840", VA = "0x18258AC40")]
	public static void AAIJOOIFKPA<T>(this IncrementalHash NIJBJOGHNBM, [CanBeNull] T GOPBMFLJLNH) where T : EBGKDFGHJKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x258B3C0", Offset = "0x2589FC0", VA = "0x18258B3C0")]
	public static void PKHJDEPINBK<T>(this IncrementalHash NIJBJOGHNBM, [CanBeNull] IList<T> CDFDCLPNJJP) where T : EBGKDFGHJKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3610", Offset = "0x5DE2210", VA = "0x185DE3610")]
	private static bool KEJDKDCIKGK([CanBeNull] EBGKDFGHJKN GOPBMFLJLNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3270", Offset = "0x5DE1E70", VA = "0x185DE3270")]
	public static void DPLKOMCANKL(this IncrementalHash DFNOHOLELKN, [CanBeNull] string MFCGKJMCFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3870", Offset = "0x5DE2470", VA = "0x185DE3870")]
	public static void LONNJFDICJL(this IncrementalHash DFNOHOLELKN, long EANHMIJLFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE36A0", Offset = "0x5DE22A0", VA = "0x185DE36A0")]
	public static void LMCHHNHHOMD(this IncrementalHash DFNOHOLELKN, int FIJANOHJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32D0", Offset = "0x5DE1ED0", VA = "0x185DE32D0")]
	public static void EDODCMIBDCN(this IncrementalHash DFNOHOLELKN, short EOJIGIKKNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE34A0", Offset = "0x5DE20A0", VA = "0x185DE34A0")]
	public static void GEGIBFNMNLG(this IncrementalHash DFNOHOLELKN, byte IFCNFOOLDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3CB0", Offset = "0x5DE28B0", VA = "0x185DE3CB0")]
	public static void OLBGAEAOMII(this IncrementalHash DFNOHOLELKN, bool FAFEFLOGMDJ, bool JKFKPHDMKID = false, bool DBPENJDMFOM = false, bool AHICBPLHKNE = false, bool NKIKDDMMMPA = false, bool EPDEGNNBIOO = false, bool BIDOOLHPJNM = false, bool HCHEPDMEEON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x258ACD0", Offset = "0x25898D0", VA = "0x18258ACD0")]
	public static void JGHJODEANAP<T>(this IncrementalHash DFNOHOLELKN, T DACFGCGDCAC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3E20", Offset = "0x5DE2A20", VA = "0x185DE3E20")]
	public static void PEBGKDPILPC(this IncrementalHash DFNOHOLELKN, float FLJEKCPFEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DE35B0", Offset = "0x5DE21B0", VA = "0x185DE35B0")]
	public static void GNPOOMLGHAP(this IncrementalHash DFNOHOLELKN, ulong ICPCPELAJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B20", Offset = "0x5DE2720", VA = "0x185DE3B20")]
	public static void NECMEBJHCPH(this IncrementalHash DFNOHOLELKN, uint LIBCFPGILOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3210", Offset = "0x5DE1E10", VA = "0x185DE3210")]
	public static void DHGPNCHGAMA(this IncrementalHash DFNOHOLELKN, ushort HLMLIANLFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B80", Offset = "0x5DE2780", VA = "0x185DE3B80")]
	public static void NIKDJNNJPMK(this IncrementalHash DFNOHOLELKN, Vector3 FJEPDJCBIBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HGNODJGOJAP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2EE0", Offset = "0x5DE1AE0", VA = "0x185DE2EE0")]
	public HGNODJGOJAP(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class MDBEKFLPJDO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class NLNMCGEJKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode HHHLENOMLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode HHNAEDAPOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public DAHPNEKPBKB KHAEOPKOBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<DAHPNEKPBKB> DHKPOAMGIKC;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public NLNMCGEJKOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct DAHPNEKPBKB : IComparable<DAHPNEKPBKB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int PKHBGBBFHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant JEDGGCKEOCN;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB64CD0", Offset = "0xB638D0", VA = "0x180B64CD0")]
		public DAHPNEKPBKB(int PKHBGBBFHCO, TClaimant JEDGGCKEOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4DE45C0", Offset = "0x4DE31C0", VA = "0x184DE45C0")]
		public bool BBAKFEOAKDJ([In] DAHPNEKPBKB LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4630", Offset = "0x4DE3230", VA = "0x184DE4630")]
		public bool HGCDNEDIHHD([In] DAHPNEKPBKB LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4620", Offset = "0x4DE3220", VA = "0x184DE4620", Slot = "4")]
		public int CompareTo(DAHPNEKPBKB LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4DE4640", Offset = "0x4DE3240", VA = "0x184DE4640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum NLKHAANMEAM
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OBAALHMMFMC : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public MDBEKFLPJDO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8ECE30", Offset = "0x8EBA30", VA = "0x1808ECE30")]
		[DebuggerHidden]
		public OBAALHMMFMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4640", Offset = "0x3DE3240", VA = "0x183DE4640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4800", Offset = "0x3DE3400", VA = "0x183DE4800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4720", Offset = "0x3DE3320", VA = "0x183DE4720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x330AF80", Offset = "0x3309B80", VA = "0x18330AF80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly NECGHMCCIKF<NLNMCGEJKOC> DPGECCEFMPB;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly NECGHMCCIKF<List<DAHPNEKPBKB>> LALBODCFBJF;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int FBPMJGHOMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> FDDFPFIFAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, NLNMCGEJKOC> JLNMFENEHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NLKHAANMEAM BBGPDHGEJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool MFJFBBMDDII;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EPLJAFPLIPM(TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DNACJCCLHBB(TNode NIICEONAONO, TClaimant ILIFEBMPANN, TClaimant EMLKIOKCJAH);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3C609A0", Offset = "0x3C5F5A0", VA = "0x183C609A0")]
	public MDBEKFLPJDO(NLKHAANMEAM BBGPDHGEJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3C60750", Offset = "0x3C5F350", VA = "0x183C60750")]
	public void PFMIFPKLCDG(TNode NIICEONAONO, TNode OGNJAKACDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F180", Offset = "0x3C5DD80", VA = "0x183C5F180")]
	public void AINLKDFHMNH(TClaimant JEDGGCKEOCN, TNode IKFBBEPCNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F2A0", Offset = "0x3C5DEA0", VA = "0x183C5F2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F800", Offset = "0x3C5E400", VA = "0x183C5F800")]
	private void FAKDNNBAHDA(TClaimant JEDGGCKEOCN, TNode BJLAKDEGLML, TNode IKFBBEPCNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FD80", Offset = "0x3C5E980", VA = "0x183C5FD80")]
	private int IEONEJGGOCK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C60240", Offset = "0x3C5EE40", VA = "0x183C60240")]
	private void MIMPAOOLLFL(TClaimant JEDGGCKEOCN, TNode EIEJDJOALLK, TNode HLMGOHOFLBK, int EGILEBFMOCI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F8A0", Offset = "0x3C5E4A0", VA = "0x183C5F8A0")]
	private void FNPBEGOGCPA(DAHPNEKPBKB NMKNAPIMNED, NLNMCGEJKOC EOEGOCMAKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F930", Offset = "0x3C5E530", VA = "0x183C5F930")]
	private void GLGACIJOHBI(TClaimant JEDGGCKEOCN, TNode EIEJDJOALLK, TNode HLMGOHOFLBK, int EGILEBFMOCI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FDF0", Offset = "0x3C5E9F0", VA = "0x183C5FDF0")]
	private void IHLGJCJJLEF(DAHPNEKPBKB NMKNAPIMNED, TNode NIICEONAONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F5E0", Offset = "0x3C5E1E0", VA = "0x183C5F5E0")]
	private void EMLDBENCFAL(DAHPNEKPBKB NMKNAPIMNED, NLNMCGEJKOC EOEGOCMAKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F6D0", Offset = "0x3C5E2D0", VA = "0x183C5F6D0")]
	private void EOBFFNCHKIB(NLNMCGEJKOC EOEGOCMAKNH, bool KLINFAAPLPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FF00", Offset = "0x3C5EB00", VA = "0x183C5FF00")]
	private void MEIBFLIJKDD(NLNMCGEJKOC EOEGOCMAKNH, TNode OGNJAKACDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C60580", Offset = "0x3C5F180", VA = "0x183C60580")]
	[IteratorStateMachine(typeof(MDBEKFLPJDO<, >.OBAALHMMFMC))]
	private IEnumerable<TNode> NFOJLNINIGE(TNode EIEJDJOALLK, TNode HLMGOHOFLBK, bool BFLDABCIPBI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C60660", Offset = "0x3C5F260", VA = "0x183C60660")]
	private NLNMCGEJKOC NHENBJPOHJJ(TNode NIICEONAONO, TNode HHNAEDAPOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3C5FC10", Offset = "0x3C5E810", VA = "0x183C5FC10")]
	private NLNMCGEJKOC HCNNNFDMEON(TNode NIICEONAONO, TNode HHNAEDAPOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F470", Offset = "0x3C5E070", VA = "0x183C5F470")]
	private void EGNJIHJHHJL(NLNMCGEJKOC EOEGOCMAKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FCLGKLICGIB<T> : IEnumerable<FCLGKLICGIB<T>.MLAGANGNLII>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct MLAGANGNLII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T GCPEEAODAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int DCGGFHOCGGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class MMBGCKKILOI : IEnumerator<MLAGANGNLII>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private FCLGKLICGIB<T> CEMIIACNFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int DCGGFHOCGGH;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x319AEE0", Offset = "0x3199AE0", VA = "0x18319AEE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public MLAGANGNLII FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3CB7A50", Offset = "0x3CB6650", VA = "0x183CB7A50", Slot = "4")]
			get
			{
				return default(MLAGANGNLII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7960", Offset = "0x3CB6560", VA = "0x183CB7960")]
		public MMBGCKKILOI(FCLGKLICGIB<T> CEMIIACNFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7860", Offset = "0x3CB6460", VA = "0x183CB7860", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x31E83C0", Offset = "0x31E6FC0", VA = "0x1831E83C0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B25BB0", Offset = "0x1B247B0", VA = "0x181B25BB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct KJIPBCOINKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool LIGPIGGFPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T GCPEEAODAIB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int DBGHCAOIPKO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> CDIDDEGKLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KJIPBCOINKO[] EKHMIAGBCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NOPLGPJGOIC;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int AFPFHGGOJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2640", Offset = "0x7B1240", VA = "0x1807B2640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D20", Offset = "0x7B0920", VA = "0x1807B1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2F86040", Offset = "0x2F84C40", VA = "0x182F86040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x34C9200", Offset = "0x34C7E00", VA = "0x1834C9200")]
	public FCLGKLICGIB(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x34C8E30", Offset = "0x34C7A30", VA = "0x1834C8E30")]
	public FCLGKLICGIB(MLAGANGNLII[] AKAHBBGLOBM, bool HDKMPMKDNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x34C7D30", Offset = "0x34C6930", VA = "0x1834C7D30")]
	public int ADPLEIKHHEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x34C87F0", Offset = "0x34C73F0", VA = "0x1834C87F0")]
	private int OCIBFCFBKBC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x34C7DC0", Offset = "0x34C69C0", VA = "0x1834C7DC0", Slot = "6")]
	protected virtual uint AKANHAHCOMN(uint DFNOHOLELKN, T GCPEEAODAIB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x34C7FB0", Offset = "0x34C6BB0", VA = "0x1834C7FB0")]
	public bool IJIBFNDEOAJ(T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x34C7F40", Offset = "0x34C6B40", VA = "0x1834C7F40")]
	public int GNDKBOBHNAJ(T GCPEEAODAIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x34C7E20", Offset = "0x34C6A20", VA = "0x1834C7E20")]
	public T CNDEBFMDKHJ(int DCGGFHOCGGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x34C8300", Offset = "0x34C6F00", VA = "0x1834C8300")]
	public bool NHIIPPMFJOI(T GCPEEAODAIB, bool EGNGFNKJAHP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x34C8350", Offset = "0x34C6F50", VA = "0x1834C8350")]
	public bool NHIIPPMFJOI(T GCPEEAODAIB, int DCGGFHOCGGH, bool EGNGFNKJAHP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x34C85B0", Offset = "0x34C71B0", VA = "0x1834C85B0")]
	private int OBACJJAMIAA(int EJAHPHIIAGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x34C89E0", Offset = "0x34C75E0", VA = "0x1834C89E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x34C89E0", Offset = "0x34C75E0", VA = "0x1834C89E0", Slot = "4")]
	private IEnumerator<MLAGANGNLII> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class NECGHMCCIKF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> CLEDCOCMGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> NGFEHPEFAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int CIEILPONCJJ;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEFE0", Offset = "0x3CFDBE0", VA = "0x183CFEFE0")]
	public static NECGHMCCIKF<T> IMICIIJCAAG(int AAAINGBCLDC = 0, int CIEILPONCJJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF540", Offset = "0x3CFE140", VA = "0x183CFF540")]
	public NECGHMCCIKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF3A0", Offset = "0x3CFDFA0", VA = "0x183CFF3A0")]
	public NECGHMCCIKF(int AAAINGBCLDC, int CIEILPONCJJ = int.MaxValue, bool JLIOEAOAKFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CFED70", Offset = "0x3CFD970", VA = "0x183CFED70")]
	public T EPNOJHHKCNC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEF10", Offset = "0x3CFDB10", VA = "0x183CFEF10")]
	public void IJNJJGHDBFD(T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF2C0", Offset = "0x3CFDEC0", VA = "0x183CFF2C0")]
	private void PEGAACDGEBI(T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEEF0", Offset = "0x3CFDAF0", VA = "0x183CFEEF0")]
	private void HHLOEKGCIAP(T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CFEC30", Offset = "0x3CFD830", VA = "0x183CFEC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3CFF0C0", Offset = "0x3CFDCC0", VA = "0x183CFF0C0")]
	private void JBHOMFBHGAD(IEnumerable<T> HJEFNDCLEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KKEEGODKDGA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> AHCKPBMADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T KBJHILABBKD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T CPPHFMLFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3983F60", Offset = "0x3982B60", VA = "0x183983F60")]
	public bool AAADJMOHACO(T GCPEEAODAIB, int PKHBGBBFHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3984630", Offset = "0x3983230", VA = "0x183984630")]
	public bool PCNPPMMEDPP(int PKHBGBBFHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3984200", Offset = "0x3982E00", VA = "0x183984200")]
	public T FCNFLDMOAFK(int PKCBNBJCHNN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3984050", Offset = "0x3982C50", VA = "0x183984050")]
	private bool EJCCBIOBMKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x39845E0", Offset = "0x39831E0", VA = "0x1839845E0")]
	public bool IKGDLKABABA(int PKHBGBBFHCO, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x39846A0", Offset = "0x39832A0", VA = "0x1839846A0")]
	public KKEEGODKDGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MPLGJPBBLCE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct OINMFPIEJAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T GMFAJOGMKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int KEDMEJFPCFA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<OINMFPIEJAH> OMHOHOBDCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T GNLBACBFICH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F86040", Offset = "0x2F84C40", VA = "0x182F86040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3BF0", Offset = "0x3CC27F0", VA = "0x183CC3BF0")]
	public bool EBENCGGDEAG(T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3DD0", Offset = "0x3CC29D0", VA = "0x183CC3DD0")]
	public void HFMDKEOMMOI(T GCPEEAODAIB, int PKHBGBBFHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3E70", Offset = "0x3CC2A70", VA = "0x183CC3E70")]
	public bool IFJPOCDCFNK(T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3D70", Offset = "0x3CC2970", VA = "0x183CC3D70")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3FC0", Offset = "0x3CC2BC0", VA = "0x183CC3FC0")]
	public T JNOFMHNOKGD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3A90", Offset = "0x3CC2690", VA = "0x183CC3A90")]
	private void DAJKJJJPCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4040", Offset = "0x3CC2C40", VA = "0x183CC4040")]
	public MPLGJPBBLCE()
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
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		[AJIIAMJDEPI(GNDHFGBAEMN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5DE45E0", Offset = "0x5DE31E0", VA = "0x185DE45E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DE48B0", Offset = "0x5DE34B0", VA = "0x185DE48B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DE47C0", Offset = "0x5DE33C0", VA = "0x185DE47C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4530", Offset = "0x5DE3130", VA = "0x185DE4530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4800", Offset = "0x5DE3400", VA = "0x185DE4800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4710", Offset = "0x5DE3310", VA = "0x185DE4710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE44A0", Offset = "0x5DE30A0", VA = "0x185DE44A0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x405F2B0", Offset = "0x405DEB0", VA = "0x18405F2B0", Slot = "4")]
		public virtual T JDKGIOLGJDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DLIGPJKJNIN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, DEABGCAEKEM> LLHPJMBLIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly NECGHMCCIKF<DEABGCAEKEM> PMGMBKBJJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool MAIJLKOGDBH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public DEABGCAEKEM ILGLADMKEMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 JFDBICCKEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAFEE30", Offset = "0xAFDA30", VA = "0x180AFEE30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xDCD070", Offset = "0xDCBC70", VA = "0x180DCD070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 NBNIEIHHOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDFA910", Offset = "0xDF9510", VA = "0x180DFA910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 JAKACNIMKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2020", Offset = "0x5DE0C20", VA = "0x185DE2020")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x776610", Offset = "0x775210", VA = "0x180776610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int JCPPMEKIDHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x773400", Offset = "0x772000", VA = "0x180773400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7733E0", Offset = "0x771FE0", VA = "0x1807733E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE25F0", Offset = "0x5DE11F0", VA = "0x185DE25F0")]
	public DLIGPJKJNIN(Bounds MKFCHFFKMPH, Vector2[] PNJLANFHOFA, int MGADAPNGPNC, byte EJAHPHIIAGB, float PAOHDNHKOJF = 0f, [Optional] NECGHMCCIKF<DEABGCAEKEM> PMGMBKBJJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1DA0", Offset = "0x5DE09A0", VA = "0x185DE1DA0")]
	public DEABGCAEKEM GOPKFADPIJO(byte DCGGFHOCGGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1CD0", Offset = "0x5DE08D0", VA = "0x185DE1CD0")]
	public void GJNOPLJIACH(Vector3 CFCLFCDKKPD, float DKIGNALOFMF, float NPLMCOODBLP, List<byte> AIEJMNEJPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B15AF0", Offset = "0x1B146F0", VA = "0x181B15AF0")]
	public void CKLEFDKJHIG(DEABGCAEKEM.COLLNAPBFNM KAEJNEFFMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B20", Offset = "0x5DE0720", VA = "0x185DE1B20")]
	public static int BHFFGNCEAGF(Vector2[] PNJLANFHOFA, int MGADAPNGPNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE23F0", Offset = "0x5DE0FF0", VA = "0x185DE23F0")]
	private DEABGCAEKEM PIFMCGIPPBJ(byte DCGGFHOCGGH, DEABGCAEKEM.ALCCBDGGJAN HJHGBNAMBMC, DEABGCAEKEM HHNAEDAPOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2040", Offset = "0x5DE0C40", VA = "0x185DE2040")]
	private void NGIGEJDDBAA(DEABGCAEKEM HHNAEDAPOHF, Vector2[] PNJLANFHOFA, int CKKBBGLGIPK, int HAJPEBBNIMK, int HEGMGDENBHG, int LKMOHIHOPMP, float PAOHDNHKOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E00", Offset = "0x5DE0A00", VA = "0x185DE1E00")]
	private void KIOPIPEPBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C10", Offset = "0x5DE0810", VA = "0x185DE1C10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C70", Offset = "0x5DE0870", VA = "0x185DE1C70", Slot = "1")]
	~DLIGPJKJNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DEABGCAEKEM
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum ALCCBDGGJAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum COLLNAPBFNM
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public byte EFPGBNMCEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 IAAEOCINLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 JKLDCECNLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 NJGFACICPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 FKOMKIDOGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public ALCCBDGGJAN LNKCHMBGKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public DEABGCAEKEM OCFNBALEAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<DEABGCAEKEM> LDENKCHJIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool EJCICLAIHKB;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B00", Offset = "0x5DE0700", VA = "0x185DE1B00")]
	public DEABGCAEKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE16C0", Offset = "0x5DE02C0", VA = "0x185DE16C0")]
	public void DDBFHNLJBCE(DEABGCAEKEM HOGAMINFHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
	public void CKLEFDKJHIG(int GNBLJIGJGNH, COLLNAPBFNM KAEJNEFFMPP, int KDPEFEFKBMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1810", Offset = "0x5DE0410", VA = "0x185DE1810")]
	public void GJNOPLJIACH(List<byte> AIEJMNEJPCN, Vector3 CFCLFCDKKPD, float DKIGNALOFMF, float NPLMCOODBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE17E0", Offset = "0x5DE03E0", VA = "0x185DE17E0")]
	public bool DIFDGLKBGFA(Vector3 BHCNJFDJBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1690", Offset = "0x5DE0290", VA = "0x185DE1690")]
	public bool BAOILFCGEGJ(Vector3 BHCNJFDJBME, float LAGCBNCEIIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A70", Offset = "0x5DE0670", VA = "0x185DE1A70")]
	public void JMCKLNABHHJ()
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
		public struct CODGOJGJKBD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> ALFGCABNDNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool KNCGMMCLHPM;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x3A23B50", Offset = "0x3A22750", VA = "0x183A23B50")]
			public CODGOJGJKBD(List<Component> ALFGCABNDNK, bool KNCGMMCLHPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x4C79210", Offset = "0x4C77E10", VA = "0x184C79210")]
			public OBCEBIDKCIK<T> IFFPMJIPELE()
			{
				return default(OBCEBIDKCIK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C79280", Offset = "0x4C77E80", VA = "0x184C79280", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x4C79280", Offset = "0x4C77E80", VA = "0x184C79280", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct OBCEBIDKCIK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> ALFGCABNDNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool KNCGMMCLHPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int DCGGFHOCGGH;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T FLKMMGJNGAH
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3DE4980", Offset = "0x3DE3580", VA = "0x183DE4980", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3DE4910", Offset = "0x3DE3510", VA = "0x183DE4910", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4950", Offset = "0x3DE3550", VA = "0x183DE4950")]
			public OBCEBIDKCIK(List<Component> ALFGCABNDNK, bool KNCGMMCLHPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4850", Offset = "0x3DE3450", VA = "0x183DE4850", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4860", Offset = "0x3DE3460", VA = "0x183DE4860", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x31DD980", Offset = "0x31DC580", VA = "0x1831DD980", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6060", Offset = "0x5DE4C60", VA = "0x185DE6060")]
		private void JMCKLNABHHJ(GameObject JNAEGEFDFLO, bool JNADMECNEPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE61D0", Offset = "0x5DE4DD0", VA = "0x185DE61D0")]
		public static void JMCKLNABHHJ(GameObject JNAEGEFDFLO, ToolHierarchyCache NPMIDGOLPAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x279E530", Offset = "0x279D130", VA = "0x18279E530")]
		public void CBOBCOOHAGD<T>(Action<T> GAFABDCELFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x279E4C0", Offset = "0x279D0C0", VA = "0x18279E4C0")]
		public T BHLGJOBJPCE<T>(bool KNCGMMCLHPM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x279E750", Offset = "0x279D350", VA = "0x18279E750")]
		public CODGOJGJKBD<T> IGHJHGJNOHB<T>(bool KNCGMMCLHPM = false) where T : class
		{
			return default(CODGOJGJKBD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5D10", Offset = "0x5DE4910", VA = "0x185DE5D10")]
		public List<Component> IILKAKCECNN(Type OMKEAAPIABA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5C20", Offset = "0x5DE4820", VA = "0x185DE5C20", Slot = "4")]
		public bool Equals(ToolHierarchyCache HPIMCNPJDMN, ToolHierarchyCache BKLHNKCOAIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5CA0", Offset = "0x5DE48A0", VA = "0x185DE5CA0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache IIFJCGIHMIN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MFBNEKOPMGI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int AAAINGBCLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int KKFMKMNCBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> PECFDDJHOLI;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3162140", Offset = "0x3160D40", VA = "0x183162140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T ENPKBKCAFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D9A0", Offset = "0x3C8C5A0", VA = "0x183C8D9A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T KGKJPDDEOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DB00", Offset = "0x3C8C700", VA = "0x183C8DB00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T BLCEPHOHGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DDC0", Offset = "0x3C8C9C0", VA = "0x183C8DDC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DF10", Offset = "0x3C8CB10", VA = "0x183C8DF10")]
	public MFBNEKOPMGI(int AAAINGBCLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DC60", Offset = "0x3C8C860", VA = "0x183C8DC60")]
	public void HFMDKEOMMOI(T MMOILNLDFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DA60", Offset = "0x3C8C660", VA = "0x183C8DA60")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C8DE40", Offset = "0x3C8CA40", VA = "0x183C8DE40")]
	public void PEDHBFBBLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D890", Offset = "0x3C8C490", VA = "0x183C8D890")]
	public void CICGNOMJFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C8D880", Offset = "0x3C8C480", VA = "0x183C8D880")]
	public void CDCOGGDCCEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class AJNADBDECBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct HKHLPIKEKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int KEDMEJFPCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T GMFAJOGMKIF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, HKHLPIKEKPM> AHCKPBMADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> FBOHLKDLCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T KBJHILABBKD;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T CPPHFMLFCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0190", VA = "0x180EE1590", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x36031E0", Offset = "0x3601DE0", VA = "0x1836031E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool MCKGMMCJDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3603180", Offset = "0x3601D80", VA = "0x183603180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object NPCIENLJGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3600040", Offset = "0x35FEC40", VA = "0x183600040")]
	public bool AAADJMOHACO(T GCPEEAODAIB, object KJCAGLABEME, int PKHBGBBFHCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3603240", Offset = "0x3601E40", VA = "0x183603240")]
	public bool PCNPPMMEDPP(object KJCAGLABEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3602D20", Offset = "0x3601920", VA = "0x183602D20")]
	public bool IKGDLKABABA(object KJCAGLABEME, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3602B00", Offset = "0x3601700", VA = "0x183602B00")]
	public void GMINFKPEKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3602180", Offset = "0x3600D80", VA = "0x183602180")]
	private bool EJCCBIOBMKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x36032D0", Offset = "0x3601ED0", VA = "0x1836032D0")]
	public AJNADBDECBH()
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
