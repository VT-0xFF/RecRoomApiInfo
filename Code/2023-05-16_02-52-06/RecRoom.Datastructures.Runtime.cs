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
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JMKGHGILKDN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A8DB0", Offset = "0x7A7BB0", VA = "0x1807A8DB0")]
	public JMKGHGILKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, AMFMKIHJLLF, JLHDIDPEOBN, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash PHHBPOOMOKI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xE8B1B0", Offset = "0xE89FB0", VA = "0x180E8B1B0")]
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
	[KAELEBJJOOD]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[KAELEBJJOOD]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A28C10", Offset = "0x6A27A10", VA = "0x186A28C10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A28BD0", Offset = "0x6A279D0", VA = "0x186A28BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A28C50", Offset = "0x6A27A50", VA = "0x186A28C50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A28E20", Offset = "0x6A27C20", VA = "0x186A28E20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A28D90", Offset = "0x6A27B90", VA = "0x186A28D90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10A4E10", Offset = "0x10A3C10", VA = "0x1810A4E10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10A4E00", Offset = "0x10A3C00", VA = "0x1810A4E00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A28B90", Offset = "0x6A27990", VA = "0x186A28B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6A28D00", Offset = "0x6A27B00", VA = "0x186A28D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A285D0", Offset = "0x6A273D0", VA = "0x186A285D0")]
	public void CopyBounds(SavedExtents IDBPJJAKCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A28AF0", Offset = "0x6A278F0", VA = "0x186A28AF0")]
	public void SetLocalSpaceBounds(Bounds EFAPDFNFPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x117DD70", Offset = "0x117CB70", VA = "0x18117DD70")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A288F0", Offset = "0x6A276F0", VA = "0x186A288F0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A28900", Offset = "0x6A27700", VA = "0x186A28900")]
	private void PHFLDBGOGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A286C0", Offset = "0x6A274C0", VA = "0x186A286C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A27F90", Offset = "0x6A26D90", VA = "0x186A27F90")]
	public static void CalculateLocalBoundsFor(GameObject HNLFAAIOFFP, out Bounds EFAPDFNFPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A28600", Offset = "0x6A27400", VA = "0x186A28600")]
	private static void HAPKLMOCPDL(Bounds EJKHFJILHAC, Color ICHEJPHGAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A28B10", Offset = "0x6A27910", VA = "0x186A28B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7620C0", Offset = "0x760EC0", VA = "0x1807620C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1474810", Offset = "0x1473610", VA = "0x181474810")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB079A0", Offset = "0xB067A0", VA = "0x180B079A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public virtual void OJJGPNNLIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
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
	[JMKGHGILKDN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A19B80", Offset = "0x3A18980", VA = "0x183A19B80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3A192B0", Offset = "0x3A180B0", VA = "0x183A192B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3A1A0C0", Offset = "0x3A18EC0", VA = "0x183A1A0C0")]
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
	private sealed class COKHPBJHDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public COKHPBJHDCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32DC3F0", Offset = "0x32DB1F0", VA = "0x1832DC3F0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[JMKGHGILKDN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1058BC0", Offset = "0x10579C0", VA = "0x181058BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1058BF0", Offset = "0x10579F0", VA = "0x181058BF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1058B10", Offset = "0x1057910", VA = "0x181058B10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey JHANOPJHOLP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1058B70", Offset = "0x1057970", VA = "0x181058B70", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1058A10", Offset = "0x1057810", VA = "0x181058A10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1058560", Offset = "0x1057360", VA = "0x181058560", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1057D80", Offset = "0x1056B80", VA = "0x181057D80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x10579D0", Offset = "0x10567D0", VA = "0x1810579D0", Slot = "14")]
	protected virtual string LHIIHAFJKBN(TKeyVal IOPGGICAPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1057910", Offset = "0x1056710", VA = "0x181057910", Slot = "4")]
	public bool ContainsKey(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1058900", Offset = "0x1057700", VA = "0x181058900", Slot = "5")]
	public bool TryGetValue(TKey JHANOPJHOLP, out TVal MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1057940", Offset = "0x1056740", VA = "0x181057940", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1057940", Offset = "0x1056740", VA = "0x181057940", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1058930", Offset = "0x1057730", VA = "0x181058930")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PDCIEMIOPBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NKFCIDFPHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public NKFCIDFPHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x36FAA70", Offset = "0x36F9870", VA = "0x1836FAA70")]
		internal bool <GetSamples>b__0(global::NNDIPDGGNAB<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float GNMHDCBBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float BHIOKNODGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NNDIPDGGNAB<float, T>> IFGLHAJNAAN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int GJJIDHLENKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA1C0", Offset = "0x1FF8FC0", VA = "0x181FFA1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA240", Offset = "0x1FF9040", VA = "0x181FFA240")]
	public PDCIEMIOPBK(float LCPCEEIOIHG, float CECCGBEIDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF97D0", Offset = "0x1FF85D0", VA = "0x181FF97D0")]
	public bool FNJNOKALMMD(float FMJGBJAJLDN, T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF96B0", Offset = "0x1FF84B0", VA = "0x181FF96B0")]
	public int BLHGMFKCNAO(float FMJGBJAJLDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9A90", Offset = "0x1FF8890", VA = "0x181FF9A90")]
	public IEnumerable<T> GCNHOOLFCAM(float FMJGBJAJLDN, [Optional] float? OFNNDMBCOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FFA110", Offset = "0x1FF8F10", VA = "0x181FFA110")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1FF9710", Offset = "0x1FF8510", VA = "0x181FF9710")]
	private void EFHOMNLELFL(float FMJGBJAJLDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class CKGLKMJCFAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LNPJPFJNPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T KCKILJPPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float LODBIHCAGDM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float OAOKLGFPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> NNOGCFPBIOH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int NFLPEPLMLCJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LNPJPFJNPMN[] PALKODKBAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int AAFNDOKHFLC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BNMNJNBLGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x10279F0", Offset = "0x10267F0", VA = "0x1810279F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x125CAA0", Offset = "0x125B8A0", VA = "0x18125CAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF6E0", Offset = "0x2DBE4E0", VA = "0x182DBF6E0")]
	public CKGLKMJCFAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF600", Offset = "0x2DBE400", VA = "0x182DBF600")]
	public CKGLKMJCFAC(int MKGODNJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF330", Offset = "0x2DBE130", VA = "0x182DBF330")]
	public void OEECIDDHIAM(float FMJGBJAJLDN, T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2DBF1E0", Offset = "0x2DBDFE0", VA = "0x182DBF1E0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2DBE4F0", Offset = "0x2DBD2F0", VA = "0x182DBE4F0")]
	public bool HIOAGFPBGMB(float OFBGFAMJLFM, float JDFAADPEHNP, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEDD0", Offset = "0x2DBDBD0", VA = "0x182DBEDD0")]
	public bool MIHPHGNGHPJ(float OFBGFAMJLFM, float JDFAADPEHNP, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBE180", Offset = "0x2DBCF80", VA = "0x182DBE180")]
	public void GLCBJHGGCKO(float OFBGFAMJLFM, float JDFAADPEHNP, List<T> MMBEBPNKEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2DBE150", Offset = "0x2DBCF50", VA = "0x182DBE150")]
	private int ADENHLAKJPC(int JDEDAENONGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DBEA80", Offset = "0x2DBD880", VA = "0x182DBEA80")]
	private void JLKODJCPGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HHEICJOPOGP();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MKJOLABGLAJ(T JGEPMPFGKOG, T CPIBOCOHLLI, float DJCNOMGFLPK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OGAGLAIHCAA(T MGFMONLLLPD, float DJCNOMGFLPK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JFJCOPAPFIO(T JGEPMPFGKOG, T CPIBOCOHLLI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T LEEKHPCKAKF(T JGEPMPFGKOG, T CPIBOCOHLLI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OECIJADLNLB : global::CKGLKMJCFAC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1192110", Offset = "0x1190F10", VA = "0x181192110", Slot = "4")]
	protected override Vector3 HHEICJOPOGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E87840", Offset = "0x1E86640", VA = "0x181E87840", Slot = "5")]
	protected override Vector3 MKJOLABGLAJ(Vector3 JGEPMPFGKOG, Vector3 CPIBOCOHLLI, float DJCNOMGFLPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A267D0", Offset = "0x6A255D0", VA = "0x186A267D0", Slot = "6")]
	protected override Vector3 OGAGLAIHCAA(Vector3 MGFMONLLLPD, float DJCNOMGFLPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A266E0", Offset = "0x6A254E0", VA = "0x186A266E0", Slot = "7")]
	protected override Vector3 JFJCOPAPFIO(Vector3 JGEPMPFGKOG, Vector3 CPIBOCOHLLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A26760", Offset = "0x6A25560", VA = "0x186A26760", Slot = "8")]
	protected override Vector3 LEEKHPCKAKF(Vector3 JGEPMPFGKOG, Vector3 CPIBOCOHLLI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A26830", Offset = "0x6A25630", VA = "0x186A26830")]
	public OECIJADLNLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AEAHKEKDKFN : global::CKGLKMJCFAC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A22060", Offset = "0x6A20E60", VA = "0x186A22060")]
	public AEAHKEKDKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A21FF0", Offset = "0x6A20DF0", VA = "0x186A21FF0")]
	public AEAHKEKDKFN(int MKGODNJCKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x11A9230", Offset = "0x11A8030", VA = "0x1811A9230", Slot = "4")]
	protected override float HHEICJOPOGP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EED0", Offset = "0x3D4DCD0", VA = "0x183D4EED0", Slot = "5")]
	protected override float MKJOLABGLAJ(float JGEPMPFGKOG, float CPIBOCOHLLI, float DJCNOMGFLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56EB440", Offset = "0x56EA240", VA = "0x1856EB440", Slot = "6")]
	protected override float OGAGLAIHCAA(float MGFMONLLLPD, float DJCNOMGFLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3EAC590", Offset = "0x3EAB390", VA = "0x183EAC590", Slot = "7")]
	protected override float JFJCOPAPFIO(float JGEPMPFGKOG, float CPIBOCOHLLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A21FE0", Offset = "0x6A20DE0", VA = "0x186A21FE0", Slot = "8")]
	protected override float LEEKHPCKAKF(float JGEPMPFGKOG, float CPIBOCOHLLI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LLMJHGEMGIH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780")]
	public static global::IEMGOMCIEND<T1> CJALKNOJAHB<T1>(T1 HOPEMFOOMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27D76E0", Offset = "0x27D64E0", VA = "0x1827D76E0")]
	public static global::NNDIPDGGNAB<T1, T2> CJALKNOJAHB<T1, T2>(T1 HOPEMFOOMFM, T2 POJJONMBOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27D7750", Offset = "0x27D6550", VA = "0x1827D7750")]
	public static global::ILJFHCKBCBF<T1, T2, T3> CJALKNOJAHB<T1, T2, T3>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x16422B0", Offset = "0x16410B0", VA = "0x1816422B0")]
	public static global::CEPCNEIEAOM<T1, T2, T3, T4> CJALKNOJAHB<T1, T2, T3, T4>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x270F8C0", Offset = "0x270E6C0", VA = "0x18270F8C0")]
	public static global::FCDNGPFMFLP<T1, T2, T3, T4, T5> CJALKNOJAHB<T1, T2, T3, T4, T5>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7970", Offset = "0x27D6770", VA = "0x1827D7970")]
	public static global::EENMFCDCNMP<T1, T2, T3, T4, T5, T6> CJALKNOJAHB<T1, T2, T3, T4, T5, T6>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27D78B0", Offset = "0x27D66B0", VA = "0x1827D78B0")]
	public static global::DCFGAJPCCAA<T1, T2, T3, T4, T5, T6, T7> CJALKNOJAHB<T1, T2, T3, T4, T5, T6, T7>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID, T7 DCGOKHJBHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27D77E0", Offset = "0x27D65E0", VA = "0x1827D77E0")]
	public static global::JFEJPFMBFDG<T1, T2, T3, T4, T5, T6, T7, T8> CJALKNOJAHB<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID, T7 DCGOKHJBHHF, T8 INCNABPBJDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20ABA10", Offset = "0x20AA810", VA = "0x1820ABA10")]
	[IteratorStateMachine(typeof(CBHFEFADEEC))]
	public static IEnumerable<global::NNDIPDGGNAB<T1, T2>> NHGCPPILIAI<T1, T2>(IEnumerable<T1> GCKGDDMIIDO, IEnumerable<T2> EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x23628D0", Offset = "0x23616D0", VA = "0x1823628D0")]
	[IteratorStateMachine(typeof(JIMACBNGFOB))]
	public static IEnumerable<global::ILJFHCKBCBF<T1, T2, T3>> NHGCPPILIAI<T1, T2, T3>(IEnumerable<T1> GCKGDDMIIDO, IEnumerable<T2> EJKHFJILHAC, IEnumerable<T3> ICHEJPHGAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF80", Offset = "0x8DCD80", VA = "0x1808DDF80")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF50", Offset = "0x8DCD50", VA = "0x1808DDF50")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF30", Offset = "0x8DCD30", VA = "0x1808DDF30")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC, int EPAIPFFJNAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF60", Offset = "0x8DCD60", VA = "0x1808DDF60")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC, int EPAIPFFJNAA, int GPBHBIFIBBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A251D0", Offset = "0x6A23FD0", VA = "0x186A251D0")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC, int EPAIPFFJNAA, int GPBHBIFIBBA, int NHCMKIMLKGC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A25220", Offset = "0x6A24020", VA = "0x186A25220")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC, int EPAIPFFJNAA, int GPBHBIFIBBA, int NHCMKIMLKGC, int DFCMBOCEAGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A251F0", Offset = "0x6A23FF0", VA = "0x186A251F0")]
	internal static int LOMODDOLKPK(int NIKCGLBECDI, int GCKKKMCDJAC, int HDBFIAAPELC, int EPAIPFFJNAA, int GPBHBIFIBBA, int NHCMKIMLKGC, int DFCMBOCEAGE, int BCOPDEABCJP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IEMGOMCIEND<T1> : IComparable<global::IEMGOMCIEND<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	public IEMGOMCIEND(T1 HOPEMFOOMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1E00630", Offset = "0x1DFF430", VA = "0x181E00630", Slot = "4")]
	public int CompareTo(global::IEMGOMCIEND<T1> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E006A0", Offset = "0x1DFF4A0", VA = "0x181E006A0", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xB5CCD0", Offset = "0xB5BAD0", VA = "0x180B5CCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1E00740", Offset = "0x1DFF540", VA = "0x181E00740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NNDIPDGGNAB<T1, T2> : IComparable<global::NNDIPDGGNAB<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6DE0", Offset = "0x2BF5BE0", VA = "0x182BF6DE0")]
	public NNDIPDGGNAB(T1 HOPEMFOOMFM, T2 POJJONMBOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C370", Offset = "0x3E3B170", VA = "0x183E3C370", Slot = "4")]
	public int CompareTo(global::NNDIPDGGNAB<T1, T2> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CA50", Offset = "0x3E3B850", VA = "0x183E3CA50", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E3CF20", Offset = "0x3E3BD20", VA = "0x183E3CF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3E3D600", Offset = "0x3E3C400", VA = "0x183E3D600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ILJFHCKBCBF<T1, T2, T3> : IComparable<global::ILJFHCKBCBF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x27524D0", Offset = "0x27512D0", VA = "0x1827524D0")]
	public ILJFHCKBCBF(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2751DC0", Offset = "0x2750BC0", VA = "0x182751DC0", Slot = "4")]
	public int CompareTo(global::ILJFHCKBCBF<T1, T2, T3> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2751FB0", Offset = "0x2750DB0", VA = "0x182751FB0", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2752120", Offset = "0x2750F20", VA = "0x182752120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2752320", Offset = "0x2751120", VA = "0x182752320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CEPCNEIEAOM<T1, T2, T3, T4> : IComparable<global::CEPCNEIEAOM<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 ELKPDDMPMDF;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E005A0", Offset = "0x1DFF3A0", VA = "0x181E005A0")]
	public CEPCNEIEAOM(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9C30", Offset = "0x2DA8A30", VA = "0x182DA9C30", Slot = "4")]
	public int CompareTo(global::CEPCNEIEAOM<T1, T2, T3, T4> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9D70", Offset = "0x2DA8B70", VA = "0x182DA9D70", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9E90", Offset = "0x2DA8C90", VA = "0x182DA9E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2DA9F50", Offset = "0x2DA8D50", VA = "0x182DA9F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FCDNGPFMFLP<T1, T2, T3, T4, T5> : IComparable<global::FCDNGPFMFLP<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 ELKPDDMPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 AALCGBEHLCD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2E182E0", Offset = "0x2E170E0", VA = "0x182E182E0")]
	public FCDNGPFMFLP(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E17DD0", Offset = "0x2E16BD0", VA = "0x182E17DD0", Slot = "4")]
	public int CompareTo(global::FCDNGPFMFLP<T1, T2, T3, T4, T5> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E17F50", Offset = "0x2E16D50", VA = "0x182E17F50", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E18090", Offset = "0x2E16E90", VA = "0x182E18090", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E18190", Offset = "0x2E16F90", VA = "0x182E18190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EENMFCDCNMP<T1, T2, T3, T4, T5, T6> : IComparable<global::EENMFCDCNMP<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 ELKPDDMPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 AALCGBEHLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 OGGLPGJFDFE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x321FE40", Offset = "0x321EC40", VA = "0x18321FE40")]
	public EENMFCDCNMP(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x321F880", Offset = "0x321E680", VA = "0x18321F880", Slot = "4")]
	public int CompareTo(global::EENMFCDCNMP<T1, T2, T3, T4, T5, T6> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x321FA40", Offset = "0x321E840", VA = "0x18321FA40", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x321FBB0", Offset = "0x321E9B0", VA = "0x18321FBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x321FCD0", Offset = "0x321EAD0", VA = "0x18321FCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DCFGAJPCCAA<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::DCFGAJPCCAA<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 ELKPDDMPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 AALCGBEHLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 OGGLPGJFDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 GFNNHAAPLHH;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2F873F0", Offset = "0x2F861F0", VA = "0x182F873F0")]
	public DCFGAJPCCAA(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID, T7 DCGOKHJBHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F86D70", Offset = "0x2F85B70", VA = "0x182F86D70", Slot = "4")]
	public int CompareTo(global::DCFGAJPCCAA<T1, T2, T3, T4, T5, T6, T7> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F86F70", Offset = "0x2F85D70", VA = "0x182F86F70", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F87110", Offset = "0x2F85F10", VA = "0x182F87110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F87260", Offset = "0x2F86060", VA = "0x182F87260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JFEJPFMBFDG<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::JFEJPFMBFDG<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 POKLODCHOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 HEDLANPJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 OLKMJIMBFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 ELKPDDMPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 AALCGBEHLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 OGGLPGJFDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 GFNNHAAPLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 PPDMCJFFKIG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D560", Offset = "0x2A4C360", VA = "0x182A4D560")]
	public JFEJPFMBFDG(T1 HOPEMFOOMFM, T2 POJJONMBOIB, T3 EPAADOJDJNO, T4 CKHOGOOGFPD, T5 OODJKLNLKOP, T6 NAHIFLFJJID, T7 DCGOKHJBHHF, T8 INCNABPBJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A4CE30", Offset = "0x2A4BC30", VA = "0x182A4CE30", Slot = "4")]
	public int CompareTo(global::JFEJPFMBFDG<T1, T2, T3, T4, T5, T6, T7, T8> IDBPJJAKCBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D080", Offset = "0x2A4BE80", VA = "0x182A4D080", Slot = "0")]
	public override bool Equals(object IDBPJJAKCBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D240", Offset = "0x2A4C040", VA = "0x182A4D240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A4D3B0", Offset = "0x2A4C1B0", VA = "0x182A4D3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EC49B0", Offset = "0x3EC37B0", VA = "0x183EC49B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EC49C0", Offset = "0x3EC37C0", VA = "0x183EC49C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float NPGFPLGPNMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x120EDA0", Offset = "0x120DBA0", VA = "0x18120EDA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4035100", Offset = "0x4033F00", VA = "0x184035100")]
	public T DMCOFAJDLKH(float DJCNOMGFLPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4034EC0", Offset = "0x4033CC0", VA = "0x184034EC0")]
	public T CFMBJFFKKLA(float DJCNOMGFLPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T MKJOLABGLAJ(T JGEPMPFGKOG, T CPIBOCOHLLI, float DJCNOMGFLPK);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EED0", Offset = "0x3D4DCD0", VA = "0x183D4EED0", Slot = "4")]
	protected override float MKJOLABGLAJ(float JGEPMPFGKOG, float CPIBOCOHLLI, float DJCNOMGFLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A24280", Offset = "0x6A23080", VA = "0x186A24280")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E87840", Offset = "0x1E86640", VA = "0x181E87840", Slot = "4")]
	protected override Vector3 MKJOLABGLAJ(Vector3 JGEPMPFGKOG, Vector3 CPIBOCOHLLI, float DJCNOMGFLPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A29D30", Offset = "0x6A28B30", VA = "0x186A29D30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A22D40", Offset = "0x6A21B40", VA = "0x186A22D40", Slot = "4")]
	protected override Color MKJOLABGLAJ(Color JGEPMPFGKOG, Color CPIBOCOHLLI, float DJCNOMGFLPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A22D90", Offset = "0x6A21B90", VA = "0x186A22D90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PBNHOCEKCMO : global::KJFAPAKCDDH<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A27830", Offset = "0x6A26630", VA = "0x186A27830")]
	public PBNHOCEKCMO(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A27880", Offset = "0x6A26680", VA = "0x186A27880")]
	public PBNHOCEKCMO(NPILPLKKELI[] DPGFIDKIIHG, bool ICKCIKCNPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A277C0", Offset = "0x6A265C0", VA = "0x186A277C0", Slot = "6")]
	protected override uint KFBJLAAIEGE(uint PHHBPOOMOKI, string MGFMONLLLPD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KOGCMNCFIHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KOGCMNCFIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BGCGHMCKMGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OPPJLAENKNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public OPPJLAENKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x254BC30", Offset = "0x254AA30", VA = "0x18254BC30")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AODBJMCJDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HEEMOJIKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int LHLGNHMHGDD;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCAF370", Offset = "0xCAE170", VA = "0x180CAF370")]
	private BGCGHMCKMGH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KEBKGAPENJA, int LMDFACBENIJ, int FBEKDMEKGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x38E6F40", Offset = "0x38E5D40", VA = "0x1838E6F40")]
	public static global::BGCGHMCKMGH<T> AIJMFKKLHCC()
	{
		return default(global::BGCGHMCKMGH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x38E7E90", Offset = "0x38E6C90", VA = "0x1838E7E90")]
	public (int, int, Task<T>) COMNAPJACHF(int DAMKNOPMGGI, [Optional] CancellationToken NBLKBHANAPP, double AHLFLDNKOCA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x38E8760", Offset = "0x38E7560", VA = "0x1838E8760")]
	public void EKAHGBFOIFA(int DAMKNOPMGGI, int FBEKDMEKGFB, in T AJCHMFJLMGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HBLDMMMDEOI
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A24470", Offset = "0x6A23270", VA = "0x186A24470")]
	public static global::BGCGHMCKMGH<JCKJOPOBLHO> AIJMFKKLHCC()
	{
		return default(global::BGCGHMCKMGH<JCKJOPOBLHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A244C0", Offset = "0x6A232C0", VA = "0x186A244C0")]
	public static void EKAHGBFOIFA(this in global::BGCGHMCKMGH<JCKJOPOBLHO> LCNEHOGIJPK, int DAMKNOPMGGI, int FBEKDMEKGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class NMHPKNCLOGN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> KGFJLCOJGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> BDGLOGNLKOP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> LKNPAMNBNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E290", Offset = "0x2A3D090", VA = "0x182A3E290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> DAGPLHDNNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1DF5A40", Offset = "0x1DF4840", VA = "0x181DF5A40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AC20", Offset = "0x3E39A20", VA = "0x183E3AC20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AC90", Offset = "0x3E39A90", VA = "0x183E3AC90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3E39D60", Offset = "0x3E38B60", VA = "0x183E39D60")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A2B0", Offset = "0x3E390B0", VA = "0x183E3A2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E39AF0", Offset = "0x3E388F0", VA = "0x183E39AF0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AAC0", Offset = "0x3E398C0", VA = "0x183E3AAC0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E39930", Offset = "0x3E38730", VA = "0x183E39930", Slot = "9")]
	public void Add(TKey JHANOPJHOLP, TVal MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E39970", Offset = "0x3E38770", VA = "0x183E39970", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3E39B50", Offset = "0x3E38950", VA = "0x183E39B50", Slot = "8")]
	public bool ContainsKey(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E39B80", Offset = "0x3E38980", VA = "0x183E39B80", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A990", Offset = "0x3E39790", VA = "0x183E3A990", Slot = "10")]
	public bool Remove(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A9F0", Offset = "0x3E397F0", VA = "0x183E3A9F0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6350", Offset = "0x2BF5150", VA = "0x182BF6350", Slot = "11")]
	public bool TryGetValue(TKey JHANOPJHOLP, out TVal MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3234B50", Offset = "0x3233950", VA = "0x183234B50", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E39BE0", Offset = "0x3E389E0", VA = "0x183E39BE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A420", Offset = "0x3E39220", VA = "0x183E3A420")]
	public void OEECIDDHIAM(TVal MMAFFACGBGF, TKey JHANOPJHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A3A0", Offset = "0x3E391A0", VA = "0x183E3A3A0")]
	public void OEECIDDHIAM(KeyValuePair<TVal, TKey> PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E39C70", Offset = "0x3E38A70", VA = "0x183E39C70")]
	public bool EJNKOOJFENG(TVal JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A130", Offset = "0x3E38F30", VA = "0x183E3A130")]
	public bool LDEEBLCAEDK(KeyValuePair<TVal, TKey> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E39A80", Offset = "0x3E38880", VA = "0x183E39A80")]
	public bool CJGLMEKHGBL(TVal JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E39A80", Offset = "0x3E38880", VA = "0x183E39A80")]
	public bool CJGLMEKHGBL(KeyValuePair<TVal, TKey> PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E39A10", Offset = "0x3E38810", VA = "0x183E39A10")]
	public bool BOAPLFBFGDK(TVal JHANOPJHOLP, out TKey MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A220", Offset = "0x3E39020", VA = "0x183E3A220")]
	public IEnumerator<KeyValuePair<TVal, TKey>> LJDKIJKHCOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3E39FE0", Offset = "0x3E38DE0", VA = "0x183E39FE0")]
	private void KBLEBFGKPMP(TKey JHANOPJHOLP, TVal MMAFFACGBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3E39E20", Offset = "0x3E38C20", VA = "0x183E39E20")]
	private void IEBCMBAGMDK(TKey JHANOPJHOLP, TVal MMAFFACGBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A8C0", Offset = "0x3E396C0", VA = "0x183E3A8C0")]
	private bool OOOKGPMPKKC(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E3A660", Offset = "0x3E39460", VA = "0x183E3A660")]
	private bool OOOKGPMPKKC(TVal MMAFFACGBGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AB10", Offset = "0x3E39910", VA = "0x183E3AB10")]
	public NMHPKNCLOGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class CDCCINKLNIP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::CDCCINKLNIP<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3530690", Offset = "0x352F490", VA = "0x183530690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x333C360", Offset = "0x333B160", VA = "0x18333C360")]
		public Enumerator(global::CDCCINKLNIP<T> MMBEBPNKEHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x352D5B0", Offset = "0x352C3B0", VA = "0x18352D5B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x352F600", Offset = "0x352E400", VA = "0x18352F600", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x352D1A0", Offset = "0x352BFA0", VA = "0x18352D1A0")]
		private void FMBANBGANEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] MNICNOKECPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int IAONMKKMAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int KJJNLGDLKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int HHCMOLFBCEB;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x316C9E0", Offset = "0x316B7E0", VA = "0x18316C9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x316BB70", Offset = "0x316A970", VA = "0x18316BB70")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x316C960", Offset = "0x316B760", VA = "0x18316C960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x316D440", Offset = "0x316C240", VA = "0x18316D440")]
	public CDCCINKLNIP(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x316CB80", Offset = "0x316B980", VA = "0x18316CB80")]
	public void OEECIDDHIAM(T DJCNOMGFLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x316BBC0", Offset = "0x316A9C0", VA = "0x18316BBC0")]
	public void MBEELBLAEJN(IEnumerable<T> MKIDAPMAKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x316CB60", Offset = "0x316B960", VA = "0x18316CB60")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x316D230", Offset = "0x316C030", VA = "0x18316D230")]
	public void OLAMLCOLIFE(int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x316CAD0", Offset = "0x316B8D0", VA = "0x18316CAD0")]
	public void NEEGGACLFFB(int MNBBKKLFBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x316B7A0", Offset = "0x316A5A0", VA = "0x18316B7A0")]
	public void HFHDIAPHPCP(T[] PALKODKBAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x316CA20", Offset = "0x316B820", VA = "0x18316CA20")]
	public Enumerator NEACBAFBFJC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x316D2C0", Offset = "0x316C0C0", VA = "0x18316D2C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x316D2C0", Offset = "0x316C0C0", VA = "0x18316D2C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x316D140", Offset = "0x316BF40", VA = "0x18316D140")]
	private int OKOPLCMJLAG(int NNHNOIMLALG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x316C7C0", Offset = "0x316B5C0", VA = "0x18316C7C0")]
	private int MLOMIAGNKOH(int NNHNOIMLALG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class EKKAGHIGJIF<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> OKLGNGGDDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> FHHABBOOKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x741130", Offset = "0x73FF30", VA = "0x180741130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x433F9A0", Offset = "0x433E7A0", VA = "0x18433F9A0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x433FA40", Offset = "0x433E840", VA = "0x18433FA40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x433F940", Offset = "0x433E740", VA = "0x18433F940", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x35DB800", Offset = "0x35DA600", VA = "0x1835DB800")]
	public EKKAGHIGJIF(Func<Internal, External> MHLJONEJJLC, Func<External, Internal> OKLGNGGDDCE, bool CCJDKCIDKAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x433F660", Offset = "0x433E460", VA = "0x18433F660", Slot = "6")]
	public int IndexOf(External PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x433F230", Offset = "0x433E030", VA = "0x18433F230", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x433F2E0", Offset = "0x433E0E0", VA = "0x18433F2E0", Slot = "13")]
	public bool Contains(External PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x433F370", Offset = "0x433E170", VA = "0x18433F370", Slot = "14")]
	public void CopyTo(External[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x433F140", Offset = "0x433DF40", VA = "0x18433F140", Slot = "11")]
	public void Add(External PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x433F750", Offset = "0x433E550", VA = "0x18433F750", Slot = "7")]
	public void Insert(int NNHNOIMLALG, External PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x433F8B0", Offset = "0x433E6B0", VA = "0x18433F8B0", Slot = "15")]
	public bool Remove(External PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x433F7F0", Offset = "0x433E5F0", VA = "0x18433F7F0", Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x433F590", Offset = "0x433E390", VA = "0x18433F590", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5090", Offset = "0x1DF3E90", VA = "0x181DF5090", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class AJMNFGMFDDL<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> MHLJONEJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> FHHABBOOKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x24E09D0", Offset = "0x24DF7D0", VA = "0x1824E09D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x24E0970", Offset = "0x24DF770", VA = "0x1824E0970", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	public AJMNFGMFDDL(Func<Internal, External> MHLJONEJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x24E0920", Offset = "0x24DF720", VA = "0x1824E0920")]
	public AJMNFGMFDDL(IReadOnlyList<Internal> MPMKGFKPBEN, Func<Internal, External> MHLJONEJJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x24E06D0", Offset = "0x24DF4D0", VA = "0x1824E06D0")]
	public void HFHDIAPHPCP(External[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x24E0660", Offset = "0x24DF460", VA = "0x1824E0660", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x24E08F0", Offset = "0x24DF6F0", VA = "0x1824E08F0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class IBBLPKBPLIE<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> MPMKGFKPBEN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> FHHABBOOKBP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF5120", Offset = "0x1DF3F20", VA = "0x181DF5120", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1DF50C0", Offset = "0x1DF3EC0", VA = "0x181DF50C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	public IBBLPKBPLIE(IReadOnlyList<Internal> MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4FF0", Offset = "0x1DF3DF0", VA = "0x181DF4FF0")]
	public bool LDEEBLCAEDK(External PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4DC0", Offset = "0x1DF3BC0", VA = "0x181DF4DC0")]
	public void HFHDIAPHPCP(External[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4D50", Offset = "0x1DF3B50", VA = "0x181DF4D50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5090", Offset = "0x1DF3E90", VA = "0x181DF5090", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class PIEPKOGAJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DFEIOJEKOIG(object[] CFGJGLPAHFD);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected PIEPKOGAJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class EDNLDDFIBIF<T> : PIEPKOGAJJG
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct CAPPCEMLIBP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum FCAAPMNDICM
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public FCAAPMNDICM LEDIIMFEFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T JBJAGOLOBKN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int AHAJPDHNBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool JFFOGEGOBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool LIENDNFENLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> JEFPODAGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<CAPPCEMLIBP> PDMJCCJHILF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BBCBJNFLLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x321F150", Offset = "0x321DF50", VA = "0x18321F150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x321F480", Offset = "0x321E280", VA = "0x18321F480")]
	protected EDNLDDFIBIF(bool LIENDNFENLC, bool JFFOGEGOBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x321F190", Offset = "0x321DF90", VA = "0x18321F190")]
	protected bool MNJHJFIHDAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x321EEE0", Offset = "0x321DCE0", VA = "0x18321EEE0")]
	protected void EDKNPGDMAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x321EFA0", Offset = "0x321DDA0", VA = "0x18321EFA0")]
	protected void FEHPMEPPJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2C79760", Offset = "0x2C78560", VA = "0x182C79760")]
	private static void ANBFANNEMHK<U>(ref List<U> MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x321F320", Offset = "0x321E120", VA = "0x18321F320", Slot = "5")]
	public void OEECIDDHIAM(T JBJAGOLOBKN, bool MINHBLLEGFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x321EDA0", Offset = "0x321DBA0", VA = "0x18321EDA0", Slot = "6")]
	public void CJGLMEKHGBL(T JBJAGOLOBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x321F210", Offset = "0x321E010", VA = "0x18321F210")]
	public void ODCBHOABBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IFCBKALKNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class CJIPBGMKILF : global::EDNLDDFIBIF<Action>, IFCBKALKNHI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A22C30", Offset = "0x6A21A30", VA = "0x186A22C30")]
	public CJIPBGMKILF(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A229C0", Offset = "0x6A217C0", VA = "0x186A229C0")]
	public void IABBPDFDKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A22950", Offset = "0x6A21750", VA = "0x186A22950", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A22BD0", Offset = "0x6A219D0", VA = "0x186A22BD0")]
	public static CJIPBGMKILF LDHDNDGLKBP(CJIPBGMKILF LPOAJAPEHEP, Action JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A228F0", Offset = "0x6A216F0", VA = "0x186A228F0")]
	public static CJIPBGMKILF AOOKPENIMMF(CJIPBGMKILF LPOAJAPEHEP, Action JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface LMJCNCGFHNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JDKDAIPFIPL<T> : global::EDNLDDFIBIF<Action<T>>, global::LMJCNCGFHNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public JDKDAIPFIPL(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3F823E0", Offset = "0x3F811E0", VA = "0x183F823E0")]
	public void IABBPDFDKNC(T DJCNOMGFLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3F800B0", Offset = "0x3F7EEB0", VA = "0x183F800B0", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3F83800", Offset = "0x3F82600", VA = "0x183F83800")]
	public static global::JDKDAIPFIPL<T> LDHDNDGLKBP(global::JDKDAIPFIPL<T> LPOAJAPEHEP, Action<T> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3F7FBE0", Offset = "0x3F7E9E0", VA = "0x183F7FBE0")]
	public static global::JDKDAIPFIPL<T> AOOKPENIMMF(global::JDKDAIPFIPL<T> LPOAJAPEHEP, Action<T> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HCDFELNPLGA<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T, U> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T, U> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class LEPJFHFGLAL<T, U> : global::EDNLDDFIBIF<Action<T, U>>, global::HCDFELNPLGA<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public LEPJFHFGLAL(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAB20", Offset = "0x2BE9920", VA = "0x182BEAB20")]
	public void IABBPDFDKNC(T DJCNOMGFLPK, U IDNEIOJCCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2856E60", Offset = "0x2855C60", VA = "0x182856E60", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2857B80", Offset = "0x2856980", VA = "0x182857B80")]
	public static global::LEPJFHFGLAL<T, U> LDHDNDGLKBP(global::LEPJFHFGLAL<T, U> LPOAJAPEHEP, Action<T, U> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x28566F0", Offset = "0x28554F0", VA = "0x1828566F0")]
	public static global::LEPJFHFGLAL<T, U> AOOKPENIMMF(global::LEPJFHFGLAL<T, U> LPOAJAPEHEP, Action<T, U> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HAOBDLHCMKH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T, U, V> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T, U, V> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GPMIOKNMCFC<T, U, V> : global::EDNLDDFIBIF<Action<T, U, V>>, global::HAOBDLHCMKH<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public GPMIOKNMCFC(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x4799E10", Offset = "0x4798C10", VA = "0x184799E10")]
	public void IABBPDFDKNC(T DJCNOMGFLPK, U IDNEIOJCCMO, V LABLHNPANGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x4796AD0", Offset = "0x47958D0", VA = "0x184796AD0", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x479A2C0", Offset = "0x47990C0", VA = "0x18479A2C0")]
	public static global::GPMIOKNMCFC<T, U, V> LDHDNDGLKBP(global::GPMIOKNMCFC<T, U, V> LPOAJAPEHEP, Action<T, U, V> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x4796400", Offset = "0x4795200", VA = "0x184796400")]
	public static global::GPMIOKNMCFC<T, U, V> AOOKPENIMMF(global::GPMIOKNMCFC<T, U, V> LPOAJAPEHEP, Action<T, U, V> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface OPFNMAFDJND<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T, U, V, W> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T, U, V, W> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CBODHLNDAJD<T, U, V, W> : global::EDNLDDFIBIF<Action<T, U, V, W>>, global::OPFNMAFDJND<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public CBODHLNDAJD(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3168EA0", Offset = "0x3167CA0", VA = "0x183168EA0")]
	public void IABBPDFDKNC(T DJCNOMGFLPK, U IDNEIOJCCMO, V LABLHNPANGA, W DAHBJHMBLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3167CB0", Offset = "0x3166AB0", VA = "0x183167CB0", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x316A130", Offset = "0x3168F30", VA = "0x18316A130")]
	public static global::CBODHLNDAJD<T, U, V, W> LDHDNDGLKBP(global::CBODHLNDAJD<T, U, V, W> LPOAJAPEHEP, Action<T, U, V, W> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3167720", Offset = "0x3166520", VA = "0x183167720")]
	public static global::CBODHLNDAJD<T, U, V, W> AOOKPENIMMF(global::CBODHLNDAJD<T, U, V, W> LPOAJAPEHEP, Action<T, U, V, W> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface PHBHAPAOGKD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T, U, V, W, X> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T, U, V, W, X> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class LMJDECCGJLJ<T, U, V, W, X> : global::EDNLDDFIBIF<Action<T, U, V, W, X>>, global::PHBHAPAOGKD<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public LMJDECCGJLJ(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A030", Offset = "0x3A98E30", VA = "0x183A9A030")]
	public void IABBPDFDKNC(T DJCNOMGFLPK, U IDNEIOJCCMO, V LABLHNPANGA, W DAHBJHMBLLC, X NHKCICGBPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3A99A10", Offset = "0x3A98810", VA = "0x183A99A10", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A2C0", Offset = "0x3A990C0", VA = "0x183A9A2C0")]
	public static global::LMJDECCGJLJ<T, U, V, W, X> LDHDNDGLKBP(global::LMJDECCGJLJ<T, U, V, W, X> LPOAJAPEHEP, Action<T, U, V, W, X> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3A99650", Offset = "0x3A98450", VA = "0x183A99650")]
	public static global::LMJDECCGJLJ<T, U, V, W, X> AOOKPENIMMF(global::LMJDECCGJLJ<T, U, V, W, X> LPOAJAPEHEP, Action<T, U, V, W, X> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface DLLAGADGMAL<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEECIDDHIAM(Action<T, U, V, W, X, Y> JBJAGOLOBKN, bool MINHBLLEGFM = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJGLMEKHGBL(Action<T, U, V, W, X, Y> JBJAGOLOBKN);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MJJNEKIGIGA<T, U, V, W, X, Y> : global::EDNLDDFIBIF<Action<T, U, V, W, X, Y>>, global::DLLAGADGMAL<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x200B4D0", Offset = "0x200A2D0", VA = "0x18200B4D0")]
	public MJJNEKIGIGA(bool LIENDNFENLC = false, bool JFFOGEGOBCN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x30D1D00", Offset = "0x30D0B00", VA = "0x1830D1D00")]
	public void IABBPDFDKNC(T DJCNOMGFLPK, U IDNEIOJCCMO, V LABLHNPANGA, W DAHBJHMBLLC, X NHKCICGBPMI, Y PEKPPEFFGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x30D16A0", Offset = "0x30D04A0", VA = "0x1830D16A0", Slot = "4")]
	public override void DFEIOJEKOIG(object[] CFGJGLPAHFD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x30D2260", Offset = "0x30D1060", VA = "0x1830D2260")]
	public static global::MJJNEKIGIGA<T, U, V, W, X, Y> LDHDNDGLKBP(global::MJJNEKIGIGA<T, U, V, W, X, Y> LPOAJAPEHEP, Action<T, U, V, W, X, Y> JBJAGOLOBKN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x30D0F40", Offset = "0x30CFD40", VA = "0x1830D0F40")]
	public static global::MJJNEKIGIGA<T, U, V, W, X, Y> AOOKPENIMMF(global::MJJNEKIGIGA<T, U, V, W, X, Y> LPOAJAPEHEP, Action<T, U, V, W, X, Y> JBJAGOLOBKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class KBCPNFJHMFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct FDFCFIIMKEK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::KBCPNFJHMFF<T> FFNNODKPDFM;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T KCKILJPPPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2A5EAA0", Offset = "0x2A5D8A0", VA = "0x182A5EAA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2A5EA70", Offset = "0x2A5D870", VA = "0x182A5EA70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x918E40", Offset = "0x917C40", VA = "0x180918E40")]
		public FDFCFIIMKEK(global::KBCPNFJHMFF<T> FFNNODKPDFM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct IOBIMIKECKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<FDFCFIIMKEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::KBCPNFJHMFF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x275BA10", Offset = "0x275A810", VA = "0x18275BA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1D089D0", Offset = "0x1D077D0", VA = "0x181D089D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct OBCCDDNLMKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<FDFCFIIMKEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::KBCPNFJHMFF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2C4F580", Offset = "0x2C4E380", VA = "0x182C4F580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1D089D0", Offset = "0x1D077D0", VA = "0x181D089D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim EEAKLOKDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T ECNOLIMJHOI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int OIIMNPAIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x234DF00", Offset = "0x234CD00", VA = "0x18234DF00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x234DFA0", Offset = "0x234CDA0", VA = "0x18234DFA0")]
	public KBCPNFJHMFF(in T ECNOLIMJHOI, int AAENDHJCHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x234E040", Offset = "0x234CE40", VA = "0x18234E040")]
	public KBCPNFJHMFF(in T ECNOLIMJHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x234DF60", Offset = "0x234CD60", VA = "0x18234DF60")]
	public FDFCFIIMKEK HBOOOOJLKJJ()
	{
		return default(FDFCFIIMKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x234DF20", Offset = "0x234CD20", VA = "0x18234DF20")]
	public FDFCFIIMKEK HBOOOOJLKJJ(CancellationToken NBLKBHANAPP)
	{
		return default(FDFCFIIMKEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x234DC30", Offset = "0x234CA30", VA = "0x18234DC30")]
	[AsyncStateMachine(typeof(global::KBCPNFJHMFF<>.IOBIMIKECKG))]
	public Task<FDFCFIIMKEK> CIFMNMGDPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x234D960", Offset = "0x234C760", VA = "0x18234D960")]
	[AsyncStateMachine(typeof(global::KBCPNFJHMFF<>.OBCCDDNLMKD))]
	public Task<FDFCFIIMKEK> CIFMNMGDPOC(CancellationToken NBLKBHANAPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DAHLJJDFHHN
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A22DD0", Offset = "0x6A21BD0", VA = "0x186A22DD0")]
	public static global::KBCPNFJHMFF<JCKJOPOBLHO> AIJMFKKLHCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A22E30", Offset = "0x6A21C30", VA = "0x186A22E30")]
	public static global::KBCPNFJHMFF<JCKJOPOBLHO> AIJMFKKLHCC(int AAENDHJCHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x22B4780", Offset = "0x22B3580", VA = "0x1822B4780")]
	public static global::KBCPNFJHMFF<T> AIJMFKKLHCC<T>(in T ECNOLIMJHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1642120", Offset = "0x1640F20", VA = "0x181642120")]
	public static global::KBCPNFJHMFF<T> AIJMFKKLHCC<T>(in T ECNOLIMJHOI, int AAENDHJCHFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EOFLJFJCCMH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> AENKGPLJGFJ(TRequest CCNKPMLIOPA, CancellationToken NBLKBHANAPP);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum ABDLLJPOEID
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class FIPEGFNKHAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float HNJMEMCFDKB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan AKNIKCIALOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int HPBBCOJHAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ABDLLJPOEID FDKDPFKFHBB;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly FIPEGFNKHAG ONJMHIPHCCM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KKIGDGKOPAE
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x2A6B0C0", Offset = "0x2A69EC0", VA = "0x182A6B0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan DCAENBLLEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2A6B210", Offset = "0x2A6A010", VA = "0x182A6B210")]
		public FIPEGFNKHAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct MCNLDBFEEKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest CCNKPMLIOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken NBLKBHANAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> AJPHIFIEFIB;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF670", Offset = "0x2CDE470", VA = "0x182CDF670")]
		public MCNLDBFEEKE(TRequest CCNKPMLIOPA, TaskCompletionSource<TResult> AJPHIFIEFIB, CancellationToken NBLKBHANAPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class OMLEJFJOHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public OMLEJFJOHNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct EMBCAGGGFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::EOFLJFJCCMH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4350880", Offset = "0x434F680", VA = "0x184350880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct CFKGPLHAEMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::EOFLJFJCCMH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private MCNLDBFEEKE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD040", Offset = "0x2DABE40", VA = "0x182DAD040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x749950", Offset = "0x748750", VA = "0x180749950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource KLCIAPFPFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<MCNLDBFEEKE> CJPCJMHLKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly FIPEGFNKHAG BIBBAKGAEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly AENKGPLJGFJ PEPCOAEMPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task OMHMBCMBOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HKCJDABPIGP;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1052740", Offset = "0x1051540", VA = "0x181052740")]
	public EOFLJFJCCMH(AENKGPLJGFJ PEPCOAEMPCI, [Optional] FIPEGFNKHAG BIBBAKGAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1051E80", Offset = "0x1050C80", VA = "0x181051E80")]
	public Task<TResult> PIBPEBKAONN(TRequest CCNKPMLIOPA, CancellationToken NBLKBHANAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1050D50", Offset = "0x104FB50", VA = "0x181050D50")]
	private void BAIBJIEKKOC(MCNLDBFEEKE OFMPMIEEMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1051B10", Offset = "0x1050910", VA = "0x181051B10")]
	[AsyncStateMachine(typeof(global::EOFLJFJCCMH<, >.EMBCAGGGFJL))]
	private Task NFIBLFIFCCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1051360", Offset = "0x1050160", VA = "0x181051360")]
	private MCNLDBFEEKE HDJFHGPNMFB()
	{
		return default(MCNLDBFEEKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x10515B0", Offset = "0x10503B0", VA = "0x1810515B0")]
	[AsyncStateMachine(typeof(global::EOFLJFJCCMH<, >.CFKGPLHAEMP))]
	private Task LJJBBGLKOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1051CE0", Offset = "0x1050AE0", VA = "0x181051CE0")]
	private void NMJGDCAFOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x1050E70", Offset = "0x104FC70", VA = "0x181050E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class EMDNNNGANEB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<T> MPMKGFKPBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private HashSet<T> DNBCEABGNNL;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool JBDIBAAJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2A46E10", Offset = "0x2A45C10", VA = "0x182A46E10", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x43518A0", Offset = "0x43506A0", VA = "0x1843518A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5D60", Offset = "0x2BC4B60", VA = "0x182BC5D60", Slot = "11")]
	public void Add(T PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x43513B0", Offset = "0x43501B0", VA = "0x1843513B0")]
	public bool NEHFKMKGDBM(T PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x43515F0", Offset = "0x43503F0", VA = "0x1843515F0", Slot = "15")]
	public bool Remove(T PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x35E3CD0", Offset = "0x35E2AD0", VA = "0x1835E3CD0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x254B990", Offset = "0x254A790", VA = "0x18254B990", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4350F40", Offset = "0x434FD40", VA = "0x184350F40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2A6DB70", Offset = "0x2A6C970", VA = "0x182A6DB70", Slot = "13")]
	public bool Contains(T PIBOOIGHJBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4350FA0", Offset = "0x434FDA0", VA = "0x184350FA0", Slot = "14")]
	public void CopyTo(T[] PALKODKBAJM, int NBMFMGFDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3E3ABF0", Offset = "0x3E399F0", VA = "0x183E3ABF0", Slot = "6")]
	public int IndexOf(T PIBOOIGHJBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4351170", Offset = "0x434FF70", VA = "0x184351170", Slot = "7")]
	public void Insert(int NNHNOIMLALG, T PIBOOIGHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4351450", Offset = "0x4350250", VA = "0x184351450", Slot = "8")]
	public void RemoveAt(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x43510A0", Offset = "0x434FEA0", VA = "0x1843510A0")]
	public void FMGGBNBEMGK(Predicate<T> MCCJOHPCLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x32C38C0", Offset = "0x32C26C0", VA = "0x1832C38C0")]
	public void NCJICEPHCBO(Comparison<T> MPNBGBNIPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4351700", Offset = "0x4350500", VA = "0x184351700")]
	public EMDNNNGANEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NIGIPJONDAE
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6A26410", Offset = "0x6A25210", VA = "0x186A26410")]
	public static Vector3 AFIGKMHDPOK(this GameObject HNLFAAIOFFP, float MCALNEIOFOB)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3860FB0", Offset = "0x385FDB0", VA = "0x183860FB0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x69AE120", Offset = "0x69ACF20", VA = "0x1869AE120")]
		public SerializedGuid(in Guid AOKEOLFIKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6A29160", Offset = "0x6A27F60", VA = "0x186A29160")]
		public static SerializedGuid JEKOONAONOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A28EB0", Offset = "0x6A27CB0", VA = "0x186A28EB0")]
		public static SerializedGuid DOIBHLOGBEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A291F0", Offset = "0x6A27FF0", VA = "0x186A291F0")]
		public bool JFJDDAHJJJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x69AE0F0", Offset = "0x69ACEF0", VA = "0x1869AE0F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A29280", Offset = "0x6A28080", VA = "0x186A29280", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A290D0", Offset = "0x6A27ED0", VA = "0x186A290D0")]
		public bool JBPDPAIMCKC(in Guid AOKEOLFIKCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A28F40", Offset = "0x6A27D40", VA = "0x186A28F40", Slot = "7")]
		public bool Equals(SerializedGuid IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A28FF0", Offset = "0x6A27DF0", VA = "0x186A28FF0", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x69AE040", Offset = "0x69ACE40", VA = "0x1869AE040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x69ADE80", Offset = "0x69ACC80", VA = "0x1869ADE80", Slot = "6")]
		public int CompareTo(SerializedGuid IDBPJJAKCBN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DIEGJBEGDPO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public readonly Type LCDPNMPCPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly string KOMACDFECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly bool HHBLPJIDBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly bool AJPBBGLECFI;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A22EA0", Offset = "0x6A21CA0", VA = "0x186A22EA0")]
	public DIEGJBEGDPO(Type MBPBFLFOKDF, string HLGLKLDEOIL, bool KMFBKCPBOKJ = false, bool NKCACOJLNNP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface FHPHCBAMONI
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface MNCDMGIOMLK<T> : FHPHCBAMONI
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool ONDIHDAIDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string JOGKFMELPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::MNCDMGIOMLK<T> OIBFJBNLMBM(Action<T> OHMKPEKDBGP);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::MNCDMGIOMLK<T> ILOLGHOOFCB(Action<T> OHMKPEKDBGP);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::MNCDMGIOMLK<T> MDKOKEOHCLB(Action<T, T> INKFCKCMDDI);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::MNCDMGIOMLK<T> IDOCGEILNFJ(Action<T, T> INKFCKCMDDI);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::MNCDMGIOMLK<T> FKLGAIFCMMF(Action<string> OIFBNFIJIMG);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MNCDMGIOMLK<T> MEKEMGMDBFM(Action<string> OIFBNFIJIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class FCANEMEKKOH<T> : global::MNCDMGIOMLK<T>, FHPHCBAMONI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private global::LEPJFHFGLAL<T, T> BPEPKHFKKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private global::JDKDAIPFIPL<T> BPJADAAEKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private global::JDKDAIPFIPL<string> NJFKKGFFCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private string DOIPIGHENCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private T AJCHMFJLMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool LLMIJIPONML;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public T KCKILJPPPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x104CC10", Offset = "0x104BA10", VA = "0x18104CC10", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ONDIHDAIDIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x823C30", Offset = "0x822A30", VA = "0x180823C30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string JOGKFMELPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x109CA20", Offset = "0x109B820", VA = "0x18109CA20", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2E17AA0", Offset = "0x2E168A0", VA = "0x182E17AA0")]
	private void KFMNCDLPMGL(T HIHKKNOLPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2E17940", Offset = "0x2E16740", VA = "0x182E17940")]
	private void JAIPJJMHIML(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2E179F0", Offset = "0x2E167F0", VA = "0x182E179F0")]
	public void JJEDLPKLPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2E17B40", Offset = "0x2E16940", VA = "0x182E17B40", Slot = "6")]
	public global::MNCDMGIOMLK<T> MDKOKEOHCLB(Action<T, T> INKFCKCMDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E178A0", Offset = "0x2E166A0", VA = "0x182E178A0", Slot = "7")]
	public global::MNCDMGIOMLK<T> IDOCGEILNFJ(Action<T, T> INKFCKCMDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2E17C00", Offset = "0x2E16A00", VA = "0x182E17C00", Slot = "4")]
	public global::MNCDMGIOMLK<T> OIBFJBNLMBM(Action<T> INKFCKCMDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2E178F0", Offset = "0x2E166F0", VA = "0x182E178F0", Slot = "5")]
	public global::MNCDMGIOMLK<T> ILOLGHOOFCB(Action<T> OHMKPEKDBGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2E17800", Offset = "0x2E16600", VA = "0x182E17800", Slot = "8")]
	public global::MNCDMGIOMLK<T> FKLGAIFCMMF(Action<string> OIFBNFIJIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2E17B90", Offset = "0x2E16990", VA = "0x182E17B90", Slot = "9")]
	public global::MNCDMGIOMLK<T> MEKEMGMDBFM(Action<string> OIFBNFIJIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2E17C90", Offset = "0x2E16A90", VA = "0x182E17C90")]
	public FCANEMEKKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class IHLHIJNJJFF
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GOHAJBCHLNI<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public global::MNCDMGIOMLK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public global::GMJOIDNGGGA<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public GOHAJBCHLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4792E20", Offset = "0x4791C20", VA = "0x184792E20")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x29280B0", Offset = "0x2926EB0", VA = "0x1829280B0")]
	public static global::OOLBMJPBBIG<T> IHLCJELLMHC<T>(this global::MNCDMGIOMLK<T> MDKBGAABEMI, Action<T> FNIOCOFMFAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class GKMALKFADNA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public readonly struct HALPHLGMPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly long FOMBMIPGNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly long GEFFLIPACKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly int LKNKGCPNOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly int BADENELIPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly bool FMIDICBJFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly string GHJDBFPIEEN;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE690", Offset = "0x3DAD490", VA = "0x183DAE690")]
		public HALPHLGMPIC(long FOMBMIPGNFE, int LKNKGCPNOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE660", Offset = "0x3DAD460", VA = "0x183DAE660")]
		public HALPHLGMPIC(long FOMBMIPGNFE, long GEFFLIPACKF, int LKNKGCPNOMD, int BADENELIPFJ, bool FMIDICBJFKD, string GHJDBFPIEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE510", Offset = "0x3DAD310", VA = "0x183DAE510")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void HGLBGIBMGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE610", Offset = "0x3DAD410", VA = "0x183DAE610")]
		public int LPFMBLPGMPP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE480", Offset = "0x3DAD280", VA = "0x183DAE480")]
		public int CHGCFABCNNJ(int GAPPJLGJBLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE4A0", Offset = "0x3DAD2A0", VA = "0x183DAE4A0")]
		public double DFPHDKEOIFO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3DAE580", Offset = "0x3DAD380", VA = "0x183DAE580")]
		public HALPHLGMPIC KALFICCGLJO(long GEFFLIPACKF, int BADENELIPFJ)
		{
			return default(HALPHLGMPIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class EHEFPJIJJBB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly TKey MPJCJINPOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly global::GKMALKFADNA<TKey> NBINANLIAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private List<EHEFPJIJJBB> OGHKDNEBKLA;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string IGPACPLJCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2353D70", Offset = "0x2352B70", VA = "0x182353D70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x322BBF0", Offset = "0x322A9F0", VA = "0x18322BBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IEnumerable<EHEFPJIJJBB> BJGJELGHKHB
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x322BD30", Offset = "0x322AB30", VA = "0x18322BD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public HALPHLGMPIC GOHEDKOFFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x17C11A0", Offset = "0x17BFFA0", VA = "0x1817C11A0")]
			[CompilerGenerated]
			get
			{
				return default(HALPHLGMPIC);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x322BD50", Offset = "0x322AB50", VA = "0x18322BD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x322BE60", Offset = "0x322AC60", VA = "0x18322BE60")]
		internal EHEFPJIJJBB(global::GKMALKFADNA<TKey> NBINANLIAKB, TKey JHANOPJHOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x322BC20", Offset = "0x322AA20", VA = "0x18322BC20")]
		public EHEFPJIJJBB GJCPDNFCGNA(TKey JHANOPJHOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x322BD80", Offset = "0x322AB80", VA = "0x18322BD80")]
		public void PNGOLAFICGF(TKey JHANOPJHOLP, Action<EHEFPJIJJBB> JBJAGOLOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C79940", Offset = "0x2C78740", VA = "0x182C79940")]
		public T PNGOLAFICGF<T>(TKey JHANOPJHOLP, Func<EHEFPJIJJBB, T> PFGGBMFPGEK)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C797D0", Offset = "0x2C785D0", VA = "0x182C797D0")]
		[AsyncStateMachine(typeof(LCKONJFBJEP))]
		public Task<T> IGMLKIADKML<T>(TKey JHANOPJHOLP, Func<EHEFPJIJJBB, Task<T>> PFGGBMFPGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x322BA40", Offset = "0x322A840", VA = "0x18322BA40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FPAELEGCNJN : IEnumerable<(TKey, List<TKey>, HALPHLGMPIC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HALPHLGMPIC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private (TKey key, List<TKey> path, HALPHLGMPIC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public global::GKMALKFADNA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private IEnumerator<(TKey key, List<TKey> path, HALPHLGMPIC timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private (TKey, List<TKey>, HALPHLGMPIC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2842090", Offset = "0x2840E90", VA = "0x182842090", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HALPHLGMPIC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BB2B10", Offset = "0x2BB1910", VA = "0x182BB2B10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x28422F0", Offset = "0x28410F0", VA = "0x1828422F0")]
		[DebuggerHidden]
		public FPAELEGCNJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4510", Offset = "0x1DF3310", VA = "0x181DF4510", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2760", Offset = "0x2BB1560", VA = "0x182BB2760", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2B70", Offset = "0x2BB1970", VA = "0x182BB2B70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2AD0", Offset = "0x2BB18D0", VA = "0x182BB2AD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2A10", Offset = "0x2BB1810", VA = "0x182BB2A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HALPHLGMPIC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x25647D0", Offset = "0x25635D0", VA = "0x1825647D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class LBPAGDDAGFJ : IEnumerable<(TKey, List<TKey>, HALPHLGMPIC)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HALPHLGMPIC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private (TKey key, List<TKey> path, HALPHLGMPIC timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private EHEFPJIJJBB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public EHEFPJIJJBB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public global::GKMALKFADNA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IEnumerator<EHEFPJIJJBB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private IEnumerator<(TKey key, List<TKey> path, HALPHLGMPIC timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private (TKey, List<TKey>, HALPHLGMPIC) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2842090", Offset = "0x2840E90", VA = "0x182842090", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HALPHLGMPIC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2842130", Offset = "0x2840F30", VA = "0x182842130", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x28422F0", Offset = "0x28410F0", VA = "0x1828422F0")]
		[DebuggerHidden]
		public LBPAGDDAGFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2842190", Offset = "0x2840F90", VA = "0x182842190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x2841A10", Offset = "0x2840810", VA = "0x182841A10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2842230", Offset = "0x2841030", VA = "0x182842230")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2842290", Offset = "0x2841090", VA = "0x182842290")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x28420F0", Offset = "0x2840EF0", VA = "0x1828420F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x2841FB0", Offset = "0x2840DB0", VA = "0x182841FB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HALPHLGMPIC)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x28420C0", Offset = "0x2840EC0", VA = "0x1828420C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Action<TKey, HALPHLGMPIC> JIIIMAOMJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Action<TKey, HALPHLGMPIC> AFBAAGCAFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Action<global::GKMALKFADNA<TKey>> OEDFCIJGCEA;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const string FMCKMJFMAKL = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly EHEFPJIJJBB FJFMONDICFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool OCJGGEPKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int AGDDDFGHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly Stopwatch CILOCLCFEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly int BEODFHIGNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private string AOLMCJGMKFK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EHEFPJIJJBB KPDHDIJGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x75BA70", Offset = "0x75A870", VA = "0x18075BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	[NotNull]
	public string IGPACPLJCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x38B9EA0", Offset = "0x38B8CA0", VA = "0x1838B9EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long BKGLADJPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x38B9D50", Offset = "0x38B8B50", VA = "0x1838B9D50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int EKKFPEOPHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x38B9F20", Offset = "0x38B8D20", VA = "0x1838B9F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x38BA0B0", Offset = "0x38B8EB0", VA = "0x1838BA0B0")]
	public GKMALKFADNA(TKey FLJDKCEGFEG, [Optional] int? LKNKGCPNOMD, [Optional][CanBeNull] Stopwatch CILOCLCFEGM, [Optional] Action<TKey, HALPHLGMPIC> JIIIMAOMJHO, [Optional] Action<TKey, HALPHLGMPIC> AFBAAGCAFML, [Optional] Action<global::GKMALKFADNA<TKey>> OEDFCIJGCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x38B9DF0", Offset = "0x38B8BF0", VA = "0x1838B9DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x38B9F00", Offset = "0x38B8D00", VA = "0x1838B9F00")]
	public void JPDIKLAPKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x38B9E80", Offset = "0x38B8C80", VA = "0x1838B9E80")]
	public void FIDNFMBMNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x38B9F50", Offset = "0x38B8D50", VA = "0x1838B9F50")]
	[IteratorStateMachine(typeof(global::GKMALKFADNA<>.FPAELEGCNJN))]
	public IEnumerable<(TKey, List<TKey>, HALPHLGMPIC)> NGJJHOFJALL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x38B9FE0", Offset = "0x38B8DE0", VA = "0x1838B9FE0")]
	[IteratorStateMachine(typeof(global::GKMALKFADNA<>.LBPAGDDAGFJ))]
	private IEnumerable<(TKey, List<TKey>, HALPHLGMPIC)> NGJJHOFJALL(List<TKey> DIHIPMILEPF, EHEFPJIJJBB MLAEAPNOKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x38B9D70", Offset = "0x38B8B70", VA = "0x1838B9D70")]
	private (long, int) CKLNJAMEDDO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class BEIIJHLPLAG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JCPLFMJBPJE(global::GKMALKFADNA<TKey> NBINANLIAKB);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
	protected BEIIJHLPLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class FEKKNBCIADI<TKey> : global::BEIIJHLPLAG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate string JKOHBLLEILP(TKey JHANOPJHOLP);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A63450", Offset = "0x2A62250", VA = "0x182A63450")]
	protected string ANPOEHGIGPB(double MICDKDOJADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A634C0", Offset = "0x2A622C0", VA = "0x182A634C0")]
	protected string JBPMPCKICHM(int EBGFJLADMEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A63700", Offset = "0x2A62500", VA = "0x182A63700")]
	private static string LPNCEPBNGOH(TKey JHANOPJHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A63650", Offset = "0x2A62450", VA = "0x182A63650", Slot = "4")]
	public override string JCPLFMJBPJE(global::GKMALKFADNA<TKey> NBINANLIAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2A63520", Offset = "0x2A62320", VA = "0x182A63520")]
	public string JCPLFMJBPJE(global::GKMALKFADNA<TKey> NBINANLIAKB, [NotNull] JKOHBLLEILP MJHGPGMEBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EIIMGPMMBOI(global::GKMALKFADNA<TKey> NBINANLIAKB, [NotNull] JKOHBLLEILP MJHGPGMEBFP);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5090", Offset = "0x1DF3E90", VA = "0x181DF5090")]
	protected FEKKNBCIADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class ADMFCBBGGHC<TKey> : global::BEIIJHLPLAG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate string OHKLFBOFOFB(TKey JHANOPJHOLP);

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private const int NDKCFDFEEOG = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly string GBBLIEJKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly double JKIPNMNINDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly bool EPNPJEPKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int BJGHOIEPDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ISet<string> FCJBDJHDMNL;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0A50", Offset = "0x2B9F850", VA = "0x182BA0A50")]
	private static string LPNCEPBNGOH(TKey JHANOPJHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0C10", Offset = "0x2B9FA10", VA = "0x182BA0C10")]
	public ADMFCBBGGHC(string GBBLIEJKNDN = "F2", double JKIPNMNINDI = double.MaxValue, bool EPNPJEPKPLF = false, int BJGHOIEPDPB = int.MaxValue, [Optional] ISet<string> FCJBDJHDMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0460", Offset = "0x2B9F260", VA = "0x182BA0460", Slot = "4")]
	public override Dictionary<string, string> JCPLFMJBPJE(global::GKMALKFADNA<TKey> NBINANLIAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2BA01D0", Offset = "0x2B9EFD0", VA = "0x182BA01D0")]
	private bool COGKMCEBFGB(string LKKMBJPBHKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0510", Offset = "0x2B9F310", VA = "0x182BA0510")]
	public Dictionary<string, string> JCPLFMJBPJE(global::GKMALKFADNA<TKey> NBINANLIAKB, OHKLFBOFOFB MJHGPGMEBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2BA02B0", Offset = "0x2B9F0B0", VA = "0x182BA02B0")]
	private string IJNIIKDHBIP(StringBuilder BAFHPJHBBKH, List<TKey> LLEBCJLMNPL, OHKLFBOFOFB MJHGPGMEBFP, bool DIMNIJELOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0A90", Offset = "0x2B9F890", VA = "0x182BA0A90")]
	private static void PLPOBJPMBMN(StringBuilder JCFDDIBNINF, string OBHNDKJPJCE, bool OHNEAICEKAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EDFMEHEANCH<TKey> : global::FEKKNBCIADI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct BGOADDCJPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public JKOHBLLEILP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public static global::EDFMEHEANCH<TKey> NHLDGJJELOO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private const int FLFNICPHNHE = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly string[] MMDHCBLAHOM;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x321D100", Offset = "0x321BF00", VA = "0x18321D100")]
	private EDFMEHEANCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x321C0B0", Offset = "0x321AEB0", VA = "0x18321C0B0", Slot = "5")]
	protected override string EIIMGPMMBOI(global::GKMALKFADNA<TKey> NBINANLIAKB, JKOHBLLEILP MJHGPGMEBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x321BFC0", Offset = "0x321ADC0", VA = "0x18321BFC0")]
	[CompilerGenerated]
	internal static string ACOLBHBDIJO(string IHCECLAGBEL, TKey JHANOPJHOLP, ref BGOADDCJPBD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MPBGEBLGAMG<TKey> : global::FEKKNBCIADI<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class MKIAMKCBLHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public JKOHBLLEILP keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public MKIAMKCBLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2562CE0", Offset = "0x2561AE0", VA = "0x182562CE0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x30DA250", Offset = "0x30D9050", VA = "0x1830DA250", Slot = "5")]
	protected override string EIIMGPMMBOI(global::GKMALKFADNA<TKey> NBINANLIAKB, JKOHBLLEILP MJHGPGMEBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x30DAB40", Offset = "0x30D9940", VA = "0x1830DAB40")]
	public MPBGEBLGAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class BMIMNEOCMDO : global::GKMALKFADNA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class ICAJJBHMJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Action<BMIMNEOCMDO> callback;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ICAJJBHMJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6A245A0", Offset = "0x6A233A0", VA = "0x186A245A0")]
		internal void <Wrap>b__0(global::GKMALKFADNA<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6A22690", Offset = "0x6A21490", VA = "0x186A22690")]
	public BMIMNEOCMDO([Optional] string NGJPKKLJDGE, [Optional] int? LKNKGCPNOMD, [Optional] Stopwatch CILOCLCFEGM, [Optional] Action<string, HALPHLGMPIC> JIIIMAOMJHO, [Optional] Action<string, HALPHLGMPIC> AFBAAGCAFML, [Optional] Action<BMIMNEOCMDO> OEDFCIJGCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6A225B0", Offset = "0x6A213B0", VA = "0x186A225B0")]
	private static Action<global::GKMALKFADNA<string>> PNGOLAFICGF(Action<BMIMNEOCMDO> FNIOCOFMFAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class JHAKKDBIHAK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private class GONBIJEMCFM : JHAKKDBIHAK
	{
		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static JHAKKDBIHAK NHLDGJJELOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6A24310", Offset = "0x6A23110", VA = "0x186A24310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override DateTime BFPFEMJMLLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6A242C0", Offset = "0x6A230C0", VA = "0x186A242C0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public override float EKFJEPPGICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xF0CCD0", Offset = "0xF0BAD0", VA = "0x180F0CCD0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6A24410", Offset = "0x6A23210", VA = "0x186A24410")]
		public GONBIJEMCFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static JHAKKDBIHAK AIBJFKHEIDA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public static JHAKKDBIHAK ONJMHIPHCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6A24630", Offset = "0x6A23430", VA = "0x186A24630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract DateTime BFPFEMJMLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public abstract float EKFJEPPGICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	protected JHAKKDBIHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KCIGOCJCKMA : global::GBPJKALAPEA<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6A24FA0", Offset = "0x6A23DA0", VA = "0x186A24FA0")]
	public KCIGOCJCKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class GBPJKALAPEA<T> : global::BLENMGIJHFH<T>, KMLDHBEBAEG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Task<T> OOIHGHGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private Task KNBECMBFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x168F9D0", Offset = "0x168E7D0", VA = "0x18168F9D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public global::OOLBMJPBBIG<T> ICPDCDPBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private PONAFBMJJFC NLIAMNCLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x109C9F0", Offset = "0x109B7F0", VA = "0x18109C9F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x3C948A0", Offset = "0x3C936A0", VA = "0x183C948A0")]
	public GBPJKALAPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class MMNLLGPLPBO : global::KDMEMPIPHLG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6A25250", Offset = "0x6A24050", VA = "0x186A25250")]
	public MMNLLGPLPBO(Exception EBHODPHNEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class KDMEMPIPHLG<T> : global::BLENMGIJHFH<T>, KMLDHBEBAEG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Task<T> OOIHGHGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private Task KNBECMBFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x168F9D0", Offset = "0x168E7D0", VA = "0x18168F9D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public global::OOLBMJPBBIG<T> ICPDCDPBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private PONAFBMJJFC NLIAMNCLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x109C9F0", Offset = "0x109B7F0", VA = "0x18109C9F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2351EC0", Offset = "0x2350CC0", VA = "0x182351EC0")]
	public KDMEMPIPHLG(Exception EBHODPHNEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KMLDHBEBAEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	[NotNull]
	Task OOIHGHGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	[NotNull]
	PONAFBMJJFC ICPDCDPBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface BLENMGIJHFH<T> : KMLDHBEBAEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	[NotNull]
	new Task<T> OOIHGHGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	[NotNull]
	new global::OOLBMJPBBIG<T> ICPDCDPBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class HLEGEDHGFLG<TTask, T> : global::BLENMGIJHFH<T>, KMLDHBEBAEG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class PLGJAKHNONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public global::HLEGEDHGFLG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public PLGJAKHNONN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static bool PFLLCIKIAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Task<T> LEGNJFDJJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	protected readonly CancellationTokenSource BCHDMIKMMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private bool OCJGGEPKHAO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Task<T> OOIHGHGIBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private Task KNBECMBFIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public global::OOLBMJPBBIG<T> ICPDCDPBMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private PONAFBMJJFC NLIAMNCLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1FFAD00", Offset = "0x1FF9B00", VA = "0x181FFAD00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool EFIIIACBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x35ED320", Offset = "0x35EC120", VA = "0x1835ED320")]
	static HLEGEDHGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x35ED600", Offset = "0x35EC400", VA = "0x1835ED600")]
	protected HLEGEDHGFLG(TTask LEGNJFDJJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x35ECDA0", Offset = "0x35EBBA0", VA = "0x1835ECDA0", Slot = "1")]
	~HLEGEDHGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x35ECD70", Offset = "0x35EBB70", VA = "0x1835ECD70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x35ECFE0", Offset = "0x35EBDE0", VA = "0x1835ECFE0")]
	private void NFGECJODELA(bool JLNCFEJCDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T IMPNKCPNJKF(TTask ONAMIFFIANJ);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KKCJHACJIOO();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class EDCBFECCBDP
{
	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6A231F0", Offset = "0x6A21FF0", VA = "0x186A231F0")]
	[NotNull]
	public static byte[] EDBMICBJHJF(this AMFMKIHJLLF AKNFHFLBDHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6A23260", Offset = "0x6A22060", VA = "0x186A23260")]
	[NotNull]
	public static byte[] EDBMICBJHJF(this AMFMKIHJLLF AKNFHFLBDHM, HashAlgorithmName ABHBKCOACME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6A232D0", Offset = "0x6A220D0", VA = "0x186A232D0")]
	public static bool HPNMKEAIGHF([CanBeNull] this AMFMKIHJLLF AKNFHFLBDHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A23460", Offset = "0x6A22260", VA = "0x186A23460")]
	public static bool HPNMKEAIGHF([CanBeNull] this AMFMKIHJLLF AKNFHFLBDHM, out string DOIPIGHENCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A23180", Offset = "0x6A21F80", VA = "0x186A23180")]
	private static string AOGFPFBJDJD([CanBeNull] byte[] EMGPHLLIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A23600", Offset = "0x6A22400", VA = "0x186A23600")]
	private static bool PAIMBNMPOAB([NotNull] AMFMKIHJLLF AKNFHFLBDHM, [CanBeNull] out byte[] JAMNAPIFAFB, [CanBeNull] out byte[] CKEBLDJKCND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class DMKKEGDIIEI
{
	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A23140", Offset = "0x6A21F40", VA = "0x186A23140")]
	[NotNull]
	public static byte[] EDBMICBJHJF(this JLHDIDPEOBN ACCNCJEDOEJ, byte[] GOILDLCDPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A22F10", Offset = "0x6A21D10", VA = "0x186A22F10")]
	[NotNull]
	public static byte[] EDBMICBJHJF(this JLHDIDPEOBN ACCNCJEDOEJ, HashAlgorithmName ABHBKCOACME, byte[] GOILDLCDPMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface JLHDIDPEOBN
{
	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash PHHBPOOMOKI);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public interface AMFMKIHJLLF : JLHDIDPEOBN
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[CanBeNull]
	byte[] PFPMLDGHJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	[CanBeNull]
	byte[] NMDDJBDNMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	UnityEngine.Object AGKFPAFCEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class NEALEALGFAP
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	private class JJFILCBJKJJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6A24820", Offset = "0x6A23620", VA = "0x186A24820")]
		public JJFILCBJKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6A247C0", Offset = "0x6A235C0", VA = "0x186A247C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const byte DPNOEKBLDHI = 1;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private const byte PGFHCKAEGEP = 0;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ArrayPool<byte> MGOHFCADPFI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool JBOHCAKGGLB;

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3486D10", Offset = "0x3485B10", VA = "0x183486D10")]
	[Conditional("UNITY_EDITOR")]
	private static void LDFEDBAPOHF<T>(params T[] BJJCLAOMKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6A25B10", Offset = "0x6A24910", VA = "0x186A25B10")]
	public static IDisposable HAJMKAKOLBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6A252A0", Offset = "0x6A240A0", VA = "0x186A252A0")]
	public static void AHNBPGKCLJG(this IncrementalHash KBACBBBJPMI, [CanBeNull] GameObject HNLFAAIOFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x34860F0", Offset = "0x3484EF0", VA = "0x1834860F0")]
	public static void AHNBPGKCLJG<T>(this IncrementalHash KBACBBBJPMI, [CanBeNull] T KHJAOGDHEIM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x3487000", Offset = "0x3485E00", VA = "0x183487000")]
	public static void POCBKEOOHPI<T>(this IncrementalHash KBACBBBJPMI, [CanBeNull] T ACCNCJEDOEJ) where T : JLHDIDPEOBN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x34861C0", Offset = "0x3484FC0", VA = "0x1834861C0")]
	public static void CKGFCMEGMBH<T>(this IncrementalHash KBACBBBJPMI, [CanBeNull] IList<T> KCKBNMJKHBH) where T : JLHDIDPEOBN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6A25730", Offset = "0x6A24530", VA = "0x186A25730")]
	private static bool APHGFLEBADH([CanBeNull] JLHDIDPEOBN ACCNCJEDOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6A25EB0", Offset = "0x6A24CB0", VA = "0x186A25EB0")]
	public static void LPBLBGGCDOK(this IncrementalHash PHHBPOOMOKI, [CanBeNull] string AJOAOKCICCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6A25390", Offset = "0x6A24190", VA = "0x186A25390")]
	public static void AIPHOAMFJPA(this IncrementalHash PHHBPOOMOKI, long OJDEAEMLJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x6A25560", Offset = "0x6A24360", VA = "0x186A25560")]
	public static void ALELPHKPOEP(this IncrementalHash PHHBPOOMOKI, int KIINNPINIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6A25BB0", Offset = "0x6A249B0", VA = "0x186A25BB0")]
	public static void IOJKPGFPDLC(this IncrementalHash PHHBPOOMOKI, short FKLABINNAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6A25930", Offset = "0x6A24730", VA = "0x186A25930")]
	public static void CMBJLCPJOHH(this IncrementalHash PHHBPOOMOKI, byte HDACJBFMNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6A25F70", Offset = "0x6A24D70", VA = "0x186A25F70")]
	public static void OGMKAMFADOH(this IncrementalHash PHHBPOOMOKI, bool KNMODDBEGOM, bool JDEAAAJJCIN = false, bool PNCKCKAFDEC = false, bool GGDAKJOHMGK = false, bool EIGMKIAGMOK = false, bool OHJIDDCDKFN = false, bool HNMHEGAFKKH = false, bool GNFNPHAHKNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3486620", Offset = "0x3485420", VA = "0x183486620")]
	public static void EFMAKKKPCPI<T>(this IncrementalHash PHHBPOOMOKI, T MKKOHAABCOB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6A25D80", Offset = "0x6A24B80", VA = "0x186A25D80")]
	public static void JIEBPBPPODK(this IncrementalHash PHHBPOOMOKI, float HDLKKCPFMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6A25DE0", Offset = "0x6A24BE0", VA = "0x186A25DE0")]
	public static void LJNAEPLKECF(this IncrementalHash PHHBPOOMOKI, double OMICNEAGJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6A25E40", Offset = "0x6A24C40", VA = "0x186A25E40")]
	public static void LODDHHOLPEA(this IncrementalHash PHHBPOOMOKI, ulong MGGAIOBOHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6A25F10", Offset = "0x6A24D10", VA = "0x186A25F10")]
	public static void NCABBNPNJKF(this IncrementalHash PHHBPOOMOKI, uint MKOJPKJLDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6A25AA0", Offset = "0x6A248A0", VA = "0x186A25AA0")]
	public static void DJCGJOMLLFO(this IncrementalHash PHHBPOOMOKI, ushort KDHJDLKJNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6A257C0", Offset = "0x6A245C0", VA = "0x186A257C0")]
	public static void CJLKALELJKA(this IncrementalHash PHHBPOOMOKI, Vector3 OPIKKOBBPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6A26140", Offset = "0x6A24F40", VA = "0x186A26140")]
	public static void PCLCEBEOLBI(this IncrementalHash PHHBPOOMOKI, Quaternion ECJJPAHFIFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class HLAFFGGOGMB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly Type LCDPNMPCPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly string KOMACDFECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly bool HHBLPJIDBGC;

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6A24540", Offset = "0x6A23340", VA = "0x186A24540")]
	public HLAFFGGOGMB(Type MBPBFLFOKDF, string HLGLKLDEOIL, bool KMFBKCPBOKJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KGAAEIKFJPE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6A24FE0", Offset = "0x6A23DE0", VA = "0x186A24FE0")]
	public KGAAEIKFJPE(string GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x6A25050", Offset = "0x6A23E50", VA = "0x186A25050")]
	public KGAAEIKFJPE(string GPAOLHFLBHD, Exception HJNEAIFJHLM)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x757920", Offset = "0x756720", VA = "0x180757920")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public T this[int FCPPLBLBJIC, int ANLNDCJMNDD]
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x394B1B0", Offset = "0x3949FB0", VA = "0x18394B1B0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x394B250", Offset = "0x394A050", VA = "0x18394B250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x394B120", Offset = "0x3949F20", VA = "0x18394B120")]
		public Array2D(uint NMEFFJNNPPL, uint FPELGIFOMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x394B0A0", Offset = "0x3949EA0", VA = "0x18394B0A0")]
		public void ODCBHOABBME()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6A22550", Offset = "0x6A21350", VA = "0x186A22550")]
		public Array2DVector3(uint NMEFFJNNPPL, uint FPELGIFOMNB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal static class ELIEJGHOLBC
{
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public const int CKFDNMPOFCN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public const int AJLEIINCHEC = 0;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class PMBPJEJLGAL<THandle, TValue> : IDisposable where THandle : struct, JMOHLFDBGCE where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<THandle> JDFFPELNHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly List<TValue> HEJNPPKNAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Func<TValue> EODKHJOJBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Action<TValue> CFLMPABIGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int KDGDJHCJKFF;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public TValue BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x3166C20", Offset = "0x3165A20", VA = "0x183166C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x399E8E0", Offset = "0x399D6E0", VA = "0x18399E8E0")]
	public PMBPJEJLGAL(Action<TValue> CFLMPABIGDM, [Optional] Func<TValue> EODKHJOJBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x399E230", Offset = "0x399D030", VA = "0x18399E230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x399E030", Offset = "0x399CE30", VA = "0x18399E030")]
	public THandle CJALKNOJAHB()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x399E870", Offset = "0x399D670", VA = "0x18399E870")]
	public THandle OEECIDDHIAM(TValue MGFMONLLLPD)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x399E0D0", Offset = "0x399CED0", VA = "0x18399E0D0")]
	public bool CJGLMEKHGBL(THandle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x399E680", Offset = "0x399D480", VA = "0x18399E680")]
	public bool LGPDJPMAIOD(THandle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x399E2C0", Offset = "0x399D0C0", VA = "0x18399E2C0")]
	public bool EHAPPLAHJDF(THandle EAHLOGLBEGD, out TValue MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x399DE60", Offset = "0x399CC60", VA = "0x18399DE60")]
	public TValue BANNGLOAJDI(THandle EAHLOGLBEGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x399E5D0", Offset = "0x399D3D0", VA = "0x18399E5D0")]
	public bool LCHDIFCJOJC(THandle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x399DD60", Offset = "0x399CB60", VA = "0x18399DD60")]
	private THandle ACDMPMFCFOI(int NNHNOIMLALG)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x399E4E0", Offset = "0x399D2E0", VA = "0x18399E4E0")]
	private TValue IHLCJELLMHC(int NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x399DEB0", Offset = "0x399CCB0", VA = "0x18399DEB0")]
	private void BLGBOKEACBI(int NNHNOIMLALG, in THandle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x399E590", Offset = "0x399D390", VA = "0x18399E590")]
	private void KFMNCDLPMGL(int NNHNOIMLALG, in TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x399E760", Offset = "0x399D560", VA = "0x18399E760")]
	private THandle NOLJPLFHLEG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x399E180", Offset = "0x399CF80", VA = "0x18399E180")]
	private void DKLIEMABGIB(THandle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x399E750", Offset = "0x399D550", VA = "0x18399E750")]
	private int LILLJHKHJNM(int HHCMOLFBCEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x399E2B0", Offset = "0x399D0B0", VA = "0x18399E2B0")]
	private bool EAMDJIMGCPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7A8710", Offset = "0x7A7510", VA = "0x1807A8710")]
	private void PBPMOAHFGFJ(THandle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x399E510", Offset = "0x399D310", VA = "0x18399E510")]
	private bool JFOCEMDEOIF(out THandle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x399DD90", Offset = "0x399CB90", VA = "0x18399DD90")]
	private bool AOLDNIOMFHA(out THandle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x399E360", Offset = "0x399D160", VA = "0x18399E360")]
	private void FPLOIMPKNIO(THandle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x399E3C0", Offset = "0x399D1C0", VA = "0x18399E3C0")]
	private void GKBOHCLLODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public interface JMOHLFDBGCE
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int CEEBBJGGBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int KAKKJFDONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface BIINDPJIKMP<T> : JMOHLFDBGCE, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class CBFEGAEIGAK
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xD72FF0", Offset = "0xD71DF0", VA = "0x180D72FF0")]
	public static bool EKOLJFBDNHK<T>(this T EAHLOGLBEGD, T IDBPJJAKCBN) where T : struct, JMOHLFDBGCE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x2606930", Offset = "0x2605730", VA = "0x182606930")]
	public static bool EMDPCLDELLN<T>(this T EAHLOGLBEGD) where T : struct, JMOHLFDBGCE
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A227E0", Offset = "0x6A215E0", VA = "0x186A227E0")]
	public static string HAFPKMPMAIL(this JMOHLFDBGCE EAHLOGLBEGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class OFKAHNHENIC
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private enum BMIIJJJEBCA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int PHHBPOOMOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private bool FAMLEPLKMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private BMIIJJJEBCA GMDALJMBJKE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool KLPFABJKKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A27330", Offset = "0x6A26130", VA = "0x186A27330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool IEFCKKNMIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A27380", Offset = "0x6A26180", VA = "0x186A27380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A27790", Offset = "0x6A26590", VA = "0x186A27790")]
	public OFKAHNHENIC(bool FAMLEPLKMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A26CB0", Offset = "0x6A25AB0", VA = "0x186A26CB0")]
	public void DOCAGNHEHPM(object OJGAEOFIMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A27530", Offset = "0x6A26330", VA = "0x186A27530")]
	public void MEKDGFFCFCI(int MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A26930", Offset = "0x6A25730", VA = "0x186A26930")]
	public void CIEIBEANELP(uint IGPBFEAKIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A27770", Offset = "0x6A26570", VA = "0x186A27770")]
	public void PGIFIDONLNO(bool BEKMNJEEFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A27730", Offset = "0x6A26530", VA = "0x186A27730")]
	public void OODLPOJNDCJ(long DEDKHJMMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A27340", Offset = "0x6A26140", VA = "0x186A27340")]
	public void ICLCNEKPJMO(ulong CJFPOEOKKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A275D0", Offset = "0x6A263D0", VA = "0x186A275D0")]
	public void MEOAFHJBOAM(string MDIBKHINKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A268A0", Offset = "0x6A256A0", VA = "0x186A268A0")]
	public void BKODLJEBOBL(Enum EBHODPHNEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A27390", Offset = "0x6A26190", VA = "0x186A27390")]
	public void JAAMOPOLCBO(IList MPMKGFKPBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2AD1F90", Offset = "0x2AD0D90", VA = "0x182AD1F90")]
	public void IGDMCOGKPHG<T, U>(Dictionary<T, U> MIPMPMPNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A26940", Offset = "0x6A25740", VA = "0x186A26940")]
	private void DNJMDHJHNCB(IDictionary MIPMPMPNMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A27640", Offset = "0x6A26440", VA = "0x186A27640")]
	public int NKAOLCDPCIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A276B0", Offset = "0x6A264B0", VA = "0x186A276B0")]
	public short OAHINLHHDCJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A27720", Offset = "0x6A26520", VA = "0x186A27720")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A274C0", Offset = "0x6A262C0", VA = "0x186A274C0")]
	private void KFMFPDDAJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class FFMKAEBMFFM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal class MPAHIBCKGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public TNode LCNEHOGIJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public TNode GANAMHNGMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public JNMOEIFIIFK CHMGCHLLEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public List<JNMOEIFIIFK> EEKCPLPDOJB;

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public MPAHIBCKGLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal struct JNMOEIFIIFK : IComparable<JNMOEIFIIFK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int OBAOEICHDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public TClaimant OHIACKAIJJD;

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x76C240", Offset = "0x76B040", VA = "0x18076C240")]
		public JNMOEIFIIFK(int OBAOEICHDDL, TClaimant OHIACKAIJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x26CD7C0", Offset = "0x26CC5C0", VA = "0x1826CD7C0")]
		public bool IMHLLGDLLHN(in JNMOEIFIIFK IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x26CD820", Offset = "0x26CC620", VA = "0x1826CD820")]
		public bool JNDJMIMKDOH(in JNMOEIFIIFK IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x26CD7B0", Offset = "0x26CC5B0", VA = "0x1826CD7B0", Slot = "4")]
		public int CompareTo(JNMOEIFIIFK IDBPJJAKCBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x26CD830", Offset = "0x26CC630", VA = "0x1826CD830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum LOLHMNDNFAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class CJEIJOEEOBF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public global::FFMKAEBMFFM<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E00060", Offset = "0x1DFEE60", VA = "0x181E00060")]
		[DebuggerHidden]
		public CJEIJOEEOBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DB9720", Offset = "0x2DB8520", VA = "0x182DB9720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2DB98E0", Offset = "0x2DB86E0", VA = "0x182DB98E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DB9800", Offset = "0x2DB8600", VA = "0x182DB9800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x109AEF0", Offset = "0x1099CF0", VA = "0x18109AEF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly global::JGHAJNCBKBF<MPAHIBCKGLA> CPANFMIHENA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly global::JGHAJNCBKBF<List<JNMOEIFIIFK>> DBBCFIBEGKN;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static int BKPDOOCLHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	internal readonly Dictionary<TClaimant, TNode> GEEHCKIALFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	internal readonly Dictionary<TNode, MPAHIBCKGLA> EAGEOAAGHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LOLHMNDNFAI LHDFDDPEACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private bool LINNMJPFKHN;

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GDGNMAEBLIK(TNode IEAGANOGPLL);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JPHGBJNIAEE(TNode IEAGANOGPLL, TClaimant KCJAPNKKAJG, TClaimant HBGIFACMIEG);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A66BF0", Offset = "0x2A659F0", VA = "0x182A66BF0")]
	public FFMKAEBMFFM(LOLHMNDNFAI LHDFDDPEACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A66A10", Offset = "0x2A65810", VA = "0x182A66A10")]
	public void PDAFGCOBION(TNode IEAGANOGPLL, TNode EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2A65700", Offset = "0x2A64500", VA = "0x182A65700")]
	public void AFNNIOBFKPP(TClaimant OHIACKAIJJD, TNode AOOGMKJCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A65E80", Offset = "0x2A64C80", VA = "0x182A65E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A668B0", Offset = "0x2A656B0", VA = "0x182A668B0")]
	private void MMDAPMDAJGE(TClaimant OHIACKAIJJD, TNode ALDGPDEGCJB, TNode AOOGMKJCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A666C0", Offset = "0x2A654C0", VA = "0x182A666C0")]
	private int LDEFEIHBLCC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A65A10", Offset = "0x2A64810", VA = "0x182A65A10")]
	private void CKCHGCOAMJI(TClaimant OHIACKAIJJD, TNode IGNFAGJIOLA, TNode DEKNDEIHCLP, int CCCEGCDAANF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A66630", Offset = "0x2A65430", VA = "0x182A66630")]
	private void KOKCCMGOBCA(JNMOEIFIIFK FEKIGDFPMHN, MPAHIBCKGLA LPFENKMFEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A654A0", Offset = "0x2A642A0", VA = "0x182A654A0")]
	private void AAKAMOKOJGG(TClaimant OHIACKAIJJD, TNode IGNFAGJIOLA, TNode DEKNDEIHCLP, int CCCEGCDAANF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A661B0", Offset = "0x2A64FB0", VA = "0x182A661B0")]
	private void KBBJCAJODFM(JNMOEIFIIFK FEKIGDFPMHN, TNode IEAGANOGPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A65800", Offset = "0x2A64600", VA = "0x182A65800")]
	private void AFOAPCDEPHG(JNMOEIFIIFK FEKIGDFPMHN, MPAHIBCKGLA LPFENKMFEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A65900", Offset = "0x2A64700", VA = "0x182A65900")]
	private void BGIKJLDJOPI(MPAHIBCKGLA LPFENKMFEII, bool AEHBJLODAHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A662C0", Offset = "0x2A650C0", VA = "0x182A662C0")]
	private void KLLHOKMCKKG(MPAHIBCKGLA LPFENKMFEII, TNode EBAJDMMJHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A660E0", Offset = "0x2A64EE0", VA = "0x182A660E0")]
	[IteratorStateMachine(typeof(global::FFMKAEBMFFM<, >.CJEIJOEEOBF))]
	private IEnumerable<TNode> JOIIHBDGHGO(TNode IGNFAGJIOLA, TNode DEKNDEIHCLP, bool NNGJMGEFOCP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A66950", Offset = "0x2A65750", VA = "0x182A66950")]
	private MPAHIBCKGLA NKIJLMOLIHI(TNode IEAGANOGPLL, TNode GANAMHNGMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A66720", Offset = "0x2A65520", VA = "0x182A66720")]
	private MPAHIBCKGLA LJHJOLOIGEB(TNode IEAGANOGPLL, TNode GANAMHNGMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A65CC0", Offset = "0x2A64AC0", VA = "0x182A65CC0")]
	private void DCFGBPKEMLN(MPAHIBCKGLA LPFENKMFEII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class KJFAPAKCDDH<T> : IEnumerable<global::KJFAPAKCDDH<T>.NPILPLKKELI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct NPILPLKKELI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public T MGFMONLLLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public int NNHNOIMLALG;
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class BNGGIOMPMIP : IEnumerator<NPILPLKKELI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private global::KJFAPAKCDDH<T> HNFKMIGCOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private int NNHNOIMLALG;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x10590F0", Offset = "0x1057EF0", VA = "0x1810590F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public NPILPLKKELI OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2CA8480", Offset = "0x2CA7280", VA = "0x182CA8480", Slot = "4")]
			get
			{
				return default(NPILPLKKELI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x745690", Offset = "0x744490", VA = "0x180745690")]
		public BNGGIOMPMIP(global::KJFAPAKCDDH<T> HNFKMIGCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8380", Offset = "0x2CA7180", VA = "0x182CA8380", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x745680", Offset = "0x744480", VA = "0x180745680", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xC9D2D0", Offset = "0xC9C0D0", VA = "0x180C9D2D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct MJAGINMBCKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public bool OPPMHCBKOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public T MGFMONLLLPD;
	}

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private const int CKGFDDLIFAE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly Dictionary<T, int> MGHEKEIDCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private MJAGINMBCKP[] LFBALPBLCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int HFOFCPPKNBH;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public int HHKPPHKAKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x761F20", Offset = "0x760D20", VA = "0x180761F20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DADD0", Offset = "0x8D9BD0", VA = "0x1808DADD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3009660", Offset = "0x3008460", VA = "0x183009660")]
	public KJFAPAKCDDH(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3009740", Offset = "0x3008540", VA = "0x183009740")]
	public KJFAPAKCDDH(NPILPLKKELI[] DPGFIDKIIHG, bool ICKCIKCNPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x30083E0", Offset = "0x30071E0", VA = "0x1830083E0")]
	public int JANJEMCDAAI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3009030", Offset = "0x3007E30", VA = "0x183009030")]
	private int OPPAGPCAHCG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3008480", Offset = "0x3007280", VA = "0x183008480", Slot = "6")]
	protected virtual uint KFBJLAAIEGE(uint PHHBPOOMOKI, T MGFMONLLLPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3009450", Offset = "0x3008250", VA = "0x183009450")]
	public bool PDKOIMMPCFM(T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x30094E0", Offset = "0x30082E0", VA = "0x1830094E0")]
	public bool PJMPFFADNNP(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x30084A0", Offset = "0x30072A0", VA = "0x1830084A0")]
	public bool LDEEBLCAEDK(Func<T, bool> GCFKLPPHEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3009530", Offset = "0x3008330", VA = "0x183009530")]
	public int PNJLAGMKNIF(T MGFMONLLLPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x3008380", Offset = "0x3007180", VA = "0x183008380")]
	public T IHLCJELLMHC(int NNHNOIMLALG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3008DE0", Offset = "0x3007BE0", VA = "0x183008DE0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3008DA0", Offset = "0x3007BA0", VA = "0x183008DA0")]
	public bool NEHFKMKGDBM(T MGFMONLLLPD, bool HLMFEMALMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3008970", Offset = "0x3007770", VA = "0x183008970")]
	public bool NEHFKMKGDBM(T MGFMONLLLPD, int NNHNOIMLALG, bool HLMFEMALMJC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3008210", Offset = "0x3007010", VA = "0x183008210")]
	public bool CJGLMEKHGBL(T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x30081C0", Offset = "0x3006FC0", VA = "0x1830081C0")]
	public bool CILEDFDJAAI(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3008F40", Offset = "0x3007D40", VA = "0x183008F40")]
	private void OOOKGPMPKKC(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x30086C0", Offset = "0x30074C0", VA = "0x1830086C0")]
	public NPILPLKKELI[] NEECKNOMDLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3008670", Offset = "0x3007470", VA = "0x183008670")]
	private int LNHAANMNHOH(int IAONMKKMAEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x30095E0", Offset = "0x30083E0", VA = "0x1830095E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x30095E0", Offset = "0x30083E0", VA = "0x1830095E0", Slot = "4")]
	private IEnumerator<NPILPLKKELI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct AIADGKMLIIN<Handle> where Handle : JMOHLFDBGCE, new()
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private struct KPKMJKJEIKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly global::AIADGKMLIIN<Handle> OEJFHHNHNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private int NNHNOIMLALG;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public int GGEMOOCCBFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x4662D30", Offset = "0x4661B30", VA = "0x184662D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Handle FHJPBLIFACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x46625B0", Offset = "0x46613B0", VA = "0x1846625B0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x46634F0", Offset = "0x46622F0", VA = "0x1846634F0")]
		public KPKMJKJEIKL(global::AIADGKMLIIN<Handle> OEJFHHNHNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x46623D0", Offset = "0x46611D0", VA = "0x1846623D0")]
		public KJLPMDIMMCG AIJMFKKLHCC(in KJLPMDIMMCG IDKOCJBGGJO)
		{
			return default(KJLPMDIMMCG);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x4662330", Offset = "0x4661130", VA = "0x184662330")]
		public PDGHACINOOL AIJMFKKLHCC(in PDGHACINOOL IDKOCJBGGJO)
		{
			return default(PDGHACINOOL);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4663190", Offset = "0x4661F90", VA = "0x184663190")]
		public bool PHDHHPHJAEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x4662510", Offset = "0x4661310", VA = "0x184662510")]
		private int KMGAMCHAIJK(string GPAOLHFLBHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4662F80", Offset = "0x4661D80", VA = "0x184662F80")]
		private Handle PGPAHKNKIMI(string GPAOLHFLBHD)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public struct KJLPMDIMMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private KPKMJKJEIKL LJDJKNJOEAA;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x300AD80", Offset = "0x3009B80", VA = "0x18300AD80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA670", Offset = "0x1FF9470", VA = "0x181FFA670")]
		public KJLPMDIMMCG(global::AIADGKMLIIN<Handle> OEJFHHNHNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA5B0", Offset = "0x1FF93B0", VA = "0x181FFA5B0")]
		public bool PHDHHPHJAEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x300AE80", Offset = "0x3009C80", VA = "0x18300AE80")]
		public KJLPMDIMMCG NEACBAFBFJC()
		{
			return default(KJLPMDIMMCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct PDGHACINOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private KPKMJKJEIKL LJDJKNJOEAA;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Handle OAFAFEDHHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x1FFA470", Offset = "0x1FF9270", VA = "0x181FFA470")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA670", Offset = "0x1FF9470", VA = "0x181FFA670")]
		public PDGHACINOOL(global::AIADGKMLIIN<Handle> OEJFHHNHNBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA5B0", Offset = "0x1FF93B0", VA = "0x181FFA5B0")]
		public bool PHDHHPHJAEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA4F0", Offset = "0x1FF92F0", VA = "0x181FFA4F0")]
		public PDGHACINOOL NEACBAFBFJC()
		{
			return default(PDGHACINOOL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private NativeList<int> PHKJHFOMDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private NativeList<int> CCFPLONMHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int LKHPNFAEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int KNDIOBBHBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool IEHOLPPDHPB;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x33FFAF0", Offset = "0x33FE8F0", VA = "0x1833FFAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int EAGACBGMLAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int CCJLEFJBKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x740010", Offset = "0x73EE10", VA = "0x180740010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KJLPMDIMMCG DONJINODLAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x24D12A0", Offset = "0x24D00A0", VA = "0x1824D12A0")]
		get
		{
			return default(KJLPMDIMMCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public PDGHACINOOL BMDKGFMFGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x24D01D0", Offset = "0x24CEFD0", VA = "0x1824D01D0")]
		get
		{
			return default(PDGHACINOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x33FFBF0", Offset = "0x33FE9F0", VA = "0x1833FFBF0")]
	public AIADGKMLIIN(int BNMNOFALCDD, Allocator MBJMPHBLMBF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x33FEE90", Offset = "0x33FDC90", VA = "0x1833FEE90")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C880", Offset = "0x1F9B680", VA = "0x181F9C880")]
	public static int LILLJHKHJNM(int LABLHNPANGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x24D0270", Offset = "0x24CF070", VA = "0x1824D0270")]
	public static bool GALELDEFGBI(int LABLHNPANGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x24D1FA0", Offset = "0x24D0DA0", VA = "0x1824D1FA0")]
	public static bool PPEAIDBMFKI(int LABLHNPANGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x33FE0B0", Offset = "0x33FCEB0", VA = "0x1833FE0B0")]
	public bool GCECENIMHDJ(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x33FDC90", Offset = "0x33FCA90", VA = "0x1833FDC90")]
	public bool CJBAAHMHGOK(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x33FEC70", Offset = "0x33FDA70", VA = "0x1833FEC70")]
	public bool MNFAADOFDDK(Handle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x33FF330", Offset = "0x33FE130", VA = "0x1833FF330")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OEFBNMEBJCC(Handle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x33FF7B0", Offset = "0x33FE5B0", VA = "0x1833FF7B0")]
	public Handle PFHILKDIPEH()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x33FE390", Offset = "0x33FD190", VA = "0x1833FE390")]
	public void KBFLGKIAHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x33FDE30", Offset = "0x33FCC30", VA = "0x1833FDE30")]
	public void CLACHKBDJHG(Handle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x33FF650", Offset = "0x33FE450", VA = "0x1833FF650")]
	public bool OEIEMBIAMPP(Handle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670")]
	private bool EIJMGEKPAHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x33FDAB0", Offset = "0x33FC8B0", VA = "0x1833FDAB0")]
	private bool BBLDFBBABPD(int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x33FEB00", Offset = "0x33FD900", VA = "0x1833FEB00")]
	private void KLADAEJEDJK(out int NNHNOIMLALG, out int HHCMOLFBCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x33FDEB0", Offset = "0x33FCCB0", VA = "0x1833FDEB0")]
	private void COKALDLJLDH(Handle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x33FE340", Offset = "0x33FD140", VA = "0x1833FE340")]
	private void GOBGMIDLNJI(int NNHNOIMLALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x33FFA00", Offset = "0x33FE800", VA = "0x1833FFA00")]
	private bool PGDIIAHHKOL(out int NNHNOIMLALG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x24D0B90", Offset = "0x24CF990", VA = "0x1824D0B90")]
	private static Handle KEADGDHFAOP(int NNHNOIMLALG, int HHCMOLFBCEB)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public struct JEFOHNHCKHC<Handle, T> where Handle : JMOHLFDBGCE, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private global::AIADGKMLIIN<Handle> LOIPLFJOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private T[] BKOENGCOEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Action<T> BFGOMKCBEIO;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool MNPJEDKKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3F86500", Offset = "0x3F85300", VA = "0x183F86500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int DGLKHMNKMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3F86DD0", Offset = "0x3F85BD0", VA = "0x183F86DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3F86670", Offset = "0x3F85470", VA = "0x183F86670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public T BJLJPPKNJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3F85820", Offset = "0x3F84620", VA = "0x183F85820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3F86E10", Offset = "0x3F85C10", VA = "0x183F86E10")]
	public JEFOHNHCKHC(int BNMNOFALCDD, [Optional] Action<T> BFGOMKCBEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x3F86730", Offset = "0x3F85530", VA = "0x183F86730")]
	public void NFGECJODELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3F865D0", Offset = "0x3F853D0", VA = "0x183F865D0")]
	public bool MNFAADOFDDK(Handle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void OEFBNMEBJCC(Handle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3F83D20", Offset = "0x3F82B20", VA = "0x183F83D20")]
	public T BANNGLOAJDI(Handle EAHLOGLBEGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3F84500", Offset = "0x3F83300", VA = "0x183F84500")]
	public bool EHAPPLAHJDF(Handle EAHLOGLBEGD, out T OJGAEOFIMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3F86270", Offset = "0x3F85070", VA = "0x183F86270")]
	public void KKNDJJJFEOO(Handle EAHLOGLBEGD, T GJBELFDFMGP, out T PEHEEBIOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3F86310", Offset = "0x3F85110", VA = "0x183F86310")]
	public void KKNDJJJFEOO(Handle EAHLOGLBEGD, T GJBELFDFMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3F84E70", Offset = "0x3F83C70", VA = "0x183F84E70")]
	public bool FEJHKBDMPAO(Handle EAHLOGLBEGD, T GJBELFDFMGP, out T PEHEEBIOIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x3F84B80", Offset = "0x3F83980", VA = "0x183F84B80")]
	public bool FEJHKBDMPAO(Handle EAHLOGLBEGD, T GJBELFDFMGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x3F86AE0", Offset = "0x3F858E0", VA = "0x183F86AE0")]
	public Handle OEECIDDHIAM(T OJGAEOFIMPK)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3F855F0", Offset = "0x3F843F0", VA = "0x183F855F0")]
	public void FMGGBNBEMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x3F840B0", Offset = "0x3F82EB0", VA = "0x183F840B0")]
	public void CJGLMEKHGBL(Handle EAHLOGLBEGD, out T PEHEEBIOIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3F84360", Offset = "0x3F83160", VA = "0x183F84360")]
	public void CJGLMEKHGBL(Handle EAHLOGLBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3F85E90", Offset = "0x3F84C90", VA = "0x183F85E90")]
	public bool JBJPNMKEMOL(Handle EAHLOGLBEGD, out T PEHEEBIOIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3F85DB0", Offset = "0x3F84BB0", VA = "0x183F85DB0")]
	public bool JBJPNMKEMOL(Handle EAHLOGLBEGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3F83DE0", Offset = "0x3F82BE0", VA = "0x183F83DE0")]
	private T CILEDFDJAAI(int NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3F86050", Offset = "0x3F84E50", VA = "0x183F86050")]
	private void JCEMMEAGOBB(int GEMEMFPEHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JGHAJNCBKBF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly Stack<T> OEJFHHNHNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly List<T> LLPEIHGIDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly int AFJPMGCGDIM;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public int BGJFIEHGIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2353D70", Offset = "0x2352B70", VA = "0x182353D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int JLJIPLCKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2762F90", Offset = "0x2761D90", VA = "0x182762F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E5D0", Offset = "0x2A4D3D0", VA = "0x182A4E5D0")]
	public static global::JGHAJNCBKBF<T> BCPBIDODFKA(int JNGKGNOBDKI = 0, int AFJPMGCGDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E930", Offset = "0x2A4D730", VA = "0x182A4E930")]
	public static global::JGHAJNCBKBF<T> JCPBOFMHCOD(int JNGKGNOBDKI = 0, int AFJPMGCGDIM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EDC0", Offset = "0x2A4DBC0", VA = "0x182A4EDC0")]
	public JGHAJNCBKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EE00", Offset = "0x2A4DC00", VA = "0x182A4EE00")]
	public JGHAJNCBKBF(int JNGKGNOBDKI, int AFJPMGCGDIM = int.MaxValue, bool KHGPOBHLCPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EA00", Offset = "0x2A4D800", VA = "0x182A4EA00")]
	public T KHNMKAMIEGI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EC90", Offset = "0x2A4DA90", VA = "0x182A4EC90")]
	public void NEMCOOEJGBM(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EBA0", Offset = "0x2A4D9A0", VA = "0x182A4EBA0")]
	private void KMBBBODDJLL(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EC70", Offset = "0x2A4DA70", VA = "0x182A4EC70")]
	private void MJPOEFNJLCC(T MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x2A4ED40", Offset = "0x2A4DB40", VA = "0x182A4ED40")]
	[Conditional("DEBUG_BUILD")]
	private void NOCGCDENNCF(T JHLIBBDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4EB10", Offset = "0x2A4D910", VA = "0x182A4EB10")]
	[Conditional("DEBUG_BUILD")]
	private void KKKIHHGEJKP(T JHLIBBDEPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E6A0", Offset = "0x2A4D4A0", VA = "0x182A4E6A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x2A4E790", Offset = "0x2A4D590", VA = "0x182A4E790")]
	private void EJLJEKDGBIL(IEnumerable<T> HEJNPPKNAND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class AHIPFJOICEF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Dictionary<int, T> HOPLLDGEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private T LILAGPDLFJL;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public virtual T POMLAKKGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x7612D0", Offset = "0x7600D0", VA = "0x1807612D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool NNJFFHEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x33FD120", Offset = "0x33FBF20", VA = "0x1833FD120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x33FD610", Offset = "0x33FC410", VA = "0x1833FD610")]
	public bool NMBLHBILMPM(T MGFMONLLLPD, int OBAOEICHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x33FD160", Offset = "0x33FBF60", VA = "0x1833FD160")]
	public bool MNMLNGCEBNN(int OBAOEICHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x33FD1C0", Offset = "0x33FBFC0", VA = "0x1833FD1C0")]
	public T NIFMJNLHELD(int ENPNHIFGAFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x33FD670", Offset = "0x33FC470", VA = "0x1833FD670")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x33FCF80", Offset = "0x33FBD80", VA = "0x1833FCF80")]
	private bool JPGKFFGILAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x33FCF50", Offset = "0x33FBD50", VA = "0x1833FCF50")]
	public bool BOAPLFBFGDK(int OBAOEICHDDL, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x33FD6D0", Offset = "0x33FC4D0", VA = "0x1833FD6D0")]
	public AHIPFJOICEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class LIPCFHMOPOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	protected struct KAHCNNHMGFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public T KCKILJPPPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int FICFIHNNEMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected readonly List<KAHCNNHMGFC> MNICNOKECPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private T ONPODCDLLIL;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1050720", Offset = "0x104F520", VA = "0x181050720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x3A90980", Offset = "0x3A8F780", VA = "0x183A90980")]
	public bool LDEEBLCAEDK(T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x3A90DB0", Offset = "0x3A8FBB0", VA = "0x183A90DB0")]
	public void OEECIDDHIAM(T MGFMONLLLPD, int OBAOEICHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x3A907F0", Offset = "0x3A8F5F0", VA = "0x183A907F0")]
	public bool CJGLMEKHGBL(T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x3A90D50", Offset = "0x3A8FB50", VA = "0x183A90D50")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3A90E50", Offset = "0x3A8FC50", VA = "0x183A90E50")]
	public T PKMKNDGDENA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3A90910", Offset = "0x3A8F710", VA = "0x183A90910")]
	public T HDJFHGPNMFB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x3A90B90", Offset = "0x3A8F990", VA = "0x183A90B90")]
	private void NPGAMDAOGNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3A90EC0", Offset = "0x3A8FCC0", VA = "0x183A90EC0")]
	public LIPCFHMOPOJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x6A27A10", Offset = "0x6A26810", VA = "0x186A27A10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x6A27DA0", Offset = "0x6A26BA0", VA = "0x186A27DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x6A27C20", Offset = "0x6A26A20", VA = "0x186A27C20")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x6A27F00", Offset = "0x6A26D00", VA = "0x186A27F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x6A27930", Offset = "0x6A26730", VA = "0x186A27930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x6A27CC0", Offset = "0x6A26AC0", VA = "0x186A27CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x6A27B40", Offset = "0x6A26940", VA = "0x186A27B40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6A278E0", Offset = "0x6A266E0", VA = "0x186A278E0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface DOFPDGINBLD
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public abstract class ResourcePrefabReference<T> : DOFPDGINBLD where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F1E0", Offset = "0x3C6DFE0", VA = "0x183C6F1E0", Slot = "4")]
		public virtual T BOEILODPBBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class FCIFGMOJGBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly Dictionary<byte, AGDJCBNDEAM> BBMCMFMIPAD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AGDJCBNDEAM LDPFFCDODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Vector2 POGOHANJNBL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1A4BA00", Offset = "0x1A4A800", VA = "0x181A4BA00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x78AEB0", Offset = "0x789CB0", VA = "0x18078AEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Vector2 FIKLMMAEBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBE00", Offset = "0x1FFAC00", VA = "0x181FFBE00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA5A270", Offset = "0xA59070", VA = "0x180A5A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Vector2 EHMKMFNNCGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x6A23DE0", Offset = "0x6A22BE0", VA = "0x186A23DE0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xEFFC60", Offset = "0xEFEA60", VA = "0x180EFFC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public int OFCNJECFBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7400E0", Offset = "0x73EEE0", VA = "0x1807400E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7A8710", Offset = "0x7A7510", VA = "0x1807A8710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x6A23E20", Offset = "0x6A22C20", VA = "0x186A23E20")]
	public FCIFGMOJGBJ(Bounds DHHCACHNIBP, Vector2[] EPDFHFDEHJN, int GOFIIEAFPFC, byte IAONMKKMAEN, float PPOIJECFLME = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x6A23720", Offset = "0x6A22520", VA = "0x186A23720")]
	public AGDJCBNDEAM AINAJNIMJOF(byte NNHNOIMLALG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6A238E0", Offset = "0x6A226E0", VA = "0x186A238E0")]
	public void DGHEDJIDGMN(Vector3 DNPAJCANFPF, float JECLONDEMBH, float NNEJKGEDFEI, ref List<byte> LJENBOLMAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6A23E00", Offset = "0x6A22C00", VA = "0x186A23E00")]
	public void LLAENBLNFBG(AGDJCBNDEAM.GPFDOCAPIDO FJBMIBBHPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x6A23780", Offset = "0x6A22580", VA = "0x186A23780")]
	private AGDJCBNDEAM ALGKIMBGJPK(byte NNHNOIMLALG, AGDJCBNDEAM.NJOEPONIOGM GEGOJBCCOBF, AGDJCBNDEAM GANAMHNGMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6A239E0", Offset = "0x6A227E0", VA = "0x186A239E0")]
	private void EIDODLNFEHO(AGDJCBNDEAM GANAMHNGMGO, Vector2[] EPDFHFDEHJN, int MNAIOADIDKF, int JCPFFBHOELH, int AKACLLFHGNP, int IHCJHIEFEOK, float PPOIJECFLME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class AGDJCBNDEAM
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum NJOEPONIOGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public enum GPFDOCAPIDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public byte MMLDEBDAEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Vector3 IOFBAHKAACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Vector3 OGFGLCKEPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Vector3 LKNLAHFKINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Vector3 DJCIDDNMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NJOEPONIOGM NABGPFKMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public AGDJCBNDEAM CKPAOFJPCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public List<AGDJCBNDEAM> AHNHGPGKIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public bool MIHHOEIGHHM;

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6A22530", Offset = "0x6A21330", VA = "0x186A22530")]
	public AGDJCBNDEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6A224D0", Offset = "0x6A212D0", VA = "0x186A224D0")]
	public AGDJCBNDEAM(byte LNJCEIMJDGG, NJOEPONIOGM GEGOJBCCOBF, AGDJCBNDEAM GANAMHNGMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6A22410", Offset = "0x6A21210", VA = "0x186A22410")]
	public void MJIINKEILDI(AGDJCBNDEAM LDCHDOICMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public void LLAENBLNFBG(int GEAOHHHPCEK, GPFDOCAPIDO FJBMIBBHPOA, int IPLEKEGLLDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x6A22120", Offset = "0x6A20F20", VA = "0x186A22120")]
	public void DGHEDJIDGMN(List<byte> LJENBOLMAKD, Vector3 DNPAJCANFPF, float JECLONDEMBH, float NNEJKGEDFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x6A220D0", Offset = "0x6A20ED0", VA = "0x186A220D0")]
	public bool BDGOPCONGHC(Vector3 LOFCJGHDJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x6A223D0", Offset = "0x6A211D0", VA = "0x186A223D0")]
	public bool KIMANMNAEBG(Vector3 LOFCJGHDJHE, float LDJNDOPGMGG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public struct BGPBANINDNG<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private readonly List<Component> MPMKGFKPBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private readonly bool ILMOBEGJHCJ;

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x910020", Offset = "0x90EE20", VA = "0x180910020")]
			public BGPBANINDNG(List<Component> MPMKGFKPBEN, bool ILMOBEGJHCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x2C92F60", Offset = "0x2C91D60", VA = "0x182C92F60")]
			public ADDEHJGEGCE<T> NEACBAFBFJC()
			{
				return default(ADDEHJGEGCE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x2C92FD0", Offset = "0x2C91DD0", VA = "0x182C92FD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2C92FD0", Offset = "0x2C91DD0", VA = "0x182C92FD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public struct ADDEHJGEGCE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			private readonly List<Component> MPMKGFKPBEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private readonly bool ILMOBEGJHCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			private int NNHNOIMLALG;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public T OAFAFEDHHDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000389")]
				[Cpp2IlInjected.Address(RVA = "0x2B9C1C0", Offset = "0x2B9AFC0", VA = "0x182B9C1C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038A")]
				[Cpp2IlInjected.Address(RVA = "0x2B9C150", Offset = "0x2B9AF50", VA = "0x182B9C150", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C190", Offset = "0x2B9AF90", VA = "0x182B9C190")]
			public ADDEHJGEGCE(List<Component> MPMKGFKPBEN, bool ILMOBEGJHCJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C080", Offset = "0x2B9AE80", VA = "0x182B9C080", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C090", Offset = "0x2B9AE90", VA = "0x182B9C090", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x2B9C140", Offset = "0x2B9AF40", VA = "0x182B9C140", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x6A29BD0", Offset = "0x6A289D0", VA = "0x186A29BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6A29B90", Offset = "0x6A28990", VA = "0x186A29B90")]
		public ToolHierarchyCache(GameObject KOFDCLCOPIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6A29960", Offset = "0x6A28760", VA = "0x186A29960")]
		private void PGIHAENGDGO(GameObject KOFDCLCOPIN, bool ONFDAKCOPIF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6A298D0", Offset = "0x6A286D0", VA = "0x186A298D0")]
		public static void PGIHAENGDGO(GameObject KOFDCLCOPIN, ref ToolHierarchyCache DPNMFCPMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6A29320", Offset = "0x6A28120", VA = "0x186A29320")]
		public void DJECFLAAFPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6A29AC0", Offset = "0x6A288C0", VA = "0x186A29AC0")]
		public void PJOEPMIKLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x270C090", Offset = "0x270AE90", VA = "0x18270C090")]
		public void COANMOLEOHH<T>(Action<T> JBJAGOLOBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6A29800", Offset = "0x6A28600", VA = "0x186A29800")]
		public Component OOPIGAAEEDP(Type LEDIIMFEFLP, bool ILMOBEGJHCJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x270C3F0", Offset = "0x270B1F0", VA = "0x18270C3F0")]
		public T OOPIGAAEEDP<T>(bool ILMOBEGJHCJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6A29780", Offset = "0x6A28580", VA = "0x186A29780")]
		public BGPBANINDNG<Component> NJICJANJOML(Type LEDIIMFEFLP, bool ILMOBEGJHCJ = false)
		{
			return default(BGPBANINDNG<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x270C320", Offset = "0x270B120", VA = "0x18270C320")]
		public BGPBANINDNG<T> NJICJANJOML<T>(bool ILMOBEGJHCJ = false) where T : class
		{
			return default(BGPBANINDNG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6A29430", Offset = "0x6A28230", VA = "0x186A29430")]
		public List<Component> NAJFJFDHAON(Type LEDIIMFEFLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6A29330", Offset = "0x6A28130", VA = "0x186A29330", Slot = "4")]
		public bool Equals(ToolHierarchyCache NHKCICGBPMI, ToolHierarchyCache PEKPPEFFGIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6A293B0", Offset = "0x6A281B0", VA = "0x186A293B0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache OJGAEOFIMPK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class BBBNNAIOKKP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int JNGKGNOBDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int IMLBAPIOJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private List<T> BNPIGAGGDHK;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public int JKIABPBFIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2353D70", Offset = "0x2352B70", VA = "0x182353D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public T IAEBPIKIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x38DBCD0", Offset = "0x38DAAD0", VA = "0x1838DBCD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public T GCMFPMOJEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x38DC000", Offset = "0x38DAE00", VA = "0x1838DC000")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public T IFBKPPEACFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x38DBDB0", Offset = "0x38DABB0", VA = "0x1838DBDB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x38DC140", Offset = "0x38DAF40", VA = "0x1838DC140")]
	public BBBNNAIOKKP(int JNGKGNOBDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x38DBF20", Offset = "0x38DAD20", VA = "0x1838DBF20")]
	public void OEECIDDHIAM(T FKGFFGDLAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x38DBE10", Offset = "0x38DAC10", VA = "0x1838DBE10")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x38DC0A0", Offset = "0x38DAEA0", VA = "0x1838DC0A0")]
	public void PPNOCANDLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x38DBC00", Offset = "0x38DAA00", VA = "0x1838DBC00")]
	public void ANGNDICIFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x38DBBF0", Offset = "0x38DA9F0", VA = "0x1838DBBF0")]
	public void AEIDBJNDHAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class KPKLNAHPILC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private bool LHMIFHCGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private Action JBJAGOLOBKN;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public static KPKLNAHPILC GHDJNHBPLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6A25150", Offset = "0x6A23F50", VA = "0x186A25150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool MEPDPOKDAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xC9D230", Offset = "0xC9C030", VA = "0x180C9D230")]
	public KPKLNAHPILC(Action JBJAGOLOBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x6A25130", Offset = "0x6A23F30", VA = "0x186A25130")]
	public void IFBNIOMHDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6A25130", Offset = "0x6A23F30", VA = "0x186A25130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public static class JOLMLJFAFPJ
{
	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6A248A0", Offset = "0x6A236A0", VA = "0x186A248A0")]
	public static void FNBEKIMAELE(BAHKENJLEMI IEAHBCAPCEH, string EACEGFJHOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
	public static void FNBEKIMAELE(IEnumerable<object> AKILODLIDKE, string EACEGFJHOGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class PECAIDJOIKK<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private struct JJGBGJGELKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int FICFIHNNEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public T KCKILJPPPGI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly Dictionary<object, JJGBGJGELKI> HOPLLDGEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly EqualityComparer<T> PGPONPFOFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private T LILAGPDLFJL;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public virtual T POMLAKKGELK
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xC94130", Offset = "0xC92F30", VA = "0x180C94130", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBD70", Offset = "0x1FFAB70", VA = "0x181FFBD70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool NNJFFHEJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FFFE90", Offset = "0x1FFEC90", VA = "0x181FFFE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public object CGNIDMLDNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E0", Offset = "0x7EFFE0", VA = "0x1807F11E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x2000310", Offset = "0x1FFF110", VA = "0x182000310")]
	public bool NMBLHBILMPM(T MGFMONLLLPD, object AMBDKIOJFBL, int OBAOEICHDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FFFEC0", Offset = "0x1FFECC0", VA = "0x181FFFEC0")]
	public bool MNMLNGCEBNN(object AMBDKIOJFBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FFBB00", Offset = "0x1FFA900", VA = "0x181FFBB00")]
	public bool BOAPLFBFGDK(object AMBDKIOJFBL, out T MGFMONLLLPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x20007A0", Offset = "0x1FFF5A0", VA = "0x1820007A0")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x1FFF650", Offset = "0x1FFE450", VA = "0x181FFF650")]
	private bool JPGKFFGILAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x20007D0", Offset = "0x1FFF5D0", VA = "0x1820007D0")]
	public PECAIDJOIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class CPOCIENDDPE : OLFJFONDFJE
{
	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A22C90", Offset = "0x6A21A90", VA = "0x186A22C90")]
	public CPOCIENDDPE(UnityEngine.Object BAGGJFKFNDO)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A24CC0", Offset = "0x6A23AC0", VA = "0x186A24CC0")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A24970", Offset = "0x6A23770", VA = "0x186A24970")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
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
