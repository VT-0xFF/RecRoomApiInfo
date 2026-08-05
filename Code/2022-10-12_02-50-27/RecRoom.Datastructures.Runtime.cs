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
public class JKGMJPEPMFD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public JKGMJPEPMFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KPJDGDIGJNP, EMENMJPDFJB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FPALDDOOOME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81CFC0", Offset = "0x81B7C0", VA = "0x18081CFC0")]
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
	[HOFALDKJCKB]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HOFALDKJCKB]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4200", Offset = "0x5DE2A00", VA = "0x185DE4200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE41C0", Offset = "0x5DE29C0", VA = "0x185DE41C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4240", Offset = "0x5DE2A40", VA = "0x185DE4240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4410", Offset = "0x5DE2C10", VA = "0x185DE4410")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4380", Offset = "0x5DE2B80", VA = "0x185DE4380")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FD120", Offset = "0x6FB920", VA = "0x1806FD120")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E3800", Offset = "0x6E2000", VA = "0x1806E3800")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4180", Offset = "0x5DE2980", VA = "0x185DE4180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE42F0", Offset = "0x5DE2AF0", VA = "0x185DE42F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3DB0", Offset = "0x5DE25B0", VA = "0x185DE3DB0")]
	public void CopyBounds(SavedExtents IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE40E0", Offset = "0x5DE28E0", VA = "0x185DE40E0")]
	public void SetLocalSpaceBounds(Bounds GABNNFBJIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xCE1AA0", Offset = "0xCE02A0", VA = "0x180CE1AA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE40D0", Offset = "0x5DE28D0", VA = "0x185DE40D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3580", Offset = "0x5DE1D80", VA = "0x185DE3580")]
	private void BPLJFEABIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3EA0", Offset = "0x5DE26A0", VA = "0x185DE3EA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3770", Offset = "0x5DE1F70", VA = "0x185DE3770")]
	public static void CalculateLocalBoundsFor(GameObject HBGIADIFHEC, out Bounds GABNNFBJIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3DE0", Offset = "0x5DE25E0", VA = "0x185DE3DE0")]
	private static void FJMNFMDFLEE(Bounds ENHIJCCJFBF, Color ODCENIJJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4100", Offset = "0x5DE2900", VA = "0x185DE4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C90", Offset = "0x6F3490", VA = "0x1806F4C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC023B0", Offset = "0xC00BB0", VA = "0x180C023B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15B13E0", Offset = "0x15AFBE0", VA = "0x1815B13E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "4")]
	public virtual void GBMLDPCEMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
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
	[JKGMJPEPMFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D06B00", Offset = "0x3D05300", VA = "0x183D06B00", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D06230", Offset = "0x3D04A30", VA = "0x183D06230", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D07040", Offset = "0x3D05840", VA = "0x183D07040")]
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
	private sealed class AKJOFOCNHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public AKJOFOCNHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE650", Offset = "0x3ECCE50", VA = "0x183ECE650")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[JKGMJPEPMFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7A00", Offset = "0x2FD6200", VA = "0x182FD7A00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7A30", Offset = "0x2FD6230", VA = "0x182FD7A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7950", Offset = "0x2FD6150", VA = "0x182FD7950", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey AGPLDPOAAIC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7980", Offset = "0x2FD6180", VA = "0x182FD7980", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7850", Offset = "0x2FD6050", VA = "0x182FD7850", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2FD71D0", Offset = "0x2FD59D0", VA = "0x182FD71D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2FD68A0", Offset = "0x2FD50A0", VA = "0x182FD68A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6780", Offset = "0x2FD4F80", VA = "0x182FD6780", Slot = "14")]
	protected virtual string EILJHBCHBIN(TKeyVal NHOEILKDEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6750", Offset = "0x2FD4F50", VA = "0x182FD6750", Slot = "4")]
	public bool ContainsKey(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7740", Offset = "0x2FD5F40", VA = "0x182FD7740", Slot = "5")]
	public bool TryGetValue(TKey AGPLDPOAAIC, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6810", Offset = "0x2FD5010", VA = "0x182FD6810", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6810", Offset = "0x2FD5010", VA = "0x182FD6810", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7770", Offset = "0x2FD5F70", VA = "0x182FD7770")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FKGGGLOGLBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KHJGNOLMKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public KHJGNOLMKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x37CA200", Offset = "0x37C8A00", VA = "0x1837CA200")]
		internal bool <GetSamples>b__0(global::PCDEGCOHKDJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float APONKIIMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PPBKFFHDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::PCDEGCOHKDJ<float, T>> OONEMLCDEPG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JFDBPPNEHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x34C6620", Offset = "0x34C4E20", VA = "0x1834C6620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x34C6C30", Offset = "0x34C5430", VA = "0x1834C6C30")]
	public FKGGGLOGLBF(float PLOJHEJNDDO, float ELOGMMNOJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34C6AD0", Offset = "0x34C52D0", VA = "0x1834C6AD0")]
	public bool PIGHMNFFOCG(float EGGBPIADIJM, T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x34C65C0", Offset = "0x34C4DC0", VA = "0x1834C65C0")]
	public int AEMBDLEHKPG(float EGGBPIADIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34C66A0", Offset = "0x34C4EA0", VA = "0x1834C66A0")]
	public IEnumerable<T> HPAJBAGDIDB(float EGGBPIADIJM, [Optional] float? ALKMIOAKPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34C69E0", Offset = "0x34C51E0", VA = "0x1834C69E0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34C6A10", Offset = "0x34C5210", VA = "0x1834C6A10")]
	private void PCCODNKDGNF(float EGGBPIADIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JKNBBIBGCKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KLGMDFIEAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float ENFOOFFCBIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NHEMOGDEDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> GCMIGLPOMCK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int PEMIJNILLMA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KLGMDFIEAFM[] KPAFOBEJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MGKKIHJFNBG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BJABMKAGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6F73E0", Offset = "0x6F5BE0", VA = "0x1806F73E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F7150", Offset = "0x6F5950", VA = "0x1806F7150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E075D0", Offset = "0x3E05DD0", VA = "0x183E075D0")]
	public JKNBBIBGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E07600", Offset = "0x3E05E00", VA = "0x183E07600")]
	public JKNBBIBGCKA(int FBPAKFCOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E06120", Offset = "0x3E04920", VA = "0x183E06120")]
	public void CEMPCIEDPMO(float EGGBPIADIJM, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E06D10", Offset = "0x3E05510", VA = "0x183E06D10")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3E06710", Offset = "0x3E04F10", VA = "0x183E06710")]
	public bool FKIGDPLAMLK(float LOJOCJJCFJJ, float INNKEDNIBHO, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3E072B0", Offset = "0x3E05AB0", VA = "0x183E072B0")]
	public bool PPNEFHEKNBJ(float LOJOCJJCFJJ, float INNKEDNIBHO, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E063A0", Offset = "0x3E04BA0", VA = "0x183E063A0")]
	public void CPCPCLMJKAO(float LOJOCJJCFJJ, float INNKEDNIBHO, List<T> NCCOCLJLPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3E06CE0", Offset = "0x3E054E0", VA = "0x183E06CE0")]
	private int OCNMNDIFALO(int ELPOAPOJMKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3E06CA0", Offset = "0x3E054A0", VA = "0x183E06CA0")]
	private void MIACIOFBAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JMMIFEIPPIK();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BPMGPKIJKNO(T FEBCAKEBBCL, T EEACLMBPLFE, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KEKPNJHGAAA(T CCIMHDCKHOF, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NCJEMFEINGH(T FEBCAKEBBCL, T EEACLMBPLFE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BLGHHHHNLDA(T FEBCAKEBBCL, T EEACLMBPLFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KJGGABKNDGO : global::JKNBBIBGCKA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xB8BE60", Offset = "0xB8A660", VA = "0x180B8BE60", Slot = "4")]
	protected override Vector3 JMMIFEIPPIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29B96D0", Offset = "0x29B7ED0", VA = "0x1829B96D0", Slot = "5")]
	protected override Vector3 BPMGPKIJKNO(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B60", Offset = "0x5DE0360", VA = "0x185DE1B60", Slot = "6")]
	protected override Vector3 KEKPNJHGAAA(Vector3 CCIMHDCKHOF, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1BC0", Offset = "0x5DE03C0", VA = "0x185DE1BC0", Slot = "7")]
	protected override Vector3 NCJEMFEINGH(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AF0", Offset = "0x5DE02F0", VA = "0x185DE1AF0", Slot = "8")]
	protected override Vector3 BLGHHHHNLDA(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C40", Offset = "0x5DE0440", VA = "0x185DE1C40")]
	public KJGGABKNDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JGIBPFEHCOA : global::JKNBBIBGCKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE18A0", Offset = "0x5DE00A0", VA = "0x185DE18A0")]
	public JGIBPFEHCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1910", Offset = "0x5DE0110", VA = "0x185DE1910")]
	public JGIBPFEHCOA(int FBPAKFCOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAD0500", Offset = "0xACED00", VA = "0x180AD0500", Slot = "4")]
	protected override float JMMIFEIPPIK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xBBE030", Offset = "0xBBC830", VA = "0x180BBE030", Slot = "5")]
	protected override float BPMGPKIJKNO(float FEBCAKEBBCL, float EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5207800", Offset = "0x5206000", VA = "0x185207800", Slot = "6")]
	protected override float KEKPNJHGAAA(float CCIMHDCKHOF, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x39DD370", Offset = "0x39DBB70", VA = "0x1839DD370", Slot = "7")]
	protected override float NCJEMFEINGH(float FEBCAKEBBCL, float EEACLMBPLFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1890", Offset = "0x5DE0090", VA = "0x185DE1890", Slot = "8")]
	protected override float BLGHHHHNLDA(float FEBCAKEBBCL, float EEACLMBPLFE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LNCBPFHPONE
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0350", Offset = "0x2E9EB50", VA = "0x182EA0350")]
	public static global::EBBAFIMJLGL<T1> MFNJFAEBAIM<T1>(T1 ACEMJELMOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36B95C0", Offset = "0x36B7DC0", VA = "0x1836B95C0")]
	public static global::PCDEGCOHKDJ<T1, T2> MFNJFAEBAIM<T1, T2>(T1 ACEMJELMOGM, T2 GAPICALCGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x36B9630", Offset = "0x36B7E30", VA = "0x1836B9630")]
	public static global::BCFAGHJINLH<T1, T2, T3> MFNJFAEBAIM<T1, T2, T3>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x355CEA0", Offset = "0x355B6A0", VA = "0x18355CEA0")]
	public static global::AADFFFHOFCL<T1, T2, T3, T4> MFNJFAEBAIM<T1, T2, T3, T4>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x36B9900", Offset = "0x36B8100", VA = "0x1836B9900")]
	public static global::DNJCHJICCOI<T1, T2, T3, T4, T5> MFNJFAEBAIM<T1, T2, T3, T4, T5>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x36B9850", Offset = "0x36B8050", VA = "0x1836B9850")]
	public static global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x36B9790", Offset = "0x36B7F90", VA = "0x1836B9790")]
	public static global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6, T7>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x36B96C0", Offset = "0x36B7EC0", VA = "0x1836B96C0")]
	public static global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI, T8 ONMDJGHGNAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9790", Offset = "0x2BC7F90", VA = "0x182BC9790")]
	[IteratorStateMachine(typeof(NGFIEFACPCC))]
	public static IEnumerable<global::PCDEGCOHKDJ<T1, T2>> NGILIIACPLC<T1, T2>(IEnumerable<T1> DOGOAAONBOH, IEnumerable<T2> ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9970", Offset = "0x2BC8170", VA = "0x182BC9970")]
	[IteratorStateMachine(typeof(DAGEALJDAMA))]
	public static IEnumerable<global::BCFAGHJINLH<T1, T2, T3>> NGILIIACPLC<T1, T2, T3>(IEnumerable<T1> DOGOAAONBOH, IEnumerable<T2> ENHIJCCJFBF, IEnumerable<T3> ODCENIJJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x100A290", Offset = "0x1008A90", VA = "0x18100A290")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x100A280", Offset = "0x1008A80", VA = "0x18100A280")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x100A260", Offset = "0x1008A60", VA = "0x18100A260")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2660", Offset = "0x5DE0E60", VA = "0x185DE2660")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DE26B0", Offset = "0x5DE0EB0", VA = "0x185DE26B0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2680", Offset = "0x5DE0E80", VA = "0x185DE2680")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF, int OCOOKLDCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DE26D0", Offset = "0x5DE0ED0", VA = "0x185DE26D0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF, int OCOOKLDCJCB, int EMALKHJKEEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBBAFIMJLGL<T1> : IComparable<global::EBBAFIMJLGL<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
	public EBBAFIMJLGL(T1 ACEMJELMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3842070", Offset = "0x3840870", VA = "0x183842070", Slot = "4")]
	public int CompareTo(global::EBBAFIMJLGL<T1> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x38420E0", Offset = "0x38408E0", VA = "0x1838420E0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E3950", Offset = "0x7E2150", VA = "0x1807E3950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3842180", Offset = "0x3840980", VA = "0x183842180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PCDEGCOHKDJ<T1, T2> : IComparable<global::PCDEGCOHKDJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0ED0", Offset = "0x3E9F6D0", VA = "0x183EA0ED0")]
	public PCDEGCOHKDJ(T1 ACEMJELMOGM, T2 GAPICALCGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F0C0", Offset = "0x3E9D8C0", VA = "0x183E9F0C0", Slot = "4")]
	public int CompareTo(global::PCDEGCOHKDJ<T1, T2> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F780", Offset = "0x3E9DF80", VA = "0x183E9F780", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0380", Offset = "0x3E9EB80", VA = "0x183EA0380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0720", Offset = "0x3E9EF20", VA = "0x183EA0720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BCFAGHJINLH<T1, T2, T3> : IComparable<global::BCFAGHJINLH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x485D360", Offset = "0x485BB60", VA = "0x18485D360")]
	public BCFAGHJINLH(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x485CC50", Offset = "0x485B450", VA = "0x18485CC50", Slot = "4")]
	public int CompareTo(global::BCFAGHJINLH<T1, T2, T3> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x485CD50", Offset = "0x485B550", VA = "0x18485CD50", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x485CFB0", Offset = "0x485B7B0", VA = "0x18485CFB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x485D0A0", Offset = "0x485B8A0", VA = "0x18485D0A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AADFFFHOFCL<T1, T2, T3, T4> : IComparable<global::AADFFFHOFCL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3595D60", Offset = "0x3594560", VA = "0x183595D60")]
	public AADFFFHOFCL(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x35D1180", Offset = "0x35CF980", VA = "0x1835D1180", Slot = "4")]
	public int CompareTo(global::AADFFFHOFCL<T1, T2, T3, T4> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x35D12C0", Offset = "0x35CFAC0", VA = "0x1835D12C0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x35D13E0", Offset = "0x35CFBE0", VA = "0x1835D13E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x35D14A0", Offset = "0x35CFCA0", VA = "0x1835D14A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DNJCHJICCOI<T1, T2, T3, T4, T5> : IComparable<global::DNJCHJICCOI<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x34B8CE0", Offset = "0x34B74E0", VA = "0x1834B8CE0")]
	public DNJCHJICCOI(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C25890", Offset = "0x3C24090", VA = "0x183C25890", Slot = "4")]
	public int CompareTo(global::DNJCHJICCOI<T1, T2, T3, T4, T5> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C25A10", Offset = "0x3C24210", VA = "0x183C25A10", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C25B50", Offset = "0x3C24350", VA = "0x183C25B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C25C50", Offset = "0x3C24450", VA = "0x183C25C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> : IComparable<global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD9F0", Offset = "0x3ECC1F0", VA = "0x183ECD9F0")]
	public AIGHOCGJNCK(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD430", Offset = "0x3ECBC30", VA = "0x183ECD430", Slot = "4")]
	public int CompareTo(global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD5F0", Offset = "0x3ECBDF0", VA = "0x183ECD5F0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD760", Offset = "0x3ECBF60", VA = "0x183ECD760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD880", Offset = "0x3ECC080", VA = "0x183ECD880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 CJPDFDFPDIC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x34BDBB0", Offset = "0x34BC3B0", VA = "0x1834BDBB0")]
	public FFHGBANFKPI(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34BD530", Offset = "0x34BBD30", VA = "0x1834BD530", Slot = "4")]
	public int CompareTo(global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34BD730", Offset = "0x34BBF30", VA = "0x1834BD730", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x34BD8D0", Offset = "0x34BC0D0", VA = "0x1834BD8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x34BDA20", Offset = "0x34BC220", VA = "0x1834BDA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 CJPDFDFPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 NDPMCDDPDLL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA990", Offset = "0x3FA9190", VA = "0x183FAA990")]
	public OACANGNDKPP(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI, T8 ONMDJGHGNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA260", Offset = "0x3FA8A60", VA = "0x183FAA260", Slot = "4")]
	public int CompareTo(global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA4B0", Offset = "0x3FA8CB0", VA = "0x183FAA4B0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA670", Offset = "0x3FA8E70", VA = "0x183FAA670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FAA7E0", Offset = "0x3FA8FE0", VA = "0x183FAA7E0", Slot = "3")]
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
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1775240", Offset = "0x1773A40", VA = "0x181775240")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1775290", Offset = "0x1773A90", VA = "0x181775290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float IJHFAAMLALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8CE850", Offset = "0x8CD050", VA = "0x1808CE850")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x448FD50", Offset = "0x448E550", VA = "0x18448FD50")]
	public T KKONMFJNIDB(float HLNBIKMPIPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x448F9A0", Offset = "0x448E1A0", VA = "0x18448F9A0")]
	public T IGGNKOFAMGP(float HLNBIKMPIPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BPMGPKIJKNO(T FEBCAKEBBCL, T EEACLMBPLFE, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xBBE030", Offset = "0xBBC830", VA = "0x180BBE030", Slot = "4")]
	protected override float BPMGPKIJKNO(float FEBCAKEBBCL, float EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0DC0", Offset = "0x5DDF5C0", VA = "0x185DE0DC0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x29B96D0", Offset = "0x29B7ED0", VA = "0x1829B96D0", Slot = "4")]
	protected override Vector3 BPMGPKIJKNO(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5300", Offset = "0x5DE3B00", VA = "0x185DE5300")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E39EE0", Offset = "0x1E386E0", VA = "0x181E39EE0", Slot = "4")]
	protected override Color BPMGPKIJKNO(Color FEBCAKEBBCL, Color EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0070", Offset = "0x5DDE870", VA = "0x185DE0070")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HBABPOCCMCF : global::LMKLFAIBJID<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1200", Offset = "0x5DDFA00", VA = "0x185DE1200")]
	public HBABPOCCMCF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE11A0", Offset = "0x5DDF9A0", VA = "0x185DE11A0")]
	public HBABPOCCMCF(IMHFCBKOGIC[] EDKOFDEAJAI, bool PAIPMGNEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1130", Offset = "0x5DDF930", VA = "0x185DE1130", Slot = "6")]
	protected override uint EDMBNPDCFGI(uint FPALDDOOOME, string CCIMHDCKHOF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GGKDCIMGNHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GGKDCIMGNHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DJNBKKPBGNP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EEGIGLBEFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<FDAEEOMAIHB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EEGIGLBEFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0D30", Offset = "0x5DDF530", VA = "0x185DE0D30")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FDAEEOMAIHB>> GPPHEFKMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FJPPNJPIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int HFAEEOMPAAF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCD8E80", Offset = "0xCD7680", VA = "0x180CD8E80")]
	private DJNBKKPBGNP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FDAEEOMAIHB>> FPONBIFGBCD, int IBFAGBMACIE, int EKAJLPLOKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE02E0", Offset = "0x5DDEAE0", VA = "0x185DE02E0")]
	public static DJNBKKPBGNP AKMEFLONJDG()
	{
		return default(DJNBKKPBGNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0360", Offset = "0x5DDEB60", VA = "0x185DE0360")]
	public (int, int, Task) CODNIHGIFBG(int OBCKDJNBOCN, [Optional] CancellationToken OHJGLBPIBBN)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0750", Offset = "0x5DDEF50", VA = "0x185DE0750")]
	public void OFPJHFHFEEK(int OBCKDJNBOCN, int EKAJLPLOKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class BMHOONCNFAE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> LCBCGHKBGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> LJLDGEJCNBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F30", Offset = "0x2F97730", VA = "0x182F98F30", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> BOJKPFIKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x35F6720", Offset = "0x35F4F20", VA = "0x1835F6720", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> CFGJONBEJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8F80", Offset = "0x2FC7780", VA = "0x182FC8F80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3671360", Offset = "0x366FB60", VA = "0x183671360", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x32D9A80", Offset = "0x32D8280", VA = "0x1832D9A80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3671150", Offset = "0x366F950", VA = "0x183671150")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3670B60", Offset = "0x366F360", VA = "0x183670B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3670A40", Offset = "0x366F240", VA = "0x183670A40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x36711E0", Offset = "0x366F9E0", VA = "0x1836711E0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3670640", Offset = "0x366EE40", VA = "0x183670640", Slot = "9")]
	public void Add(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x36706A0", Offset = "0x366EEA0", VA = "0x1836706A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3670AA0", Offset = "0x366F2A0", VA = "0x183670AA0", Slot = "8")]
	public bool ContainsKey(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3375760", Offset = "0x3373F60", VA = "0x183375760", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3671180", Offset = "0x366F980", VA = "0x183671180", Slot = "10")]
	public bool Remove(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3671180", Offset = "0x366F980", VA = "0x183671180", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9010", Offset = "0x2FC7810", VA = "0x182FC9010", Slot = "11")]
	public bool TryGetValue(TKey AGPLDPOAAIC, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3670FC0", Offset = "0x366F7C0", VA = "0x183670FC0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3670B00", Offset = "0x366F300", VA = "0x183670B00", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3670840", Offset = "0x366F040", VA = "0x183670840")]
	public void CEMPCIEDPMO(TVal OGAPHEEOKGM, TKey AGPLDPOAAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x36708F0", Offset = "0x366F0F0", VA = "0x1836708F0")]
	public void CEMPCIEDPMO(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3670C10", Offset = "0x366F410", VA = "0x183670C10")]
	public bool FPLHHNNFOGE(TVal AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x36707E0", Offset = "0x366EFE0", VA = "0x1836707E0")]
	public bool CBBIGPLMGHA(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x36705E0", Offset = "0x366EDE0", VA = "0x1836705E0")]
	public bool ADDEDGCCJIP(TVal AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x36705E0", Offset = "0x366EDE0", VA = "0x1836705E0")]
	public bool ADDEDGCCJIP(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3670BE0", Offset = "0x366F3E0", VA = "0x183670BE0")]
	public bool EPBHELLGDLM(TVal AGPLDPOAAIC, out TKey CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3670930", Offset = "0x366F130", VA = "0x183670930")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CIAPMPDJJAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3670760", Offset = "0x366EF60", VA = "0x183670760")]
	private void BNKODGOIFDM(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36710D0", Offset = "0x366F8D0", VA = "0x1836710D0")]
	private void LNHFLDDOFKH(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3670DC0", Offset = "0x366F5C0", VA = "0x183670DC0")]
	private bool GMMBBPAKCJJ(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3670D00", Offset = "0x366F500", VA = "0x183670D00")]
	private bool GMMBBPAKCJJ(TVal OGAPHEEOKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3671280", Offset = "0x366FA80", VA = "0x183671280")]
	public BMHOONCNFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class LLLEADJIAFA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::LLLEADJIAFA<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3C0DC40", Offset = "0x3C0C440", VA = "0x183C0DC40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3C101D0", Offset = "0x3C0E9D0", VA = "0x183C101D0")]
		public Enumerator(global::LLLEADJIAFA<T> NCCOCLJLPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C0BDB0", Offset = "0x3C0A5B0", VA = "0x183C0BDB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3C0C660", Offset = "0x3C0AE60", VA = "0x183C0C660", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C088E0", Offset = "0x3C070E0", VA = "0x183C088E0")]
		private void HHMILLHIJOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] DOACBDBBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int OFHLFABGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int KJCIMGFJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int LDFDMKAILBI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3919AA0", Offset = "0x39182A0", VA = "0x183919AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x391A8D0", Offset = "0x39190D0", VA = "0x18391A8D0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3919990", Offset = "0x3918190", VA = "0x183919990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x391AE80", Offset = "0x3919680", VA = "0x18391AE80")]
	public LLLEADJIAFA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3919220", Offset = "0x3917A20", VA = "0x183919220")]
	public void CEMPCIEDPMO(T HLNBIKMPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3919BA0", Offset = "0x39183A0", VA = "0x183919BA0")]
	public void JLOEGDMEDIN(IEnumerable<T> NMJNDGPGMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x391ACE0", Offset = "0x39194E0", VA = "0x18391ACE0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3919A10", Offset = "0x3918210", VA = "0x183919A10")]
	public void DMJEDPELCAN(int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3919B10", Offset = "0x3918310", VA = "0x183919B10")]
	public void JGGJCBHGCIF(int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x39192E0", Offset = "0x3917AE0", VA = "0x1839192E0")]
	public void DFDKBNEOJKD(T[] KPAFOBEJBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3918F40", Offset = "0x3917740", VA = "0x183918F40")]
	public Enumerator CDEDLLPMOKO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x391AD00", Offset = "0x3919500", VA = "0x18391AD00", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x391AD00", Offset = "0x3919500", VA = "0x18391AD00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x391ABF0", Offset = "0x39193F0", VA = "0x18391ABF0")]
	private int OBCBDCEGGDM(int MMABPPDCBIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3919AE0", Offset = "0x39182E0", VA = "0x183919AE0")]
	private int FLKCHGOOOLE(int MMABPPDCBIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class KLOBBAKJNJJ<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E3880", Offset = "0x6E2080", VA = "0x1806E3880", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E38B0", Offset = "0x6E20B0", VA = "0x1806E38B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC2B0", Offset = "0x3DCAAB0", VA = "0x183DCC2B0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC350", Offset = "0x3DCAB50", VA = "0x183DCC350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3DCC250", Offset = "0x3DCAA50", VA = "0x183DCC250", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3911CE0", Offset = "0x39104E0", VA = "0x183911CE0")]
	public KLOBBAKJNJJ(Func<Internal, External> KLINPOPBADJ, Func<External, Internal> AOAOCMABBCP, bool ELNPFHKAOAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBF70", Offset = "0x3DCA770", VA = "0x183DCBF70", Slot = "6")]
	public int IndexOf(External EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBBF0", Offset = "0x3DCA3F0", VA = "0x183DCBBF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBC50", Offset = "0x3DCA450", VA = "0x183DCBC50", Slot = "13")]
	public bool Contains(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBCE0", Offset = "0x3DCA4E0", VA = "0x183DCBCE0", Slot = "14")]
	public void CopyTo(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBB00", Offset = "0x3DCA300", VA = "0x183DCBB00", Slot = "11")]
	public void Add(External EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC060", Offset = "0x3DCA860", VA = "0x183DCC060", Slot = "7")]
	public void Insert(int MMABPPDCBIB, External EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC1C0", Offset = "0x3DCA9C0", VA = "0x183DCC1C0", Slot = "15")]
	public bool Remove(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCC100", Offset = "0x3DCA900", VA = "0x183DCC100", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCBF00", Offset = "0x3DCA700", VA = "0x183DCBF00", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x32E1400", Offset = "0x32DFC00", VA = "0x1832E1400", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class LGBMOOIAHED<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x390D540", Offset = "0x390BD40", VA = "0x18390D540", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x390D4E0", Offset = "0x390BCE0", VA = "0x18390D4E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
	public LGBMOOIAHED(Func<Internal, External> KLINPOPBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x390D490", Offset = "0x390BC90", VA = "0x18390D490")]
	public LGBMOOIAHED(IReadOnlyList<Internal> PIJDNOPJENO, Func<Internal, External> KLINPOPBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x390D200", Offset = "0x390BA00", VA = "0x18390D200")]
	public void DFDKBNEOJKD(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x390D420", Offset = "0x390BC20", VA = "0x18390D420", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x34C5030", Offset = "0x34C3830", VA = "0x1834C5030", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PODCINKBEFJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x341F9D0", Offset = "0x341E1D0", VA = "0x18341F9D0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x341F970", Offset = "0x341E170", VA = "0x18341F970", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
	public PODCINKBEFJ(IReadOnlyList<Internal> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x341F630", Offset = "0x341DE30", VA = "0x18341F630")]
	public bool CBBIGPLMGHA(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x341F6D0", Offset = "0x341DED0", VA = "0x18341F6D0")]
	public void DFDKBNEOJKD(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x341F900", Offset = "0x341E100", VA = "0x18341F900", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x32E1400", Offset = "0x32DFC00", VA = "0x1832E1400", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class HHKDEEAFFCF
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IBCOCCDCDEF(object[] GOLEKIJBOAN);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected HHKDEEAFFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class NMOLAGMGIFL<T> : HHKDEEAFFCF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct OPCEFNCHMKH
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum LCPFCMJGDLJ
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
		public LCPFCMJGDLJ BCFKLEGAMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T NCHNGIGODJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NLIFEGOADHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool ECCFKJNMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool EGMOJIIMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MGDLLHEPMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<OPCEFNCHMKH> PIPLNLNHNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IELELMEGGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x3C01CC0", Offset = "0x3C004C0", VA = "0x183C01CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3C01ED0", Offset = "0x3C006D0", VA = "0x183C01ED0")]
	protected NMOLAGMGIFL(bool EGMOJIIMFHP, bool ECCFKJNMKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3C01930", Offset = "0x3C00130", VA = "0x183C01930")]
	protected bool BFOIIFOEBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3C01D00", Offset = "0x3C00500", VA = "0x183C01D00")]
	protected void JCOPDCPKDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3C019B0", Offset = "0x3C001B0", VA = "0x183C019B0")]
	protected void CAAOODCFKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4505BF0", Offset = "0x45043F0", VA = "0x184505BF0")]
	private static void GCJPPMAFMEN<U>(ref List<U> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3C01B60", Offset = "0x3C00360", VA = "0x183C01B60", Slot = "5")]
	public void CEMPCIEDPMO(T NCHNGIGODJK, bool NGLFMPIMFDE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C017F0", Offset = "0x3BFFFF0", VA = "0x183C017F0", Slot = "6")]
	public void ADDEDGCCJIP(T NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3C01DC0", Offset = "0x3C005C0", VA = "0x183C01DC0")]
	public void OJEEPLKEKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HGGLDMFOFMG
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class CMOPDACJGKG : global::NMOLAGMGIFL<Action>, HGGLDMFOFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0010", Offset = "0x5DDE810", VA = "0x185DE0010")]
	public CMOPDACJGKG(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFDA0", Offset = "0x5DDE5A0", VA = "0x185DDFDA0")]
	public void JAKEEOPOMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFCD0", Offset = "0x5DDE4D0", VA = "0x185DDFCD0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFD40", Offset = "0x5DDE540", VA = "0x185DDFD40")]
	public static CMOPDACJGKG IDPFAKACPID(CMOPDACJGKG EBJJKPBLHEG, Action NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFFB0", Offset = "0x5DDE7B0", VA = "0x185DDFFB0")]
	public static CMOPDACJGKG MMBIJLAKMHD(CMOPDACJGKG EBJJKPBLHEG, Action NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OEOJBFINKLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DPCNIAMGAEP<T> : global::NMOLAGMGIFL<Action<T>>, global::OEOJBFINKLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public DPCNIAMGAEP(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3C29F40", Offset = "0x3C28740", VA = "0x183C29F40")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3C28360", Offset = "0x3C26B60", VA = "0x183C28360", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3C29120", Offset = "0x3C27920", VA = "0x183C29120")]
	public static global::DPCNIAMGAEP<T> IDPFAKACPID(global::DPCNIAMGAEP<T> EBJJKPBLHEG, Action<T> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3C2A1D0", Offset = "0x3C289D0", VA = "0x183C2A1D0")]
	public static global::DPCNIAMGAEP<T> MMBIJLAKMHD(global::DPCNIAMGAEP<T> EBJJKPBLHEG, Action<T> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LLLPJNEJFGG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DCBNKGAHPLA<T, U> : global::NMOLAGMGIFL<Action<T, U>>, global::LLLPJNEJFGG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public DCBNKGAHPLA(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4242320", Offset = "0x4240B20", VA = "0x184242320")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x423FEC0", Offset = "0x423E6C0", VA = "0x18423FEC0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4241BC0", Offset = "0x42403C0", VA = "0x184241BC0")]
	public static global::DCBNKGAHPLA<T, U> IDPFAKACPID(global::DCBNKGAHPLA<T, U> EBJJKPBLHEG, Action<T, U> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4244160", Offset = "0x4242960", VA = "0x184244160")]
	public static global::DCBNKGAHPLA<T, U> MMBIJLAKMHD(global::DCBNKGAHPLA<T, U> EBJJKPBLHEG, Action<T, U> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KLKFMGDGCHB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class OKKMIGNKDFJ<T, U, V> : global::NMOLAGMGIFL<Action<T, U, V>>, global::KLKFMGDGCHB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public OKKMIGNKDFJ(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3B86690", Offset = "0x3B84E90", VA = "0x183B86690")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3B844A0", Offset = "0x3B82CA0", VA = "0x183B844A0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3B85590", Offset = "0x3B83D90", VA = "0x183B85590")]
	public static global::OKKMIGNKDFJ<T, U, V> IDPFAKACPID(global::OKKMIGNKDFJ<T, U, V> EBJJKPBLHEG, Action<T, U, V> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3B87440", Offset = "0x3B85C40", VA = "0x183B87440")]
	public static global::OKKMIGNKDFJ<T, U, V> MMBIJLAKMHD(global::OKKMIGNKDFJ<T, U, V> EBJJKPBLHEG, Action<T, U, V> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KHLJFCEFDGG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class MOBMMDELNAG<T, U, V, W> : global::NMOLAGMGIFL<Action<T, U, V, W>>, global::KHLJFCEFDGG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public MOBMMDELNAG(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3886AA0", Offset = "0x38852A0", VA = "0x183886AA0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3885030", Offset = "0x3883830", VA = "0x183885030", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3885AB0", Offset = "0x38842B0", VA = "0x183885AB0")]
	public static global::MOBMMDELNAG<T, U, V, W> IDPFAKACPID(global::MOBMMDELNAG<T, U, V, W> EBJJKPBLHEG, Action<T, U, V, W> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3887050", Offset = "0x3885850", VA = "0x183887050")]
	public static global::MOBMMDELNAG<T, U, V, W> MMBIJLAKMHD(global::MOBMMDELNAG<T, U, V, W> EBJJKPBLHEG, Action<T, U, V, W> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CJMDMOCANJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W, X> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W, X> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FDECHEGKDNF<T, U, V, W, X> : global::NMOLAGMGIFL<Action<T, U, V, W, X>>, global::CJMDMOCANJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public FDECHEGKDNF(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x34B84D0", Offset = "0x34B6CD0", VA = "0x1834B84D0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE, X ODLLFOGPPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x34B7E20", Offset = "0x34B6620", VA = "0x1834B7E20", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x34B8430", Offset = "0x34B6C30", VA = "0x1834B8430")]
	public static global::FDECHEGKDNF<T, U, V, W, X> IDPFAKACPID(global::FDECHEGKDNF<T, U, V, W, X> EBJJKPBLHEG, Action<T, U, V, W, X> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x34B8A90", Offset = "0x34B7290", VA = "0x1834B8A90")]
	public static global::FDECHEGKDNF<T, U, V, W, X> MMBIJLAKMHD(global::FDECHEGKDNF<T, U, V, W, X> EBJJKPBLHEG, Action<T, U, V, W, X> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GBNPNCIMPGD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W, X, Y> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W, X, Y> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class PPDMDPBDHCF<T, U, V, W, X, Y> : global::NMOLAGMGIFL<Action<T, U, V, W, X, Y>>, global::GBNPNCIMPGD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2B229E0", Offset = "0x2B211E0", VA = "0x182B229E0")]
	public PPDMDPBDHCF(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3420A70", Offset = "0x341F270", VA = "0x183420A70")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE, X ODLLFOGPPIE, Y GJCOJHOFJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3420690", Offset = "0x341EE90", VA = "0x183420690", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x34209D0", Offset = "0x341F1D0", VA = "0x1834209D0")]
	public static global::PPDMDPBDHCF<T, U, V, W, X, Y> IDPFAKACPID(global::PPDMDPBDHCF<T, U, V, W, X, Y> EBJJKPBLHEG, Action<T, U, V, W, X, Y> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x34212F0", Offset = "0x341FAF0", VA = "0x1834212F0")]
	public static global::PPDMDPBDHCF<T, U, V, W, X, Y> MMBIJLAKMHD(global::PPDMDPBDHCF<T, U, V, W, X, Y> EBJJKPBLHEG, Action<T, U, V, W, X, Y> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MPHIKMFJHBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct CJDEBEMGJKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::MPHIKMFJHBH<T> NPCHBALIDDE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3864FA0", Offset = "0x38637A0", VA = "0x183864FA0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3864FC0", Offset = "0x38637C0", VA = "0x183864FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x757A80", Offset = "0x756280", VA = "0x180757A80")]
		public CJDEBEMGJKM(global::MPHIKMFJHBH<T> NPCHBALIDDE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OKOMEJKLDOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<CJDEBEMGJKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::MPHIKMFJHBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3B877B0", Offset = "0x3B85FB0", VA = "0x183B877B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2F88E40", Offset = "0x2F87640", VA = "0x182F88E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MEGDLMOFOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<CJDEBEMGJKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::MPHIKMFJHBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x462BE90", Offset = "0x462A690", VA = "0x18462BE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2F88E40", Offset = "0x2F87640", VA = "0x182F88E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim DACCGNFANOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T MJBGCHFNGKE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KALEOOCPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x388BB70", Offset = "0x388A370", VA = "0x18388BB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x388BC10", Offset = "0x388A410", VA = "0x18388BC10")]
	public MPHIKMFJHBH(in T MJBGCHFNGKE, int GHDIODBIMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x388BD50", Offset = "0x388A550", VA = "0x18388BD50")]
	public MPHIKMFJHBH(in T MJBGCHFNGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x388BBD0", Offset = "0x388A3D0", VA = "0x18388BBD0")]
	public CJDEBEMGJKM JALOJIIANCF()
	{
		return default(CJDEBEMGJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x388BB90", Offset = "0x388A390", VA = "0x18388BB90")]
	public CJDEBEMGJKM JALOJIIANCF(CancellationToken OHJGLBPIBBN)
	{
		return default(CJDEBEMGJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x388BA10", Offset = "0x388A210", VA = "0x18388BA10")]
	[AsyncStateMachine(typeof(global::MPHIKMFJHBH<>.OKOMEJKLDOH))]
	public Task<CJDEBEMGJKM> FDMBJOIDPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x388B730", Offset = "0x3889F30", VA = "0x18388B730")]
	[AsyncStateMachine(typeof(global::MPHIKMFJHBH<>.MEGDLMOFOCM))]
	public Task<CJDEBEMGJKM> FDMBJOIDPHN(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NKFDHBNDDCB
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C20", Offset = "0x5DE1420", VA = "0x185DE2C20")]
	public static global::MPHIKMFJHBH<FDAEEOMAIHB> AKMEFLONJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2BB0", Offset = "0x5DE13B0", VA = "0x185DE2BB0")]
	public static global::MPHIKMFJHBH<FDAEEOMAIHB> AKMEFLONJDG(int GHDIODBIMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA0350", Offset = "0x2E9EB50", VA = "0x182EA0350")]
	public static global::MPHIKMFJHBH<T> AKMEFLONJDG<T>(in T MJBGCHFNGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C4F0B0", Offset = "0x3C4D8B0", VA = "0x183C4F0B0")]
	public static global::MPHIKMFJHBH<T> AKMEFLONJDG<T>(in T MJBGCHFNGKE, int GHDIODBIMOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OMCCPEBFHLA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> LJFFMFDHIAE(TRequest ANHHADJHMBE, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JCNBAFMJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class LABHJGHDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float PMLCCGHHCIB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan CDGGMGCPBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int OMHCMPAHCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JCNBAFMJPEP LKGHGKLALCD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LABHJGHDKHN PJLEDACBOPG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BOGFENIAEKH
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x2EF3950", Offset = "0x2EF2150", VA = "0x182EF3950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan OKBEPBBDEIL
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2EF3B30", Offset = "0x2EF2330", VA = "0x182EF3B30")]
		public LABHJGHDKHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct ANLLJGFJDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest ANHHADJHMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OHJGLBPIBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> JFGJIKHOIAH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFEA0", Offset = "0x3EDE6A0", VA = "0x183EDFEA0")]
		public ANLLJGFJDGG(TRequest ANHHADJHMBE, TaskCompletionSource<TResult> JFGJIKHOIAH, CancellationToken OHJGLBPIBBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HMAPDGCEMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public HMAPDGCEMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F30", Offset = "0x2F97730", VA = "0x182F98F30")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JMAFFOMBNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::OMCCPEBFHLA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E09970", Offset = "0x3E08170", VA = "0x183E09970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GEAMEMBCLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::OMCCPEBFHLA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ANLLJGFJDGG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4688E90", Offset = "0x4687690", VA = "0x184688E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA0", Offset = "0x85E5A0", VA = "0x18085FDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource NPGMHIOGHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<ANLLJGFJDGG> AIOAGKEAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LABHJGHDKHN EOOGICKMFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly LJFFMFDHIAE DIEDPFGECEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task HIIPACJMHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GGDEIONINLD;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B6D0", Offset = "0x3B89ED0", VA = "0x183B8B6D0")]
	public OMCCPEBFHLA(LJFFMFDHIAE DIEDPFGECEM, [Optional] LABHJGHDKHN EOOGICKMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A050", Offset = "0x3B88850", VA = "0x183B8A050")]
	public Task<TResult> ACOEKDJFEPJ(TRequest ANHHADJHMBE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B2B0", Offset = "0x3B89AB0", VA = "0x183B8B2B0")]
	private void JABKEEKOPMA(ANLLJGFJDGG PAONMDKGDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3B8B5D0", Offset = "0x3B89DD0", VA = "0x183B8B5D0")]
	[AsyncStateMachine(typeof(global::OMCCPEBFHLA<, >.JMAFFOMBNDI))]
	private Task MONLHKCIPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AD70", Offset = "0x3B89570", VA = "0x183B8AD70")]
	private ANLLJGFJDGG FKEDDPMFMCK()
	{
		return default(ANLLJGFJDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A880", Offset = "0x3B89080", VA = "0x183B8A880")]
	[AsyncStateMachine(typeof(global::OMCCPEBFHLA<, >.GEAMEMBCLAO))]
	private Task DHNLOECGEEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3B89EB0", Offset = "0x3B886B0", VA = "0x183B89EB0")]
	private void ACMOJHIMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3B8AAC0", Offset = "0x3B892C0", VA = "0x183B8AAC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HGABOONIJBA<TKey, TVal> : global::OKKLELBPLKM<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int GOJHOPOMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> LNPPEJMJEDP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int LGFGIEJFHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x359B9C0", Offset = "0x359A1C0", VA = "0x18359B9C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int DHKEKPHEDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x359B340", Offset = "0x3599B40", VA = "0x18359B340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x359B410", Offset = "0x3599C10", VA = "0x18359B410", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x359B9F0", Offset = "0x359A1F0", VA = "0x18359B9F0")]
	public HGABOONIJBA(int JAFEKEGLGFD, [Optional] GAOLFALEIGB CFFBBLNCJIB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x359B370", Offset = "0x3599B70", VA = "0x18359B370")]
	public void DEDCIFDKGFE(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF, bool ICJJDLFCOFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x359B8D0", Offset = "0x359A0D0", VA = "0x18359B8D0")]
	public bool KLEADPPOGKC(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x359B470", Offset = "0x3599C70", VA = "0x18359B470", Slot = "6")]
	public override bool EPBHELLGDLM(TKey ANFJFPDCAEM, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x359B510", Offset = "0x3599D10", VA = "0x18359B510")]
	public bool GEEMOONNMKA(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x359B720", Offset = "0x3599F20", VA = "0x18359B720")]
	public bool HNGKFOGDOLL(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x359B950", Offset = "0x359A150", VA = "0x18359B950", Slot = "7")]
	public override void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x359B830", Offset = "0x359A030", VA = "0x18359B830")]
	private bool IGJFMLPJNAO(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class OKKLELBPLKM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int GAOLFALEIGB(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DJBGFGELDPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey PIDBPEBBCKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int ADODPFDEIHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x74FA30", Offset = "0x74E230", VA = "0x18074FA30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x766650", Offset = "0x764E50", VA = "0x180766650")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime EPCHOPIAHLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x726A70", Offset = "0x725270", VA = "0x180726A70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DB30", Offset = "0x3C1C330", VA = "0x183C1DB30")]
		public DJBGFGELDPM(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int PGDGBOPBJMB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<DJBGFGELDPM>> JCNJOKIICPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<DJBGFGELDPM> DOOPABKFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly GAOLFALEIGB CFFBBLNCJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan MGOMJKLLFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DFOOBNHOENJ OHJBCFBOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int LPFKHGINPIO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x749970", Offset = "0x748170", VA = "0x180749970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool PHDEEPDPCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3B7FDD0", Offset = "0x3B7E5D0", VA = "0x183B7FDD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int LGFGIEJFHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x75E750", Offset = "0x75CF50", VA = "0x18075E750", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int LGKBEOCJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x2EEB560", Offset = "0x2EE9D60", VA = "0x182EEB560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x329CF80", Offset = "0x329B780", VA = "0x18329CF80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> BOJKPFIKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3B7FE60", Offset = "0x3B7E660", VA = "0x183B7FE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3B82250", Offset = "0x3B80A50", VA = "0x183B82250")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3B800B0", Offset = "0x3B7E8B0", VA = "0x183B800B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3B83350", Offset = "0x3B81B50", VA = "0x183B83350")]
	public OKKLELBPLKM(int JAFEKEGLGFD, [Optional] GAOLFALEIGB CFFBBLNCJIB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3B82EE0", Offset = "0x3B816E0", VA = "0x183B82EE0")]
	public OKKLELBPLKM(TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3B82C10", Offset = "0x3B81410", VA = "0x183B82C10")]
	public OKKLELBPLKM(int JAFEKEGLGFD, TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3B830D0", Offset = "0x3B818D0", VA = "0x183B830D0")]
	public OKKLELBPLKM(int JAFEKEGLGFD, GAOLFALEIGB CFFBBLNCJIB, TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3B81420", Offset = "0x3B7FC20", VA = "0x183B81420")]
	public void JCENNMIHJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B80960", Offset = "0x3B7F160", VA = "0x183B80960")]
	public void DIMECELKFHA(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FC60", Offset = "0x3B7E460", VA = "0x183B7FC60")]
	public bool ADDEDGCCJIP(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B81650", Offset = "0x3B7FE50", VA = "0x183B81650")]
	private TVal KEEHOGKCDPF(TKey ANFJFPDCAEM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B80BC0", Offset = "0x3B7F3C0", VA = "0x183B80BC0", Slot = "6")]
	public virtual bool EPBHELLGDLM(TKey ANFJFPDCAEM, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B82290", Offset = "0x3B80A90", VA = "0x183B82290", Slot = "7")]
	public virtual void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B81F50", Offset = "0x3B80750", VA = "0x183B81F50")]
	private bool LJNMODDAJLC(DJBGFGELDPM DKAKMJOEBKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B82300", Offset = "0x3B80B00", VA = "0x183B82300")]
	private void PKLEKPLKJHN(LinkedListNode<DJBGFGELDPM> BLONFKJEAEN, TVal GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B800F0", Offset = "0x3B7E8F0", VA = "0x183B800F0")]
	private void DIBDKEEBIJK(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B81A60", Offset = "0x3B80260", VA = "0x183B81A60")]
	private void KGAGJPJBEEP(DJBGFGELDPM DKAKMJOEBKG, TVal GCFEAMOOPMJ, int OFPFHBDEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class EELEHJFJGOP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> PIJDNOPJENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> KHBEEAKIEHB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F30", Offset = "0x2F97730", VA = "0x182F98F30", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FC95A0", Offset = "0x2FC7DA0", VA = "0x182FC95A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3843750", Offset = "0x3841F50", VA = "0x183843750", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x32A91C0", Offset = "0x32A79C0", VA = "0x1832A91C0", Slot = "11")]
	public void Add(T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3843270", Offset = "0x3841A70", VA = "0x183843270")]
	public bool KFCNCOMHECF(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x38435F0", Offset = "0x3841DF0", VA = "0x1838435F0", Slot = "15")]
	public bool Remove(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x34C4C00", Offset = "0x34C3400", VA = "0x1834C4C00", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2FCB270", Offset = "0x2FC9A70", VA = "0x182FCB270", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3842EB0", Offset = "0x38416B0", VA = "0x183842EB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3842F10", Offset = "0x3841710", VA = "0x183842F10", Slot = "13")]
	public bool Contains(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8EF0", Offset = "0x2FC76F0", VA = "0x182FC8EF0", Slot = "14")]
	public void CopyTo(T[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3671360", Offset = "0x366FB60", VA = "0x183671360", Slot = "6")]
	public int IndexOf(T EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x38430E0", Offset = "0x38418E0", VA = "0x1838430E0", Slot = "7")]
	public void Insert(int MMABPPDCBIB, T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3843490", Offset = "0x3841C90", VA = "0x183843490", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3843010", Offset = "0x3841810", VA = "0x183843010")]
	public void FBCBPBLMBPN(Predicate<T> AJKDGHOLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3842E80", Offset = "0x3841680", VA = "0x183842E80")]
	public void AACKGKDDCPN(Comparison<T> IFOABGFNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3843670", Offset = "0x3841E70", VA = "0x183843670")]
	public EELEHJFJGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KOBCAMDIGIB
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1CB0", Offset = "0x5DE04B0", VA = "0x185DE1CB0")]
	public static Vector3 KAKGPGIAIBI(this GameObject HBGIADIFHEC, float JJPEEIODEEA)
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
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C70", Offset = "0xCD5470", VA = "0x180CD6C70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E36550", Offset = "0x1E34D50", VA = "0x181E36550")]
		public SerializedGuid(in Guid PMPGCMIMMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE47E0", Offset = "0x5DE2FE0", VA = "0x185DE47E0")]
		public static SerializedGuid NPNIGDHEPOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE44A0", Offset = "0x5DE2CA0", VA = "0x185DE44A0")]
		public static SerializedGuid BHKBFKPNFME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4750", Offset = "0x5DE2F50", VA = "0x185DE4750")]
		public bool KJIIGMAMMJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E36520", Offset = "0x1E34D20", VA = "0x181E36520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4870", Offset = "0x5DE3070", VA = "0x185DE4870", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE46C0", Offset = "0x5DE2EC0", VA = "0x185DE46C0")]
		public bool FMLLLJFHODI(in Guid PMPGCMIMMLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4530", Offset = "0x5DE2D30", VA = "0x185DE4530", Slot = "7")]
		public bool Equals(SerializedGuid IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE45E0", Offset = "0x5DE2DE0", VA = "0x185DE45E0", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1E36470", Offset = "0x1E34C70", VA = "0x181E36470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1E362B0", Offset = "0x1E34AB0", VA = "0x181E362B0", Slot = "6")]
		public int CompareTo(SerializedGuid IIKMMJKCGDO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BODPKAIDIMP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type BCJLHCAMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string NOMMOFADICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool NHDKPJIGOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool ABFANCDCEAA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFA60", Offset = "0x5DDE260", VA = "0x185DDFA60")]
	public BODPKAIDIMP(Type KEODDAOFGGO, string CJPJHGPMLHD, bool LCGHEKJFNGC = false, bool PBMBOPEBLHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LFAILEJCPCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface AHMDJHOONLB<T> : LFAILEJCPCE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool EIGFMBDEHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string APPFLCHEPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AHMDJHOONLB<T> AEFCJKHDPNK(Action<T> AKCLNHAOBHG);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AHMDJHOONLB<T> DAGMPELCNAM(Action<T> AKCLNHAOBHG);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AHMDJHOONLB<T> ALLPCPFHBDC(Action<T, T> CMIAJMOLLPF);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AHMDJHOONLB<T> MAGIFDLANLF(Action<T, T> CMIAJMOLLPF);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AHMDJHOONLB<T> BNIKKOFPDPN(Action<string> INNHFKAAFAC);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AHMDJHOONLB<T> GFPCDGJKKPI(Action<string> INNHFKAAFAC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KKJELACEOOC<T> : global::AHMDJHOONLB<T>, LFAILEJCPCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::DCBNKGAHPLA<T, T> CIHNAHAGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DPCNIAMGAEP<T> FDBFGFPGOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DPCNIAMGAEP<string> DMJFIMFIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string OJDKKCJFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BBELMPNHPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool OIIOIGHKJKL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x34AC400", Offset = "0x34AAC00", VA = "0x1834AC400", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EIGFMBDEHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB30", Offset = "0x6F9330", VA = "0x1806FAB30", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string APPFLCHEPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x20345D0", Offset = "0x2032DD0", VA = "0x1820345D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9000", Offset = "0x3DC7800", VA = "0x183DC9000")]
	private void HMGIAJOOMGI(T PLNNMJAODIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC90F0", Offset = "0x3DC78F0", VA = "0x183DC90F0")]
	private void NIOOJHFGFEG(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x3DC91A0", Offset = "0x3DC79A0", VA = "0x183DC91A0")]
	public void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8E50", Offset = "0x3DC7650", VA = "0x183DC8E50", Slot = "6")]
	public global::AHMDJHOONLB<T> ALLPCPFHBDC(Action<T, T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x3DC90A0", Offset = "0x3DC78A0", VA = "0x183DC90A0", Slot = "7")]
	public global::AHMDJHOONLB<T> MAGIFDLANLF(Action<T, T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8DC0", Offset = "0x3DC75C0", VA = "0x183DC8DC0", Slot = "4")]
	public global::AHMDJHOONLB<T> AEFCJKHDPNK(Action<T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8F40", Offset = "0x3DC7740", VA = "0x183DC8F40", Slot = "5")]
	public global::AHMDJHOONLB<T> DAGMPELCNAM(Action<T> AKCLNHAOBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8EA0", Offset = "0x3DC76A0", VA = "0x183DC8EA0", Slot = "8")]
	public global::AHMDJHOONLB<T> BNIKKOFPDPN(Action<string> INNHFKAAFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x3DC8F90", Offset = "0x3DC7790", VA = "0x183DC8F90", Slot = "9")]
	public global::AHMDJHOONLB<T> GFPCDGJKKPI(Action<string> INNHFKAAFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9250", Offset = "0x3DC7A50", VA = "0x183DC9250")]
	public KKJELACEOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OHBLJLNBLMP
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DEDEHDNJJCA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::AHMDJHOONLB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::MJBDKPPKHFK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public DEDEHDNJJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x42445D0", Offset = "0x4242DD0", VA = "0x1842445D0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x3964960", Offset = "0x3963160", VA = "0x183964960")]
	public static global::AGDEEHNAPKP<T> HGMFBEDJIMN<T>(this global::AHMDJHOONLB<T> MAKNKOKDDOA, Action<T> FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class BJNCMLEHIAG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct LNPAECEJEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long EIAHNAFDEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long FGIIAJGNNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int NMFIFHBNGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int NMPBBBIDKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool BAEDMNMOCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string KNCEBOMBPHO;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x375C970", Offset = "0x375B170", VA = "0x18375C970")]
		public LNPAECEJEGM(long EIAHNAFDEHI, int NMFIFHBNGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x375C9E0", Offset = "0x375B1E0", VA = "0x18375C9E0")]
		public LNPAECEJEGM(long EIAHNAFDEHI, long FGIIAJGNNDM, int NMFIFHBNGND, int NMPBBBIDKDM, bool BAEDMNMOCKP, string KNCEBOMBPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x375C800", Offset = "0x375B000", VA = "0x18375C800")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FDJNMCLKBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x375C790", Offset = "0x375AF90", VA = "0x18375C790")]
		public int CAFKNPIMGNF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x375C7E0", Offset = "0x375AFE0", VA = "0x18375C7E0")]
		public int EGMKIACCGBK(int DLFEFDKNEAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x375C900", Offset = "0x375B100", VA = "0x18375C900")]
		public double LOOBKEDDHKA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x375C870", Offset = "0x375B070", VA = "0x18375C870")]
		public LNPAECEJEGM ILFKOHEDJFD(long FGIIAJGNNDM, int NMPBBBIDKDM)
		{
			return default(LNPAECEJEGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class HKLBBGEFPMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::BJNCMLEHIAG<TKey> MDGABGKAFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<HKLBBGEFPMO> CDLBHKFHOPE;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FFLCEGPKPGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x33712E0", Offset = "0x336FAE0", VA = "0x1833712E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x3370FD0", Offset = "0x336F7D0", VA = "0x183370FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<HKLBBGEFPMO> KNPEBNPGMCN
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x3371000", Offset = "0x336F800", VA = "0x183371000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LNPAECEJEGM KMHNFPHMNJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xE20950", Offset = "0xE1F150", VA = "0x180E20950")]
			[CompilerGenerated]
			get
			{
				return default(LNPAECEJEGM);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x33712B0", Offset = "0x336FAB0", VA = "0x1833712B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3371310", Offset = "0x336FB10", VA = "0x183371310")]
		internal HKLBBGEFPMO(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, TKey AGPLDPOAAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3370EC0", Offset = "0x336F6C0", VA = "0x183370EC0")]
		public HKLBBGEFPMO ADEIHGCDFEB(TKey AGPLDPOAAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x33711D0", Offset = "0x336F9D0", VA = "0x1833711D0")]
		public void EFBOGNCGFEH(TKey AGPLDPOAAIC, Action<HKLBBGEFPMO> NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x348AB10", Offset = "0x3489310", VA = "0x18348AB10")]
		public T EFBOGNCGFEH<T>(TKey AGPLDPOAAIC, Func<HKLBBGEFPMO, T> LILPACFFGKO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x348A9A0", Offset = "0x34891A0", VA = "0x18348A9A0")]
		[AsyncStateMachine(typeof(MDLEHCNIPJO))]
		public Task<T> AGGPDBLBDGM<T>(TKey AGPLDPOAAIC, Func<HKLBBGEFPMO, Task<T>> LILPACFFGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3371020", Offset = "0x336F820", VA = "0x183371020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FMBGLGHAIFI : IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LNPAECEJEGM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::BJNCMLEHIAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LNPAECEJEGM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LNPAECEJEGM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x32DFA00", Offset = "0x32DE200", VA = "0x1832DFA00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNPAECEJEGM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x426F6A0", Offset = "0x426DEA0", VA = "0x18426F6A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x32DFC60", Offset = "0x32DE460", VA = "0x1832DFC60")]
		[DebuggerHidden]
		public FMBGLGHAIFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x32B3440", Offset = "0x32B1C40", VA = "0x1832B3440", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x426F2F0", Offset = "0x426DAF0", VA = "0x18426F2F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x426F700", Offset = "0x426DF00", VA = "0x18426F700")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x426F660", Offset = "0x426DE60", VA = "0x18426F660", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x426F5A0", Offset = "0x426DDA0", VA = "0x18426F5A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x2EED650", Offset = "0x2EEBE50", VA = "0x182EED650", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NGBONLLHAFA : IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LNPAECEJEGM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private HKLBBGEFPMO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HKLBBGEFPMO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::BJNCMLEHIAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<HKLBBGEFPMO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LNPAECEJEGM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LNPAECEJEGM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x32DFA00", Offset = "0x32DE200", VA = "0x1832DFA00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNPAECEJEGM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x32DFAA0", Offset = "0x32DE2A0", VA = "0x1832DFAA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x32DFC60", Offset = "0x32DE460", VA = "0x1832DFC60")]
		[DebuggerHidden]
		public NGBONLLHAFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x32DFB00", Offset = "0x32DE300", VA = "0x1832DFB00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x32DF380", Offset = "0x32DDB80", VA = "0x1832DF380", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x32DFBA0", Offset = "0x32DE3A0", VA = "0x1832DFBA0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x32DFC00", Offset = "0x32DE400", VA = "0x1832DFC00")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x32DFA60", Offset = "0x32DE260", VA = "0x1832DFA60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x32DF920", Offset = "0x32DE120", VA = "0x1832DF920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x32DFA30", Offset = "0x32DE230", VA = "0x1832DFA30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LNPAECEJEGM> DOEBILGGGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LNPAECEJEGM> GPJGGCIAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::BJNCMLEHIAG<TKey>> KKOHGLJDFLM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string LPMFJJDBCLK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly HKLBBGEFPMO BPFCCAGJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int JOCOENCMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch GFEIFEIINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int MONKABKODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string FBCJFKBFIAC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public HKLBBGEFPMO EDMCMPMCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FFLCEGPKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x72D250", Offset = "0x72BA50", VA = "0x18072D250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3669F20", Offset = "0x3668720", VA = "0x183669F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long AEGLNCNFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x366A1B0", Offset = "0x36689B0", VA = "0x18366A1B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int LFLKKGCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3669EF0", Offset = "0x36686F0", VA = "0x183669EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x366A250", Offset = "0x3668A50", VA = "0x18366A250")]
	public BJNCMLEHIAG(TKey FNHCDINDGMP, [Optional] int? NMFIFHBNGND, [Optional][CanBeNull] Stopwatch GFEIFEIINNH, [Optional] Action<TKey, LNPAECEJEGM> DOEBILGGGGH, [Optional] Action<TKey, LNPAECEJEGM> GPJGGCIAPDL, [Optional] Action<global::BJNCMLEHIAG<TKey>> KKOHGLJDFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x3669FA0", Offset = "0x36687A0", VA = "0x183669FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x366A190", Offset = "0x3668990", VA = "0x18366A190")]
	public void GIIJFBPLAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3669F80", Offset = "0x3668780", VA = "0x183669F80")]
	public void BHAELNLPJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x366A030", Offset = "0x3668830", VA = "0x18366A030")]
	[IteratorStateMachine(typeof(global::BJNCMLEHIAG<>.FMBGLGHAIFI))]
	public IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)> FDHNMIHJEDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x366A0C0", Offset = "0x36688C0", VA = "0x18366A0C0")]
	[IteratorStateMachine(typeof(global::BJNCMLEHIAG<>.NGBONLLHAFA))]
	private IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)> FDHNMIHJEDH(List<TKey> OIPMKBNDJIF, HKLBBGEFPMO KEFDBDPEAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x366A1D0", Offset = "0x36689D0", VA = "0x18366A1D0")]
	private (long, int) OHMFFEMKPKG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class BKMMCAIJIPN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	protected BKMMCAIJIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class GONCNLPPGKG<TKey> : global::BKMMCAIJIPN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string CIGHKPDNAAM(TKey AGPLDPOAAIC);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x41D7C50", Offset = "0x41D6450", VA = "0x1841D7C50")]
	protected string PHKFAOFNMIJ(double BDOOMGDLFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x41D7CC0", Offset = "0x41D64C0", VA = "0x1841D7CC0")]
	protected string PHLMDFHJIAF(int OHMMPKKFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x41D7C10", Offset = "0x41D6410", VA = "0x1841D7C10")]
	private static string JGMOACDJIBB(TKey AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x41D7B60", Offset = "0x41D6360", VA = "0x1841D7B60", Slot = "4")]
	public override string IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x41D7A30", Offset = "0x41D6230", VA = "0x1841D7A30")]
	public string IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, [NotNull] CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, [NotNull] CIGHKPDNAAM AAJNABKKGDK);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x32E1400", Offset = "0x32DFC00", VA = "0x1832E1400")]
	protected GONCNLPPGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GCNCAKNNGIJ<TKey> : global::BKMMCAIJIPN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string NFBCOBEBDIL(TKey AGPLDPOAAIC);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int KIJDMBPCMOK = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string NNPOMIOKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double OACNEEOHPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool GJBCCHDHDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int FHAFKLNOIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> NJKOGIKPGPG;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x4687B70", Offset = "0x4686370", VA = "0x184687B70")]
	private static string JGMOACDJIBB(TKey AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x4687D30", Offset = "0x4686530", VA = "0x184687D30")]
	public GCNCAKNNGIJ(string NNPOMIOKKJH = "F2", double OACNEEOHPJL = double.MaxValue, bool GJBCCHDHDDA = false, int FHAFKLNOIJM = int.MaxValue, [Optional] ISet<string> NJKOGIKPGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x4687910", Offset = "0x4686110", VA = "0x184687910", Slot = "4")]
	public override Dictionary<string, string> IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x46872F0", Offset = "0x4685AF0", VA = "0x1846872F0")]
	private bool EMOHBPLHECC(string BFOOEFHPOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x46873D0", Offset = "0x4685BD0", VA = "0x1846873D0")]
	public Dictionary<string, string> IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, NFBCOBEBDIL AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x46879C0", Offset = "0x46861C0", VA = "0x1846879C0")]
	private string JBAIIKIBDCM(StringBuilder AAJECMHBKEK, List<TKey> IBDMGOKKIIH, NFBCOBEBDIL AAJNABKKGDK, bool GNHNDJMDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x4687BB0", Offset = "0x46863B0", VA = "0x184687BB0")]
	private static void NIIIMEJIMPJ(StringBuilder FNLJIBFFFED, string NKIACAFOPEC, bool IDNFOMMMPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OHLLBLKBDOJ<TKey> : global::GONCNLPPGKG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MCIANFMPAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CIGHKPDNAAM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::OHLLBLKBDOJ<TKey> KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int KPNKHACFCNB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] KLIMGACBDBE;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3B72F70", Offset = "0x3B71770", VA = "0x183B72F70")]
	private OHLLBLKBDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3B71E90", Offset = "0x3B70690", VA = "0x183B71E90", Slot = "5")]
	protected override string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3B72D80", Offset = "0x3B71580", VA = "0x183B72D80")]
	[CompilerGenerated]
	internal static string CJEOPKDPBKP(string KADCFLNKGNA, TKey AGPLDPOAAIC, ref MCIANFMPAMP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PDNOOOCFLKB<TKey> : global::GONCNLPPGKG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CCDIALGFEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CIGHKPDNAAM keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public CCDIALGFEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2B21BD0", Offset = "0x2B203D0", VA = "0x182B21BD0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x3B1FB60", Offset = "0x3B1E360", VA = "0x183B1FB60", Slot = "5")]
	protected override string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x34C4D90", Offset = "0x34C3590", VA = "0x1834C4D90")]
	public PDNOOOCFLKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class NDIEDDEPKPJ : global::BJNCMLEHIAG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JFOKEAKBKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<NDIEDDEPKPJ> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public JFOKEAKBKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1800", Offset = "0x5DE0000", VA = "0x185DE1800")]
		internal void <Wrap>b__0(global::BJNCMLEHIAG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5DE29E0", Offset = "0x5DE11E0", VA = "0x185DE29E0")]
	public NDIEDDEPKPJ([Optional] string KCHKKMCHFIH, [Optional] int? NMFIFHBNGND, [Optional] Stopwatch GFEIFEIINNH, [Optional] Action<string, LNPAECEJEGM> DOEBILGGGGH, [Optional] Action<string, LNPAECEJEGM> GPJGGCIAPDL, [Optional] Action<NDIEDDEPKPJ> KKOHGLJDFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2900", Offset = "0x5DE1100", VA = "0x185DE2900")]
	private static Action<global::BJNCMLEHIAG<string>> EFBOGNCGFEH(Action<NDIEDDEPKPJ> FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class DFOOBNHOENJ
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class PICEPJLJLBI : DFOOBNHOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static DFOOBNHOENJ KGCADEGMLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2D70", Offset = "0x5DE1570", VA = "0x185DE2D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime EMDDPJGEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2D20", Offset = "0x5DE1520", VA = "0x185DE2D20", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float LLKKFDLMBNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2D10", Offset = "0x5DE1510", VA = "0x185DE2D10", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2E70", Offset = "0x5DE1670", VA = "0x185DE2E70")]
		public PICEPJLJLBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static DFOOBNHOENJ PPPIFNABGAN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static DFOOBNHOENJ PJLEDACBOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0150", Offset = "0x5DDE950", VA = "0x185DE0150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime EMDDPJGEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float LLKKFDLMBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected DFOOBNHOENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FGAIIBJBBMP : global::GNGBMCIEECH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D80", Offset = "0x5DDF580", VA = "0x185DE0D80")]
	public FGAIIBJBBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GNGBMCIEECH<T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x26B3840", Offset = "0x26B2040", VA = "0x1826B3840", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2033330", Offset = "0x2031B30", VA = "0x182033330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x41D61F0", Offset = "0x41D49F0", VA = "0x1841D61F0")]
	public GNGBMCIEECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class IMKJDAPJEAB : global::IMLPLBFJDJP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1250", Offset = "0x5DDFA50", VA = "0x185DE1250")]
	public IMKJDAPJEAB(Exception GHAPGMJOMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IMLPLBFJDJP<T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x26B3840", Offset = "0x26B2040", VA = "0x1826B3840", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2033330", Offset = "0x2031B30", VA = "0x182033330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFCB0", Offset = "0x3BDE4B0", VA = "0x183BDFCB0")]
	public IMLPLBFJDJP(Exception GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GEGPNHBEGBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	MLEPGEJLFCO KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FGIBMGOBPLI<T> : GEGPNHBEGBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class FKGLPOMCPFC<TTask, T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ALELFAEDEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::FKGLPOMCPFC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public ALELFAEDEJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool GMLGHDCEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> IIDIGDMKMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource NLJGOGNMNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext FOMFNOLKKGF;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x329E290", Offset = "0x329CA90", VA = "0x18329E290", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DHNLGBFLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6E3880", Offset = "0x6E2080", VA = "0x1806E3880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x426C840", Offset = "0x426B040", VA = "0x18426C840")]
	static FKGLPOMCPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x426CB80", Offset = "0x426B380", VA = "0x18426CB80")]
	protected FKGLPOMCPFC(TTask IIDIGDMKMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x426C330", Offset = "0x426AB30", VA = "0x18426C330", Slot = "1")]
	~FKGLPOMCPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x426C300", Offset = "0x426AB00", VA = "0x18426C300", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x426C560", Offset = "0x426AD60", VA = "0x18426C560")]
	private void PDHGAAMLKHD(bool EJOIIPPLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LJMODFCJOJF(TTask HHCOHFMAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KJHCAMAKIPE();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x426C3A0", Offset = "0x426ABA0", VA = "0x18426C3A0")]
	[CompilerGenerated]
	private void LMOLHNLLFOC(object KDAIJKFCLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PIFJCMLEGIB
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NIKMEKEGHNH FMCFBCOHGAD;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AKIFNHNILDO : PIFJCMLEGIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GHICACEIPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float PNNGHFKIKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float PCGAAFFOKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool DPHKGIJFNKP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float ADODPFDEIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0E60", Offset = "0x5DDF660", VA = "0x185DE0E60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0FF0", Offset = "0x5DDF7F0", VA = "0x185DE0FF0")]
		public GHICACEIPLG(float OMKHMNIPPGH, float BDPJJHLGMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0E70", Offset = "0x5DDF670", VA = "0x185DE0E70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class OCKEGFKDCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AKIFNHNILDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public OCKEGFKDCEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int JAFEKEGLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int HPCHDAJPBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PIFJCMLEGIB[] PGJANELEINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NIKMEKEGHNH[] OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GHICACEIPLG[] PNCAGGPAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GHICACEIPLG BIACHIIIGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly CKFJHMPIILJ AHFLGPMEIOI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GHICACEIPLG CJJJLACGHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1474240", Offset = "0x1472A40", VA = "0x181474240")]
		get
		{
			return default(GHICACEIPLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCAF0", Offset = "0x5DDB2F0", VA = "0x185DDCAF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCB10", Offset = "0x5DDB310", VA = "0x185DDCB10", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC810", Offset = "0x5DDB010", VA = "0x185DDC810", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCC20", Offset = "0x5DDB420", VA = "0x185DDCC20")]
	public AKIFNHNILDO(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC8D0", Offset = "0x5DDB0D0", VA = "0x185DDC8D0")]
	public CKFJHMPIILJ CDLAIHLNHJD(GHICACEIPLG NMJNDGPGMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC370", Offset = "0x5DDAB70", VA = "0x185DDC370")]
	public void ALKFMJAKLJC(PIFJCMLEGIB FPPKJHIMLIC, [Optional] GHICACEIPLG HKNNAGFHHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCBD0", Offset = "0x5DDB3D0", VA = "0x185DDCBD0")]
	internal int OCHPPPJPAPL(PIFJCMLEGIB CFLBGBODMIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC7C0", Offset = "0x5DDAFC0", VA = "0x185DDC7C0")]
	internal GHICACEIPLG BHCEDCGILFF(int MMABPPDCBIB)
	{
		return default(GHICACEIPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC960", Offset = "0x5DDB160", VA = "0x185DDC960", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void NIKMEKEGHNH(float JGHPCJLFMGN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class COOGKMCINEN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float DIKCJJNINAA = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class LGEBPCPNCPF
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class AEFGPOKHAPO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly PIFJCMLEGIB CFLBGBODMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly NIKMEKEGHNH FNAODFKKBJA;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC2E0", Offset = "0x5DDAAE0", VA = "0x185DDC2E0")]
		public AEFGPOKHAPO(PIFJCMLEGIB CFLBGBODMIH, NIKMEKEGHNH FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC290", Offset = "0x5DDAA90", VA = "0x185DDC290", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1F80", Offset = "0x5DE0780", VA = "0x185DE1F80")]
	internal static bool ENCHCIJGIFK(float DOGOAAONBOH, float ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4DB8F60", Offset = "0x4DB7760", VA = "0x184DB8F60")]
	internal static float LPFCKCBAFFB(float DOGOAAONBOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2000", Offset = "0x5DE0800", VA = "0x185DE2000")]
	public static IDisposable POEBOEPEOIJ(this PIFJCMLEGIB CFLBGBODMIH, NIKMEKEGHNH FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CKFJHMPIILJ : PIFJCMLEGIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JGHPCJLFMGN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6FD120", Offset = "0x6FB920", VA = "0x1806FD120", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFB70", Offset = "0x5DDE370", VA = "0x185DDFB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFC30", Offset = "0x5DDE430", VA = "0x185DDFC30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5DDFAD0", Offset = "0x5DDE2D0", VA = "0x185DDFAD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CKFJHMPIILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class LHEFBPINJBA
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2130", Offset = "0x5DE0930", VA = "0x185DE2130")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this KPJDGDIGJNP OAAOCIEIAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE21A0", Offset = "0x5DE09A0", VA = "0x185DE21A0")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this KPJDGDIGJNP OAAOCIEIAFG, HashAlgorithmName MCFIBNJOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2330", Offset = "0x5DE0B30", VA = "0x185DE2330")]
	public static bool MIIPHDNHAHG([CanBeNull] this KPJDGDIGJNP OAAOCIEIAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE24C0", Offset = "0x5DE0CC0", VA = "0x185DE24C0")]
	public static bool MIIPHDNHAHG([CanBeNull] this KPJDGDIGJNP OAAOCIEIAFG, out string OJDKKCJFMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE20C0", Offset = "0x5DE08C0", VA = "0x185DE20C0")]
	private static string DEMNAIFENGK([CanBeNull] byte[] CDDAIIMDJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2210", Offset = "0x5DE0A10", VA = "0x185DE2210")]
	private static bool JKNPBFCDDLH([NotNull] KPJDGDIGJNP OAAOCIEIAFG, [CanBeNull] out byte[] DILDGDHOMIH, [CanBeNull] out byte[] INMNPIJPEAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class APMFDMIANPO
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCFD0", Offset = "0x5DDB7D0", VA = "0x185DDCFD0")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this EMENMJPDFJB NCOFHLECFIE, byte[] JMMNMEPNPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCDA0", Offset = "0x5DDB5A0", VA = "0x185DDCDA0")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this EMENMJPDFJB NCOFHLECFIE, HashAlgorithmName MCFIBNJOIKL, byte[] JMMNMEPNPBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface EMENMJPDFJB
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FPALDDOOOME);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KPJDGDIGJNP : EMENMJPDFJB
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] CMPINFJEEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] FHCNCALCCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object HIHJFPIAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BKDJJEMFJOB
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class JALPOKBPHJB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1300", Offset = "0x5DDFB00", VA = "0x185DE1300")]
		public JALPOKBPHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE12A0", Offset = "0x5DDFAA0", VA = "0x185DE12A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte DADLCLOOKJG = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte DCDDOPMALJI = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> BJMHJKDBLOI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool LHBHCAOCINI;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x354F9C0", Offset = "0x354E1C0", VA = "0x18354F9C0")]
	[Conditional("UNITY_EDITOR")]
	private static void NLAGBCOMOED<T>(params T[] NKGLGEEIDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF1E0", Offset = "0x5DDD9E0", VA = "0x185DDF1E0")]
	public static IDisposable FGKCEBBCDME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF0F0", Offset = "0x5DDD8F0", VA = "0x185DDF0F0")]
	public static void ENFONHNGHAF(this IncrementalHash LNBHNBAENDB, [CanBeNull] GameObject HBGIADIFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x354F400", Offset = "0x354DC00", VA = "0x18354F400")]
	public static void ENFONHNGHAF<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] T CHHHDNBJJIO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x354F4D0", Offset = "0x354DCD0", VA = "0x18354F4D0")]
	public static void NFFBNAAJJGF<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] T NCOFHLECFIE) where T : EMENMJPDFJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x354F560", Offset = "0x354DD60", VA = "0x18354F560")]
	public static void NJPJJKAOFIE<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] IList<T> BIPCDPIJBPC) where T : EMENMJPDFJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF350", Offset = "0x5DDDB50", VA = "0x185DDF350")]
	private static bool HHFLDIIELHH([CanBeNull] EMENMJPDFJB NCOFHLECFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF280", Offset = "0x5DDDA80", VA = "0x185DDF280")]
	public static void FLNBHFPDBIJ(this IncrementalHash FPALDDOOOME, [CanBeNull] string OBNGFNJHKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEF20", Offset = "0x5DDD720", VA = "0x185DDEF20")]
	public static void DOMCPMKMGHD(this IncrementalHash FPALDDOOOME, long FNLGLEICPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF440", Offset = "0x5DDDC40", VA = "0x185DDF440")]
	public static void JHAJJIMHLFC(this IncrementalHash FPALDDOOOME, int BDPKOABHKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE8F0", Offset = "0x5DDD0F0", VA = "0x185DDE8F0")]
	public static void BHOMOANMNBK(this IncrementalHash FPALDDOOOME, short BOCPNHKEPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF610", Offset = "0x5DDDE10", VA = "0x185DDF610")]
	public static void LLNPAJGKDLP(this IncrementalHash FPALDDOOOME, byte EPIAEKKNOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDECF0", Offset = "0x5DDD4F0", VA = "0x185DDECF0")]
	public static void DEOANDFALBN(this IncrementalHash FPALDDOOOME, bool HBAIMOMFGGB, bool HCBBLGMLJNH = false, bool LCDDDJNFILG = false, bool NKAFFDGCABC = false, bool BEIGJDNLIOE = false, bool LIDFMKGDJAI = false, bool DBPJADEJBCE = false, bool ALCEMJBEMAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x354ED10", Offset = "0x354D510", VA = "0x18354ED10")]
	public static void EFGEJGIBEIF<T>(this IncrementalHash FPALDDOOOME, T GKMCJJIMLBK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF8F0", Offset = "0x5DDE0F0", VA = "0x185DDF8F0")]
	public static void PECBLKDJKKO(this IncrementalHash FPALDDOOOME, float DDBDCGCCAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF3E0", Offset = "0x5DDDBE0", VA = "0x185DDF3E0")]
	public static void IAJOCOIGHIN(this IncrementalHash FPALDDOOOME, double EMJADNBAEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEAC0", Offset = "0x5DDD2C0", VA = "0x185DDEAC0")]
	public static void BMDPEHBPNKA(this IncrementalHash FPALDDOOOME, ulong LIDFLJDNAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEEC0", Offset = "0x5DDD6C0", VA = "0x185DDEEC0")]
	public static void DHGNCNMPNIN(this IncrementalHash FPALDDOOOME, uint ABHEDMODIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF2E0", Offset = "0x5DDDAE0", VA = "0x185DDF2E0")]
	public static void GNNNKLAPLGG(this IncrementalHash FPALDDOOOME, ushort LGLODLCLONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF780", Offset = "0x5DDDF80", VA = "0x185DDF780")]
	public static void MOBECALLLMO(this IncrementalHash FPALDDOOOME, Vector3 GALABPAIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEB30", Offset = "0x5DDD330", VA = "0x185DDEB30")]
	public static void CHIPPGOLHME(this IncrementalHash FPALDDOOOME, Quaternion FFHCCELDPMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KJAOIBGKBMH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type BCJLHCAMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string NOMMOFADICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool NHDKPJIGOHG;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A90", Offset = "0x5DE0290", VA = "0x185DE1A90")]
	public KJAOIBGKBMH(Type KEODDAOFGGO, string CJPJHGPMLHD, bool LCGHEKJFNGC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class MGDEKNPNGNN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2810", Offset = "0x5DE1010", VA = "0x185DE2810")]
	public MGDEKNPNGNN(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2880", Offset = "0x5DE1080", VA = "0x185DE2880")]
	public MGDEKNPNGNN(string NJAIIGFCHNG, Exception COLLJDCIAGM)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x7CB550", Offset = "0x7C9D50", VA = "0x1807CB550")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int GBIDHHJLPLE, int AOFKHJEAGOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x42E6480", Offset = "0x42E4C80", VA = "0x1842E6480")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x42E6520", Offset = "0x42E4D20", VA = "0x1842E6520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x42E63F0", Offset = "0x42E4BF0", VA = "0x1842E63F0")]
		public Array2D(uint BHAMBKDMALL, uint PEJBJHOOMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x42E6370", Offset = "0x42E4B70", VA = "0x1842E6370")]
		public void OJEEPLKEKIC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DDD010", Offset = "0x5DDB810", VA = "0x185DDD010")]
		public Array2DVector3(uint BHAMBKDMALL, uint PEJBJHOOMHE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class LGKKCNPIIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int BPBAJLJEJPB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int FJANNPFDFEB = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class PCNAFPCNLFL<THandle, TValue> : IDisposable where THandle : struct, EKJNBJHBEDB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> ICIEPJPHBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> JIECDBDFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> MLIBGLACIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> NJNKEBCCAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int KKKCNMNGFLH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x36705E0", Offset = "0x366EDE0", VA = "0x1836705E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DAB0", Offset = "0x3B1C2B0", VA = "0x183B1DAB0")]
	public PCNAFPCNLFL(Action<TValue> NJNKEBCCAIO, [Optional] Func<TValue> MLIBGLACIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D1C0", Offset = "0x3B1B9C0", VA = "0x183B1D1C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3EA5700", Offset = "0x3EA3F00", VA = "0x183EA5700")]
	public THandle MFNJFAEBAIM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D150", Offset = "0x3B1B950", VA = "0x183B1D150")]
	public THandle CEMPCIEDPMO(TValue CCIMHDCKHOF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B1CFD0", Offset = "0x3B1B7D0", VA = "0x183B1CFD0")]
	public bool ADDEDGCCJIP(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D080", Offset = "0x3B1B880", VA = "0x183B1D080")]
	public bool BCKCNDMGJOA(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D8A0", Offset = "0x3B1C0A0", VA = "0x183B1D8A0")]
	public bool MFJHFJBDKOG(THandle BLIPNDKFLPL, out TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D770", Offset = "0x3B1BF70", VA = "0x183B1D770")]
	public TValue KEEHOGKCDPF(THandle BLIPNDKFLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D280", Offset = "0x3B1BA80", VA = "0x183B1D280")]
	public bool FKKMCEBMOMF(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B1DA80", Offset = "0x3B1C280", VA = "0x183B1DA80")]
	private THandle OGIPDGPKNKP(int MMABPPDCBIB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D460", Offset = "0x3B1BC60", VA = "0x183B1D460")]
	private TValue HGMFBEDJIMN(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D240", Offset = "0x3B1BA40", VA = "0x183B1D240")]
	private void FKEEFHFPMPH(int MMABPPDCBIB, in THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D490", Offset = "0x3B1BC90", VA = "0x183B1D490")]
	private void HMGIAJOOMGI(int MMABPPDCBIB, in TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D650", Offset = "0x3B1BE50", VA = "0x183B1D650")]
	private THandle JDBIILFODCP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D4D0", Offset = "0x3B1BCD0", VA = "0x183B1D4D0")]
	private void IDCJMPGNFPD(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D330", Offset = "0x3B1BB30", VA = "0x183B1D330")]
	private int GBGMCMPJLIE(int LDFDMKAILBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D760", Offset = "0x3B1BF60", VA = "0x183B1D760")]
	private bool JLOIFEFNIEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x74A770", Offset = "0x748F70", VA = "0x18074A770")]
	private void PFNOCCMODHO(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D820", Offset = "0x3B1C020", VA = "0x183B1D820")]
	private bool MDIPPBOFJDK(out THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D580", Offset = "0x3B1BD80", VA = "0x183B1D580")]
	private bool IFNCCOFHMIB(out THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D7C0", Offset = "0x3B1BFC0", VA = "0x183B1D7C0")]
	private void LKIAKKCEFCL(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3B1D340", Offset = "0x3B1BB40", VA = "0x183B1D340")]
	private void GDLIDGKJKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface EKJNBJHBEDB
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface KIMFBICNHMN<T> : EKJNBJHBEDB, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MBIHNIBGDCN
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2650", Offset = "0x1AC0E50", VA = "0x181AC2650")]
	public static bool HFGEKIMGMLB<T>(this T BLIPNDKFLPL, T IIKMMJKCGDO) where T : struct, EKJNBJHBEDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x36C8C90", Offset = "0x36C7490", VA = "0x1836C8C90")]
	public static bool DPHKGIJFNKP<T>(this T BLIPNDKFLPL) where T : struct, EKJNBJHBEDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2700", Offset = "0x5DE0F00", VA = "0x185DE2700")]
	public static string FOJDKKAOGCC(this EKJNBJHBEDB BLIPNDKFLPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class BGPJHHFDKPH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum DDEIGLEGOEH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FPALDDOOOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool ELOBMNMCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DDEIGLEGOEH JCLIGOJKKCI;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GFAFPPNCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DDDAF0", Offset = "0x5DDC2F0", VA = "0x185DDDAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NHCJKDFHINB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DDDB20", Offset = "0x5DDC320", VA = "0x185DDDB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE8C0", Offset = "0x5DDD0C0", VA = "0x185DDE8C0")]
	public BGPJHHFDKPH(bool ELOBMNMCOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB70", Offset = "0x5DDC370", VA = "0x185DDDB70")]
	public void JBJIHFNDAAI(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE5D0", Offset = "0x5DDCDD0", VA = "0x185DDE5D0")]
	public void MCEPPKCLLOO(int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE820", Offset = "0x5DDD020", VA = "0x185DDE820")]
	public void OLIENJBOHBF(uint CDBPCPCHNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB00", Offset = "0x5DDC300", VA = "0x185DDDB00")]
	public void BMPLJMHJLGI(bool ENMIGOJBPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDAB0", Offset = "0x5DDC2B0", VA = "0x185DDDAB0")]
	public void BFKAECJHAIJ(long LENMDADPBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB30", Offset = "0x5DDC330", VA = "0x185DDDB30")]
	public void FGHENJOJMLC(ulong JJEBJOIFMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDA40", Offset = "0x5DDC240", VA = "0x185DDDA40")]
	public void ALEFCLEKFMP(string LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE830", Offset = "0x5DDD030", VA = "0x185DDE830")]
	public void PHKLEIFHIDD(Enum GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE6E0", Offset = "0x5DDCEE0", VA = "0x185DDE6E0")]
	public void NANJPNHKKFL(IList PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x354BE90", Offset = "0x354A690", VA = "0x18354BE90")]
	public void FGKBKAOHFEN<T, U>(Dictionary<T, U> FOHJGKGDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE260", Offset = "0x5DDCA60", VA = "0x185DDE260")]
	private void LNDOMHJHCME(IDictionary FOHJGKGDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE670", Offset = "0x5DDCE70", VA = "0x185DDE670")]
	public int MKPMAPDLMGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE1F0", Offset = "0x5DDC9F0", VA = "0x185DDE1F0")]
	public short LJJHHGIPCHC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE810", Offset = "0x5DDD010", VA = "0x185DDE810")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD9D0", Offset = "0x5DDC1D0", VA = "0x185DDD9D0")]
	private void AGAINJMHIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class MMINGHEIDKP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class FALGNDCEIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode IPNNIJODOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode OJKLIAPCMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public LABGBGAMKBM BJIDGGBJEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<LABGBGAMKBM> MHDHNDIGAAC;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public FALGNDCEIDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct LABGBGAMKBM : IComparable<LABGBGAMKBM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int PCMCGMOPFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant DGCMJEEHDPF;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x958000", Offset = "0x956800", VA = "0x180958000")]
		public LABGBGAMKBM(int PCMCGMOPFKB, TClaimant DGCMJEEHDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x2EF37F0", Offset = "0x2EF1FF0", VA = "0x182EF37F0")]
		public bool ABNIDMILELH(in LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2EF3860", Offset = "0x2EF2060", VA = "0x182EF3860")]
		public bool ODBBINLMAKP(in LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2EF3850", Offset = "0x2EF2050", VA = "0x182EF3850", Slot = "4")]
		public int CompareTo(LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2EF3870", Offset = "0x2EF2070", VA = "0x182EF3870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum KFGECDIBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ICPBIDAHEDD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::MMINGHEIDKP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2B29F10", Offset = "0x2B28710", VA = "0x182B29F10")]
		[DebuggerHidden]
		public ICPBIDAHEDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2B29D10", Offset = "0x2B28510", VA = "0x182B29D10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2B29ED0", Offset = "0x2B286D0", VA = "0x182B29ED0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2B29DF0", Offset = "0x2B285F0", VA = "0x182B29DF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2031830", Offset = "0x2030030", VA = "0x182031830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::DJCLGKPCLBB<FALGNDCEIDD> JFHHNBGNOPF;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::DJCLGKPCLBB<List<LABGBGAMKBM>> NACIDCFAEOC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int MLCOOELGOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> AIAPFKCDEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, FALGNDCEIDD> ABJCMJMCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private KFGECDIBHDI PDFIDNNGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GECBLHBNBIF(TNode CBLFDLDNPMN);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GAFMNHLEAFA(TNode CBLFDLDNPMN, TClaimant KFNMBHJBCME, TClaimant GMMMAFBCANF);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B750", Offset = "0x3F79F50", VA = "0x183F7B750")]
	public MMINGHEIDKP(KFGECDIBHDI PDFIDNNGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3F7AA20", Offset = "0x3F79220", VA = "0x183F7AA20")]
	public void FJNPBAEFMLA(TNode CBLFDLDNPMN, TNode ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B330", Offset = "0x3F79B30", VA = "0x183F7B330")]
	public void JGELGMBBBEG(TClaimant DGCMJEEHDPF, TNode DLCADIDKAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A450", Offset = "0x3F78C50", VA = "0x183F7A450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A190", Offset = "0x3F78990", VA = "0x183F7A190")]
	private void AOGEABNOHAK(TClaimant DGCMJEEHDPF, TNode JLABDGOECNH, TNode DLCADIDKAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B590", Offset = "0x3F79D90", VA = "0x183F7B590")]
	private int OHEOAFMJLBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B080", Offset = "0x3F79880", VA = "0x183F7B080")]
	private void ILEHLAABGLC(TClaimant DGCMJEEHDPF, TNode NBDFMIMNLBD, TNode POADJDFNECJ, int KPPHIIJAGAH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B500", Offset = "0x3F79D00", VA = "0x183F7B500")]
	private void LIEBEINHLKL(LABGBGAMKBM HALCEDGDBGP, FALGNDCEIDD OBJIBHDLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3F7AAA0", Offset = "0x3F792A0", VA = "0x183F7AAA0")]
	private void GFFAKDCGAEB(TClaimant DGCMJEEHDPF, TNode NBDFMIMNLBD, TNode POADJDFNECJ, int KPPHIIJAGAH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A340", Offset = "0x3F78B40", VA = "0x183F7A340")]
	private void DNINIDIIPGD(LABGBGAMKBM HALCEDGDBGP, TNode CBLFDLDNPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3F7ADC0", Offset = "0x3F795C0", VA = "0x183F7ADC0")]
	private void HLNBEDEJHCG(LABGBGAMKBM HALCEDGDBGP, FALGNDCEIDD OBJIBHDLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A230", Offset = "0x3F78A30", VA = "0x183F7A230")]
	private void BANDGLPFJAN(FALGNDCEIDD OBJIBHDLDKG, bool GHCANGIEKHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A6B0", Offset = "0x3F78EB0", VA = "0x183F7A6B0")]
	private void EBAKAAKBBPF(FALGNDCEIDD OBJIBHDLDKG, TNode ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B430", Offset = "0x3F79C30", VA = "0x183F7B430")]
	[IteratorStateMachine(typeof(global::MMINGHEIDKP<, >.ICPBIDAHEDD))]
	private IEnumerable<TNode> JMOACFAAECH(TNode NBDFMIMNLBD, TNode POADJDFNECJ, bool FDGAFGHBAHK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3F7AD00", Offset = "0x3F79500", VA = "0x183F7AD00")]
	private FALGNDCEIDD GNHPFCCNGHH(TNode CBLFDLDNPMN, TNode OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3F7A000", Offset = "0x3F78800", VA = "0x183F7A000")]
	private FALGNDCEIDD AANDAFLNEKN(TNode CBLFDLDNPMN, TNode OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3F7AEC0", Offset = "0x3F796C0", VA = "0x183F7AEC0")]
	private void IHLINLJMPGN(FALGNDCEIDD OBJIBHDLDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class LMKLFAIBJID<T> : IEnumerable<global::LMKLFAIBJID<T>.IMHFCBKOGIC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct IMHFCBKOGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T CCIMHDCKHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int MMABPPDCBIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class FBPFEEDMIFN : IEnumerator<IMHFCBKOGIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::LMKLFAIBJID<T> OOOLCIHHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int MMABPPDCBIB;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2025950", Offset = "0x2024150", VA = "0x182025950", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IMHFCBKOGIC IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x34B6390", Offset = "0x34B4B90", VA = "0x1834B6390", Slot = "4")]
			get
			{
				return default(IMHFCBKOGIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x85BBD0", Offset = "0x85A3D0", VA = "0x18085BBD0")]
		public FBPFEEDMIFN(global::LMKLFAIBJID<T> OOOLCIHHFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x34B6310", Offset = "0x34B4B10", VA = "0x1834B6310", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x85BBC0", Offset = "0x85A3C0", VA = "0x18085BBC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x105A700", Offset = "0x1058F00", VA = "0x18105A700", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct FAJKPNAALKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool LDLJNLMJDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T CCIMHDCKHOF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int OGGJBEHPLKI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> AFFMDBFIEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private FAJKPNAALKB[] LLIHGMLIDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int MKAIEPFIJNN;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int FOCGBJNEJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6F9700", Offset = "0x6F7F00", VA = "0x1806F9700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6F9B90", Offset = "0x6F8390", VA = "0x1806F9B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F30", Offset = "0x2F97730", VA = "0x182F98F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x375B190", Offset = "0x3759990", VA = "0x18375B190")]
	public LMKLFAIBJID(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x375A9B0", Offset = "0x37591B0", VA = "0x18375A9B0")]
	public LMKLFAIBJID(IMHFCBKOGIC[] EDKOFDEAJAI, bool PAIPMGNEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x375A450", Offset = "0x3758C50", VA = "0x18375A450")]
	public int NCIKCKDAMPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x375A6B0", Offset = "0x3758EB0", VA = "0x18375A6B0")]
	private int NCLEMPKJJFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x3759940", Offset = "0x3758140", VA = "0x183759940", Slot = "6")]
	protected virtual uint EDMBNPDCFGI(uint FPALDDOOOME, T CCIMHDCKHOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x375A3E0", Offset = "0x3758BE0", VA = "0x18375A3E0")]
	public bool MJGCLNLKPKE(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3759ED0", Offset = "0x37586D0", VA = "0x183759ED0")]
	public bool IIHPGIKGAMM(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3759780", Offset = "0x3757F80", VA = "0x183759780")]
	public bool CBBIGPLMGHA(Func<T, bool> KBGJCMKGEHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3759670", Offset = "0x3757E70", VA = "0x183759670")]
	public int BLONAIJHGEF(T CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3759B60", Offset = "0x3758360", VA = "0x183759B60")]
	public T HGMFBEDJIMN(int MMABPPDCBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x375A8B0", Offset = "0x37590B0", VA = "0x18375A8B0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3759F70", Offset = "0x3758770", VA = "0x183759F70")]
	public bool KFCNCOMHECF(T CCIMHDCKHOF, bool JGBAHGMLCOB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3759FE0", Offset = "0x37587E0", VA = "0x183759FE0")]
	public bool KFCNCOMHECF(T CCIMHDCKHOF, int MMABPPDCBIB, bool JGBAHGMLCOB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x3759590", Offset = "0x3757D90", VA = "0x183759590")]
	public bool ADDEDGCCJIP(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x37598F0", Offset = "0x37580F0", VA = "0x1837598F0")]
	public bool CLBKMDGGMLI(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3759990", Offset = "0x3758190", VA = "0x183759990")]
	private void GMMBBPAKCJJ(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x3759D90", Offset = "0x3758590", VA = "0x183759D90")]
	public IMHFCBKOGIC[] HHOLENPNECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x37598A0", Offset = "0x37580A0", VA = "0x1837598A0")]
	private int CKPAFEEEDBG(int OFHLFABGMBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x375A930", Offset = "0x3759130", VA = "0x18375A930", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x375A930", Offset = "0x3759130", VA = "0x18375A930", Slot = "4")]
	private IEnumerator<IMHFCBKOGIC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BBNCPEJIGGM<Handle> where Handle : EKJNBJHBEDB, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct PCOMJKNOCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly global::BBNCPEJIGGM<Handle> FGMDHCGBMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int MMABPPDCBIB;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int HEINJKEDNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x3B1E320", Offset = "0x3B1CB20", VA = "0x183B1E320")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle FDJFILPPINB
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3B1E8E0", Offset = "0x3B1D0E0", VA = "0x183B1E8E0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3B1EEA0", Offset = "0x3B1D6A0", VA = "0x183B1EEA0")]
		public PCOMJKNOCPB(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DE40", Offset = "0x3B1C640", VA = "0x183B1DE40")]
		public EOFPMIPKDAN AKMEFLONJDG(in EOFPMIPKDAN NJKKDANCIMG)
		{
			return default(EOFPMIPKDAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DDA0", Offset = "0x3B1C5A0", VA = "0x183B1DDA0")]
		public AAHKHCEDBCC AKMEFLONJDG(in AAHKHCEDBCC NJKKDANCIMG)
		{
			return default(AAHKHCEDBCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E5E0", Offset = "0x3B1CDE0", VA = "0x183B1E5E0")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DEE0", Offset = "0x3B1C6E0", VA = "0x183B1DEE0")]
		private int DIABLHNGMFA(string NJAIIGFCHNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3B1E7A0", Offset = "0x3B1CFA0", VA = "0x183B1E7A0")]
		private Handle KIECJCJAPDJ(string NJAIIGFCHNG)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct EOFPMIPKDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private PCOMJKNOCPB KABGDGCHNPF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2FD4150", Offset = "0x2FD2950", VA = "0x182FD4150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2FD4210", Offset = "0x2FD2A10", VA = "0x182FD4210")]
		public EOFPMIPKDAN(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2FD4090", Offset = "0x2FD2890", VA = "0x182FD4090")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2FD3F90", Offset = "0x2FD2790", VA = "0x182FD3F90")]
		public EOFPMIPKDAN CDEDLLPMOKO()
		{
			return default(EOFPMIPKDAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct AAHKHCEDBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PCOMJKNOCPB KABGDGCHNPF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x35D2170", Offset = "0x35D0970", VA = "0x1835D2170")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2FD4210", Offset = "0x2FD2A10", VA = "0x182FD4210")]
		public AAHKHCEDBCC(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2FD4090", Offset = "0x2FD2890", VA = "0x182FD4090")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x35D2070", Offset = "0x35D0870", VA = "0x1835D2070")]
		public AAHKHCEDBCC CDEDLLPMOKO()
		{
			return default(AAHKHCEDBCC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> GKJHJGAAPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> PLALPILABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int KKIGHFHJOEM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x48593A0", Offset = "0x4857BA0", VA = "0x1848593A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4857AE0", Offset = "0x48562E0", VA = "0x184857AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int NJCEGBJDCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C80", Offset = "0x6F3480", VA = "0x1806F4C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GCGAJKJJHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C80", Offset = "0x6F3480", VA = "0x1806F4C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public EOFPMIPKDAN GKADFMHLEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x485A260", Offset = "0x4858A60", VA = "0x18485A260")]
		get
		{
			return default(EOFPMIPKDAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AAHKHCEDBCC FMFGMOEBNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x485A300", Offset = "0x4858B00", VA = "0x18485A300")]
		get
		{
			return default(AAHKHCEDBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x485BE50", Offset = "0x485A650", VA = "0x18485BE50")]
	public BBNCPEJIGGM(int EJADEEOGECD, Allocator EGJIMBMGFGA = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x485BB50", Offset = "0x485A350", VA = "0x18485BB50")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x2447030", Offset = "0x2445830", VA = "0x182447030")]
	public static int GBGMCMPJLIE(int DCNCBDGEKMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x485B300", Offset = "0x4859B00", VA = "0x18485B300")]
	public static bool MPAGBCOCLII(int DCNCBDGEKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x485BDA0", Offset = "0x485A5A0", VA = "0x18485BDA0")]
	public static bool PMBAPJKEPME(int DCNCBDGEKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x485B640", Offset = "0x4859E40", VA = "0x18485B640")]
	public bool NFNPJJGCGDN(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4858EE0", Offset = "0x48576E0", VA = "0x184858EE0")]
	public bool DDJFDLDPNHA(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x485AAC0", Offset = "0x48592C0", VA = "0x18485AAC0")]
	public bool LACABJDKKBH(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4858BD0", Offset = "0x48573D0", VA = "0x184858BD0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void DADAGEOKFLI(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x485B0F0", Offset = "0x48598F0", VA = "0x18485B0F0")]
	public Handle MFDIBGBKELB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x48599C0", Offset = "0x48581C0", VA = "0x1848599C0")]
	public void EJICNPDKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x485A8A0", Offset = "0x48590A0", VA = "0x18485A8A0")]
	public void KOJGCEODHCF(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x485AFA0", Offset = "0x48597A0", VA = "0x18485AFA0")]
	public bool LEGHBPLGEIF(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x485BC80", Offset = "0x485A480", VA = "0x18485BC80")]
	private bool PFFDMIOFFMI(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4857BE0", Offset = "0x48563E0", VA = "0x184857BE0")]
	private void AFHKAJMBHEI(out int MMABPPDCBIB, out int LDFDMKAILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x485A600", Offset = "0x4858E00", VA = "0x18485A600")]
	private void JONABJLBEIM(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4858240", Offset = "0x4856A40", VA = "0x184858240")]
	private void COOMLIIFOLJ(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x485A1B0", Offset = "0x48589B0", VA = "0x18485A1B0")]
	private bool ELLBNFMLDAN(out int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x485B750", Offset = "0x4859F50", VA = "0x18485B750")]
	private static Handle NLJNEECFAFF(int MMABPPDCBIB, int LDFDMKAILBI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct KNEIBAGCIPL<Handle, T> where Handle : EKJNBJHBEDB, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private global::BBNCPEJIGGM<Handle> JGOGKCIEEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private T[] LOHJIBBFOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Action<T> BOGNLPPFCAH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD26D0", Offset = "0x3DD0ED0", VA = "0x183DD26D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1660", Offset = "0x3DCFE60", VA = "0x183DD1660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2ED0", Offset = "0x3DD16D0", VA = "0x183DD2ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3B60", Offset = "0x3DD2360", VA = "0x183DD3B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD49E0", Offset = "0x3DD31E0", VA = "0x183DD49E0")]
	public KNEIBAGCIPL(int EJADEEOGECD, [Optional] Action<T> BOGNLPPFCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4830", Offset = "0x3DD3030", VA = "0x183DD4830")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x3DD39B0", Offset = "0x3DD21B0", VA = "0x183DD39B0")]
	public bool LACABJDKKBH(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void DADAGEOKFLI(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3800", Offset = "0x3DD2000", VA = "0x183DD3800")]
	public T KEEHOGKCDPF(Handle BLIPNDKFLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3C70", Offset = "0x3DD2470", VA = "0x183DD3C70")]
	public bool MFJHFJBDKOG(Handle BLIPNDKFLPL, out T ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2400", Offset = "0x3DD0C00", VA = "0x183DD2400")]
	public void DIMECELKFHA(Handle BLIPNDKFLPL, T GGEEEEGHELO, out T BHEJIMJPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x3DD24A0", Offset = "0x3DD0CA0", VA = "0x183DD24A0")]
	public void DIMECELKFHA(Handle BLIPNDKFLPL, T GGEEEEGHELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4270", Offset = "0x3DD2A70", VA = "0x183DD4270")]
	public bool MOPEIKOLPCO(Handle BLIPNDKFLPL, T GGEEEEGHELO, out T BHEJIMJPPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x3DD4540", Offset = "0x3DD2D40", VA = "0x183DD4540")]
	public bool MOPEIKOLPCO(Handle BLIPNDKFLPL, T GGEEEEGHELO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1F20", Offset = "0x3DD0720", VA = "0x183DD1F20")]
	public Handle CEMPCIEDPMO(T ODMJCJPGHNI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x3DD35C0", Offset = "0x3DD1DC0", VA = "0x183DD35C0")]
	public void FBCBPBLMBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD19D0", Offset = "0x3DD01D0", VA = "0x183DD19D0")]
	public void ADDEDGCCJIP(Handle BLIPNDKFLPL, out T BHEJIMJPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD1760", Offset = "0x3DCFF60", VA = "0x183DD1760")]
	public void ADDEDGCCJIP(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD28B0", Offset = "0x3DD10B0", VA = "0x183DD28B0")]
	public bool EJPELPJHBEE(Handle BLIPNDKFLPL, out T BHEJIMJPPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2C30", Offset = "0x3DD1430", VA = "0x183DD2C30")]
	public bool EJPELPJHBEE(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2250", Offset = "0x3DD0A50", VA = "0x183DD2250")]
	private T CLBKMDGGMLI(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD3A00", Offset = "0x3DD2200", VA = "0x183DD3A00")]
	private void LOKAJEFELOL(int EANCNGLCPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class DJCLGKPCLBB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<T> FGMDHCGBMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<T> OBOLBDHFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly int GAAAECLEFON;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int GEDDAEHIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x33712E0", Offset = "0x336FAE0", VA = "0x1833712E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int LOOJNKHNEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2B2CCA0", Offset = "0x2B2B4A0", VA = "0x182B2CCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DBF0", Offset = "0x3C1C3F0", VA = "0x183C1DBF0")]
	public static global::DJCLGKPCLBB<T> ADHNLKMNKDE(int JAFEKEGLGFD = 0, int GAAAECLEFON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DDB0", Offset = "0x3C1C5B0", VA = "0x183C1DDB0")]
	public static global::DJCLGKPCLBB<T> ENFCGBJJKLB(int JAFEKEGLGFD = 0, int GAAAECLEFON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E3E0", Offset = "0x3C1CBE0", VA = "0x183C1E3E0")]
	public DJCLGKPCLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E420", Offset = "0x3C1CC20", VA = "0x183C1E420")]
	public DJCLGKPCLBB(int JAFEKEGLGFD, int GAAAECLEFON = int.MaxValue, bool GLGIGALJOPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E240", Offset = "0x3C1CA40", VA = "0x183C1E240")]
	public T LLHBACCELBH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DF00", Offset = "0x3C1C700", VA = "0x183C1DF00")]
	public void GCLFHHNKHLO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DFD0", Offset = "0x3C1C7D0", VA = "0x183C1DFD0")]
	private void IJNPDGLJDMC(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DFB0", Offset = "0x3C1C7B0", VA = "0x183C1DFB0")]
	private void HLMKCNADGLF(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DE80", Offset = "0x3C1C680", VA = "0x183C1DE80")]
	[Conditional("DEBUG_BUILD")]
	private void GABGHKLABKP(T JAJBGLDNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E350", Offset = "0x3C1CB50", VA = "0x183C1E350")]
	[Conditional("DEBUG_BUILD")]
	private void NJGHJJENLJI(T JAJBGLDNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DCC0", Offset = "0x3C1C4C0", VA = "0x183C1DCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E0A0", Offset = "0x3C1C8A0", VA = "0x183C1E0A0")]
	private void KBLCFHHPENE(IEnumerable<T> JIECDBDFHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KGOFJDAEOBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Dictionary<int, T> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private T IFMDOFCBOGO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T PBMINIPAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x37C9A70", Offset = "0x37C8270", VA = "0x1837C9A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x37C99E0", Offset = "0x37C81E0", VA = "0x1837C99E0")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x37CA040", Offset = "0x37C8840", VA = "0x1837CA040")]
	public bool NOCLIFBDPIH(int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x37C9E50", Offset = "0x37C8650", VA = "0x1837C9E50")]
	public T MEFKHIDNNHL(int JBOBKINEJNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x37CA0A0", Offset = "0x37C88A0", VA = "0x1837CA0A0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x37C9BC0", Offset = "0x37C83C0", VA = "0x1837C9BC0")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x37C9A40", Offset = "0x37C8240", VA = "0x1837C9A40")]
	public bool EPBHELLGDLM(int PCMCGMOPFKB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x37CA100", Offset = "0x37C8900", VA = "0x1837CA100")]
	public KGOFJDAEOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class PCOPKCLJFKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct FFHLHMAFGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int NCABMENALPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<FFHLHMAFGFO> DOACBDBBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T ILFLKADEOGJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F30", Offset = "0x2F97730", VA = "0x182F98F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EFE0", Offset = "0x3B1D7E0", VA = "0x183B1EFE0")]
	public bool CBBIGPLMGHA(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F1F0", Offset = "0x3B1D9F0", VA = "0x183B1F1F0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF, int PCMCGMOPFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3B1EEC0", Offset = "0x3B1D6C0", VA = "0x183B1EEC0")]
	public bool ADDEDGCCJIP(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F530", Offset = "0x3B1DD30", VA = "0x183B1F530")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F300", Offset = "0x3B1DB00", VA = "0x183B1F300")]
	public T FKLNIHMLJNI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F290", Offset = "0x3B1DA90", VA = "0x183B1F290")]
	public T FKEDDPMFMCK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F370", Offset = "0x3B1DB70", VA = "0x183B1F370")]
	private void GCOABBKGKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F590", Offset = "0x3B1DD90", VA = "0x183B1F590")]
	public PCOPKCLJFKF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[HOEJGCAGKOC(APAJCDGALOH.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3000", Offset = "0x5DE1800", VA = "0x185DE3000")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3390", Offset = "0x5DE1B90", VA = "0x185DE3390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3210", Offset = "0x5DE1A10", VA = "0x185DE3210")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5DE34F0", Offset = "0x5DE1CF0", VA = "0x185DE34F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2F20", Offset = "0x5DE1720", VA = "0x185DE2F20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5DE32B0", Offset = "0x5DE1AB0", VA = "0x185DE32B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3130", Offset = "0x5DE1930", VA = "0x185DE3130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2ED0", Offset = "0x5DE16D0", VA = "0x185DE2ED0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface HKJLDGJADAC
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : HKJLDGJADAC where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x35C3480", Offset = "0x35C1C80", VA = "0x1835C3480", Slot = "4")]
		public virtual T IMIMEKHBPHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class ABAFJCPHOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly Dictionary<byte, JDDONDMMDDL> NGAADEFOFIP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JDDONDMMDDL BKNINIHHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 HPHMFKEIDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF20", Offset = "0xE19720", VA = "0x180E1AF20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x66FD10", Offset = "0x66E510", VA = "0x18066FD10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 LOFPLJJNALM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x12D9870", Offset = "0x12D8070", VA = "0x1812D9870")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x72D2A0", Offset = "0x72BAA0", VA = "0x18072D2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 HHMHNPENPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB890", Offset = "0x5DDA090", VA = "0x185DDB890")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x726A60", Offset = "0x725260", VA = "0x180726A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int AIOHNPLLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x74A740", Offset = "0x748F40", VA = "0x18074A740")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x74A770", Offset = "0x748F70", VA = "0x18074A770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBE30", Offset = "0x5DDA630", VA = "0x185DDBE30")]
	public ABAFJCPHOEK(Bounds OLOGIODGCBG, Vector2[] JCHIKMBCFHP, int CJOGLKIICBD, byte OFHLFABGMBH, float JIJLIOGDHFM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB730", Offset = "0x5DD9F30", VA = "0x185DDB730")]
	public JDDONDMMDDL APKHPCDFHDB(byte MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB790", Offset = "0x5DD9F90", VA = "0x185DDB790")]
	public void CFLBPONKELB(Vector3 LPADDFNBONE, float AIIPOKFHHNI, float EBJKIIEKMJA, ref List<byte> ILDDDBFCGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB8B0", Offset = "0x5DDA0B0", VA = "0x185DDB8B0")]
	public void GJOGCEMKHPJ(JDDONDMMDDL.FIEHBPMLEAK IJLFGCNDLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB8D0", Offset = "0x5DDA0D0", VA = "0x185DDB8D0")]
	private JDDONDMMDDL INLLIJBPACC(byte MMABPPDCBIB, JDDONDMMDDL.JEDPAAHLGHJ ADPKBFJAKAI, JDDONDMMDDL OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBA30", Offset = "0x5DDA230", VA = "0x185DDBA30")]
	private void PHDMCIIADPK(JDDONDMMDDL OJKLIAPCMPJ, Vector2[] JCHIKMBCFHP, int GGMFCDOKLFN, int LOGOADKLGNK, int LKNEMOFHLGL, int MJPGJFAKDDD, float JIJLIOGDHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class JDDONDMMDDL
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum JEDPAAHLGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum FIEHBPMLEAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public byte LMIDIPHLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Vector3 NJLDLKDEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 ADODPFDEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 DHMFKNAEKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 LIANPIEJOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public JEDPAAHLGHJ JOKECEGIIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public JDDONDMMDDL AOJBGOEDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public List<JDDONDMMDDL> INNFOLKFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool MCKNFINHCPC;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1780", Offset = "0x5DDFF80", VA = "0x185DE1780")]
	public JDDONDMMDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE17A0", Offset = "0x5DDFFA0", VA = "0x185DE17A0")]
	public JDDONDMMDDL(byte DGFBLJMJMFI, JEDPAAHLGHJ ADPKBFJAKAI, JDDONDMMDDL OJKLIAPCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1670", Offset = "0x5DDFE70", VA = "0x185DE1670")]
	public void FDCLLHDIPLE(JDDONDMMDDL FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	public void GJOGCEMKHPJ(int DEKJDMHGKDJ, FIEHBPMLEAK IJLFGCNDLIC, int OGGAFBFPFBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE13C0", Offset = "0x5DDFBC0", VA = "0x185DE13C0")]
	public void CFLBPONKELB(List<byte> ILDDDBFCGNH, Vector3 LPADDFNBONE, float AIIPOKFHHNI, float EBJKIIEKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1730", Offset = "0x5DDFF30", VA = "0x185DE1730")]
	public bool JFPIHDKPMHN(Vector3 ADMEPHMBKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1380", Offset = "0x5DDFB80", VA = "0x185DE1380")]
	public bool CDNAJELOLPK(Vector3 ADMEPHMBKKP, float IOOBDCMPDDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class ADKBIIBCKNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Dictionary<T, object> PPBBILOHLIL;

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B21BD0", Offset = "0x2B203D0", VA = "0x182B21BD0")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x35E1000", Offset = "0x35DF800", VA = "0x1835E1000")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x35E1040", Offset = "0x35DF840", VA = "0x1835E1040")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x35E0F30", Offset = "0x35DF730", VA = "0x1835E0F30")]
	public bool KLECBONDMPI(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x35E0EF0", Offset = "0x35DF6F0", VA = "0x1835E0EF0")]
	public bool BMHPCALHMII(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x35E0F70", Offset = "0x35DF770", VA = "0x1835E0F70")]
	public bool KLECBONDMPI(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9480", Offset = "0x2FC7C80", VA = "0x182FC9480")]
	public void EMJEGPIEBFJ(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x35E0E50", Offset = "0x35DF650", VA = "0x1835E0E50")]
	public void AIMPPMFGLLJ(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x35E10A0", Offset = "0x35DF8A0", VA = "0x1835E10A0")]
	public ADKBIIBCKNC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct NDLPAGNOBAB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private readonly List<Component> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly bool IENBHFNOOHF;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x11B80F0", Offset = "0x11B68F0", VA = "0x1811B80F0")]
			public NDLPAGNOBAB(List<Component> PIJDNOPJENO, bool IENBHFNOOHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x32DA240", Offset = "0x32D8A40", VA = "0x1832DA240")]
			public JNHPCBIAMBL<T> CDEDLLPMOKO()
			{
				return default(JNHPCBIAMBL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x32DA2B0", Offset = "0x32D8AB0", VA = "0x1832DA2B0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x32DA2B0", Offset = "0x32D8AB0", VA = "0x1832DA2B0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct JNHPCBIAMBL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool IENBHFNOOHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private int MMABPPDCBIB;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T IKECDOHOPGM
			{
				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x3E120A0", Offset = "0x3E108A0", VA = "0x183E120A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x3E12030", Offset = "0x3E10830", VA = "0x183E12030", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x3E12070", Offset = "0x3E10870", VA = "0x183E12070")]
			public JNHPCBIAMBL(List<Component> PIJDNOPJENO, bool IENBHFNOOHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x3E11F70", Offset = "0x3E10770", VA = "0x183E11F70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x3E11F80", Offset = "0x3E10780", VA = "0x183E11F80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x3C088B0", Offset = "0x3C070B0", VA = "0x183C088B0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5DE51A0", Offset = "0x5DE39A0", VA = "0x185DE51A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5160", Offset = "0x5DE3960", VA = "0x185DE5160")]
		public ToolHierarchyCache(GameObject NJPGIIMNPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4A70", Offset = "0x5DE3270", VA = "0x185DE4A70")]
		private void CDFKCHBFAME(GameObject NJPGIIMNPBL, bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE49E0", Offset = "0x5DE31E0", VA = "0x185DE49E0")]
		public static void CDFKCHBFAME(GameObject NJPGIIMNPBL, ref ToolHierarchyCache EHFJHOENLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5050", Offset = "0x5DE3850", VA = "0x185DE5050")]
		public void MJOGFHNBAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4C50", Offset = "0x5DE3450", VA = "0x185DE4C50")]
		public void GIFLFLFDMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BD30", Offset = "0x3C4A530", VA = "0x183C4BD30")]
		public void GANCNDNOMIJ<T>(Action<T> NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4910", Offset = "0x5DE3110", VA = "0x185DE4910")]
		public Component AEAHDOHCMMD(Type BCFKLEGAMEO, bool IENBHFNOOHF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BCB0", Offset = "0x3C4A4B0", VA = "0x183C4BCB0")]
		public T AEAHDOHCMMD<T>(bool IENBHFNOOHF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5060", Offset = "0x5DE3860", VA = "0x185DE5060")]
		public NDLPAGNOBAB<Component> NJONCPEKMCG(Type BCFKLEGAMEO, bool IENBHFNOOHF = false)
		{
			return default(NDLPAGNOBAB<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BFC0", Offset = "0x3C4A7C0", VA = "0x183C4BFC0")]
		public NDLPAGNOBAB<T> NJONCPEKMCG<T>(bool IENBHFNOOHF = false) where T : class
		{
			return default(NDLPAGNOBAB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4D20", Offset = "0x5DE3520", VA = "0x185DE4D20")]
		public List<Component> KABCPFDGBHC(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4BD0", Offset = "0x5DE33D0", VA = "0x185DE4BD0", Slot = "4")]
		public bool Equals(ToolHierarchyCache ODLLFOGPPIE, ToolHierarchyCache GJCOJHOFJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4CA0", Offset = "0x5DE34A0", VA = "0x185DE4CA0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ODMJCJPGHNI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class DFEGJOLPJNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private int JAFEKEGLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int IJOCGHMHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private List<T> CFFIGFCFHML;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x33712E0", Offset = "0x336FAE0", VA = "0x1833712E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T ABOGINNEAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C17F70", Offset = "0x3C16770", VA = "0x183C17F70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T MJABMDDEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C180C0", Offset = "0x3C168C0", VA = "0x183C180C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T LGDBLOBNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C17D10", Offset = "0x3C16510", VA = "0x183C17D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3C18200", Offset = "0x3C16A00", VA = "0x183C18200")]
	public DFEGJOLPJNA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x3C17E40", Offset = "0x3C16640", VA = "0x183C17E40")]
	public void CEMPCIEDPMO(T ADHEHALNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x3C181C0", Offset = "0x3C169C0", VA = "0x183C181C0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x3C18120", Offset = "0x3C16920", VA = "0x183C18120")]
	public void OGEFJHJJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x3C17F20", Offset = "0x3C16720", VA = "0x183C17F20")]
	public void CILNMHIPBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x3C17CB0", Offset = "0x3C164B0", VA = "0x183C17CB0")]
	public void ACLLMILDNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class DEMBIJHNBMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool MLFGDBNOFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Action NCHNGIGODJK;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static DEMBIJHNBMP GJPAOOFPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE00D0", Offset = "0x5DDE8D0", VA = "0x185DE00D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ILOJPONJFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F8740", Offset = "0x6F6F40", VA = "0x1806F8740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8F2920", Offset = "0x8F1120", VA = "0x1808F2920")]
	public DEMBIJHNBMP(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE00B0", Offset = "0x5DDE8B0", VA = "0x185DE00B0")]
	public void ECFFKMLILHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE00B0", Offset = "0x5DDE8B0", VA = "0x185DE00B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class LNFDJHNEPLP
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	public static void AOAHADKEPPA(EDJHEDALKPA FGAAFLEJHAO, string MEDAFNDNOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GEEHOEJJKPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct BDFBJBCFGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int NCABMENALPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public T FHONEBOCBPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<object, BDFBJBCFGEF> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private T IFMDOFCBOGO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T PBMINIPAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FC820", VA = "0x1808FE020", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x417DBA0", Offset = "0x417C3A0", VA = "0x18417DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object LOGEIIFLPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x417D620", Offset = "0x417BE20", VA = "0x18417D620")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, object FDKCIGPLPAB, int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x417FD90", Offset = "0x417E590", VA = "0x18417FD90")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x417DB30", Offset = "0x417C330", VA = "0x18417DB30")]
	public bool EPBHELLGDLM(object FDKCIGPLPAB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7B10", Offset = "0x3DD6310", VA = "0x183DD7B10")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x468BB50", Offset = "0x468A350", VA = "0x18468BB50")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x37CA100", Offset = "0x37C8900", VA = "0x1837CA100")]
	public GEEHOEJJKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class BAKNAELJILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Dictionary<object, float> AAEIBLIDHOP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PJACOPGPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6FD120", Offset = "0x6FB920", VA = "0x1806FD120")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6FCC50", Offset = "0x6FB450", VA = "0x1806FCC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD7C0", Offset = "0x5DDBFC0", VA = "0x185DDD7C0")]
	public void DIBDKEEBIJK(float CCIMHDCKHOF, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD830", Offset = "0x5DDC030", VA = "0x185DDD830")]
	public void NOCLIFBDPIH(object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD6A0", Offset = "0x5DDBEA0", VA = "0x185DDD6A0")]
	private void BGCEBOKGFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD8A0", Offset = "0x5DDC0A0", VA = "0x185DDD8A0")]
	public BAKNAELJILN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class JPJBFCEOADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly string LGPEPLCFKNM;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
	public JPJBFCEOADG(string HFLMLGDIMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DE19D0", Offset = "0x5DE01D0", VA = "0x185DE19D0")]
	public JPJBFCEOADG(UnityEngine.Object ANFNOPKGHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1980", Offset = "0x5DE0180", VA = "0x185DE1980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class EDJHEDALKPA
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BBPHIMJADPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public BBPHIMJADPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5DDD920", Offset = "0x5DDC120", VA = "0x185DDD920")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private HashSet<object> BLNGIFHEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int GGOLFGKEMFA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> LJBJBLFBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5DE08D0", Offset = "0x5DDF0D0", VA = "0x185DE08D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BPPCHEPEICL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0B60", Offset = "0x5DDF360", VA = "0x185DE0B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0A00", Offset = "0x5DDF200", VA = "0x185DE0A00")]
	public bool CEMPCIEDPMO(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0830", Offset = "0x5DDF030", VA = "0x185DE0830")]
	public bool ADDEDGCCJIP(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE09A0", Offset = "0x5DDF1A0", VA = "0x185DE09A0")]
	public bool CBBIGPLMGHA(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0AF0", Offset = "0x5DDF2F0", VA = "0x185DE0AF0")]
	public void LOHBLAJMCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B70", Offset = "0x5DDF370", VA = "0x185DE0B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public EDJHEDALKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class AKNLHMNEIEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct FEGHJAEABPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float ENFOOFFCBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public T FHONEBOCBPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Dictionary<object, FEGHJAEABPP> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private T ELJEFCKGBFA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T HJHDGILCDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x210AE90", Offset = "0x2109690", VA = "0x18210AE90", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x263D450", Offset = "0x263BC50", VA = "0x18263D450", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object CACGFAIBJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFC10", Offset = "0x3ECE410", VA = "0x183ECFC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF4C0", Offset = "0x3ECDCC0", VA = "0x183ECF4C0")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3ED12B0", Offset = "0x3ECFAB0", VA = "0x183ED12B0")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD7B10", Offset = "0x3DD6310", VA = "0x183DD7B10")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECF9A0", Offset = "0x3ECE1A0", VA = "0x183ECF9A0")]
	public bool EPBHELLGDLM(object FDKCIGPLPAB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0BD0", Offset = "0x3ECF3D0", VA = "0x183ED0BD0")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1310", Offset = "0x3ECFB10", VA = "0x183ED1310")]
	public AKNLHMNEIEJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD070", Offset = "0x5DDB870", VA = "0x185DDD070")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD180", Offset = "0x5DDB980", VA = "0x185DDD180")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
