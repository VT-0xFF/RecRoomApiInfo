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
public class PPPNIEGIKJO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x782100", Offset = "0x780900", VA = "0x180782100")]
	public PPPNIEGIKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KPPGHGEKAIL, AGILFGHECJL, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NNKNHLJGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F7A90", Offset = "0x7F6290", VA = "0x1807F7A90")]
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
	[GHPDGCCKJMB]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[GHPDGCCKJMB]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B50", Offset = "0x5DE2350", VA = "0x185DE3B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B10", Offset = "0x5DE2310", VA = "0x185DE3B10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3B90", Offset = "0x5DE2390", VA = "0x185DE3B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3D40", Offset = "0x5DE2540", VA = "0x185DE3D40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3CB0", Offset = "0x5DE24B0", VA = "0x185DE3CB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x872370", Offset = "0x870B70", VA = "0x180872370")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x913080", Offset = "0x911880", VA = "0x180913080")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3AD0", Offset = "0x5DE22D0", VA = "0x185DE3AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3C20", Offset = "0x5DE2420", VA = "0x185DE3C20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3540", Offset = "0x5DE1D40", VA = "0x185DE3540")]
	public void CopyBounds(SavedExtents FPJCFKAMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A20", Offset = "0x5DE2220", VA = "0x185DE3A20")]
	public void SetLocalSpaceBounds(Bounds EKMKPHLMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9831F0", Offset = "0x9819F0", VA = "0x1809831F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A10", Offset = "0x5DE2210", VA = "0x185DE3A10")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3630", Offset = "0x5DE1E30", VA = "0x185DE3630")]
	private void JKJOEKJIJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE37F0", Offset = "0x5DE1FF0", VA = "0x185DE37F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2ED0", Offset = "0x5DE16D0", VA = "0x185DE2ED0")]
	public static void CalculateLocalBoundsFor(GameObject AOMHCMIECFG, [Out] Bounds EKMKPHLMINN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3570", Offset = "0x5DE1D70", VA = "0x185DE3570")]
	private static void HIFAKOFDLBA(Bounds KIOLHHMPBGL, Color DNNFFPMDBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A40", Offset = "0x5DE2240", VA = "0x185DE3A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77C550", Offset = "0x77AD50", VA = "0x18077C550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD4CF80", Offset = "0xD4B780", VA = "0x180D4CF80")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4101430", Offset = "0x40FFC30", VA = "0x184101430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
	public virtual void ENIBPIPOBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
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
	[PPPNIEGIKJO]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4101010", Offset = "0x40FF810", VA = "0x184101010", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40FFCB0", Offset = "0x40FE4B0", VA = "0x1840FFCB0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4101360", Offset = "0x40FFB60", VA = "0x184101360")]
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
	private sealed class JHMPLEPHJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JHMPLEPHJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3890520", Offset = "0x388ED20", VA = "0x183890520")]
		internal int NKOEOEPCKGC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[PPPNIEGIKJO]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x312F0F0", Offset = "0x312D8F0", VA = "0x18312F0F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x312F140", Offset = "0x312D940", VA = "0x18312F140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x312EFF0", Offset = "0x312D7F0", VA = "0x18312EFF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey EMBEECDJLJB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x312F090", Offset = "0x312D890", VA = "0x18312F090", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x312EED0", Offset = "0x312D6D0", VA = "0x18312EED0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x312EBF0", Offset = "0x312D3F0", VA = "0x18312EBF0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x312E090", Offset = "0x312C890", VA = "0x18312E090", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x312DF90", Offset = "0x312C790", VA = "0x18312DF90", Slot = "14")]
	protected virtual string DAAGGHCAILL(TKeyVal FJFBHIMEJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x312DF10", Offset = "0x312C710", VA = "0x18312DF10", Slot = "4")]
	public bool ContainsKey(TKey EMBEECDJLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x312ED90", Offset = "0x312D590", VA = "0x18312ED90", Slot = "5")]
	public bool TryGetValue(TKey EMBEECDJLJB, [Out] TVal DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x312DFF0", Offset = "0x312C7F0", VA = "0x18312DFF0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x312DFF0", Offset = "0x312C7F0", VA = "0x18312DFF0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x312EDE0", Offset = "0x312D5E0", VA = "0x18312EDE0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ELPCJNOFBPP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JGHAIADFFLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public JGHAIADFFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x388FA80", Offset = "0x388E280", VA = "0x18388FA80")]
		internal bool AENEHNKPIJF(DBMMIPKMIHD<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float KBCAFJHONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float FGDBAIGHJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<DBMMIPKMIHD<float, T>> JIFCCLGBAEA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int KJJJPIIJFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x310F2B0", Offset = "0x310DAB0", VA = "0x18310F2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x310FD70", Offset = "0x310E570", VA = "0x18310FD70")]
	public ELPCJNOFBPP(float BBNLHAIFOIH, float EMDJACKAMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x310F4B0", Offset = "0x310DCB0", VA = "0x18310F4B0")]
	public bool BKKINANNJFM(float ODNLKBOLFPL, T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x310F950", Offset = "0x310E150", VA = "0x18310F950")]
	public IEnumerable<T> GDACCEIAIPC(float ODNLKBOLFPL, [Optional] float? POKLBDLMIIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x310FC60", Offset = "0x310E460", VA = "0x18310FC60")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x310FC90", Offset = "0x310E490", VA = "0x18310FC90")]
	private void OPABECEIDGB(float ODNLKBOLFPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class MJBNBKDOEPH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NAJPOPKGJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T HMHFMLFLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float CFMMDDHKCIH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float HBCMGFFJJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> LNDKBKEANEP;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int GHEFGFLBIEN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private NAJPOPKGJIF[] CMKNCDNHDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int KEEFPLBHNND;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float ACEMPGKBBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB38C00", Offset = "0xB37400", VA = "0x180B38C00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB38BF0", Offset = "0xB373F0", VA = "0x180B38BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B210", Offset = "0x3C99A10", VA = "0x183C9B210")]
	public MJBNBKDOEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B230", Offset = "0x3C99A30", VA = "0x183C9B230")]
	public MJBNBKDOEPH(int NKCDHJPJBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C9ACC0", Offset = "0x3C994C0", VA = "0x183C9ACC0")]
	public void INCGBOEKEGG(float ODNLKBOLFPL, T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AEC0", Offset = "0x3C996C0", VA = "0x183C9AEC0")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AFB0", Offset = "0x3C997B0", VA = "0x183C9AFB0")]
	public bool NLOEOIJAMII(float CANCEBGIMHA, float INENGNPCLLH, [Out] T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AAA0", Offset = "0x3C992A0", VA = "0x183C9AAA0")]
	public bool AJHPLFFGHDK(float CANCEBGIMHA, float INENGNPCLLH, [Out] T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AD80", Offset = "0x3C99580", VA = "0x183C9AD80")]
	public void LAFADOEHMOA(float CANCEBGIMHA, float INENGNPCLLH, List<T> IJPAPFCFHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AC90", Offset = "0x3C99490", VA = "0x183C9AC90")]
	private int GGCHMHBDBML(int EDCOPCEPFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AC40", Offset = "0x3C99440", VA = "0x183C9AC40")]
	private void CHLDPFALDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PBGMGNKBIIM();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MHKMAHEHDLJ(T DOLICEBFIPF, float OPLOPEJIHLC);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BPOMGDMODKO(T NMCFAAKFHJI, T AKHEBCAILGG);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T MGKDOCCGPEN(T NMCFAAKFHJI, T AKHEBCAILGG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ECGKFPEEDBB : MJBNBKDOEPH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x782990", Offset = "0x781190", VA = "0x180782990", Slot = "4")]
	protected override Vector3 PBGMGNKBIIM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF670", Offset = "0x5DDDE70", VA = "0x185DDF670", Slot = "5")]
	protected override Vector3 MHKMAHEHDLJ(Vector3 DOLICEBFIPF, float OPLOPEJIHLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF5A0", Offset = "0x5DDDDA0", VA = "0x185DDF5A0", Slot = "6")]
	protected override Vector3 BPOMGDMODKO(Vector3 NMCFAAKFHJI, Vector3 AKHEBCAILGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF5F0", Offset = "0x5DDDDF0", VA = "0x185DDF5F0", Slot = "7")]
	protected override Vector3 MGKDOCCGPEN(Vector3 NMCFAAKFHJI, Vector3 AKHEBCAILGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF6B0", Offset = "0x5DDDEB0", VA = "0x185DDF6B0")]
	public ECGKFPEEDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CFMPMIFNCGN
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2329EF0", Offset = "0x23286F0", VA = "0x182329EF0")]
	public static DBMMIPKMIHD<T1, T2> OEONKPJDENI<T1, T2>(T1 ELANIJIPFMJ, T2 OGHEFIFBOID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2329F70", Offset = "0x2328770", VA = "0x182329F70")]
	public static MANOFAOODNN<T1, T2, T3> OEONKPJDENI<T1, T2, T3>(T1 ELANIJIPFMJ, T2 OGHEFIFBOID, T3 FLEIHKMMKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3220", Offset = "0x3CE1A20", VA = "0x183CE3220")]
	internal static int MPFHPLMKGLK(int EBBJOADKAAK, int AIMPHAPHNNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52B1EE0", Offset = "0x52B06E0", VA = "0x1852B1EE0")]
	internal static int MPFHPLMKGLK(int EBBJOADKAAK, int AIMPHAPHNNC, int BBAONEPNOAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DBMMIPKMIHD<T1, T2> : IComparable<DBMMIPKMIHD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 LAIICJGPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 MAMKMJFJHHF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4DC4EE0", Offset = "0x4DC36E0", VA = "0x184DC4EE0")]
	public DBMMIPKMIHD(T1 ELANIJIPFMJ, T2 OGHEFIFBOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2CD0", Offset = "0x4DC14D0", VA = "0x184DC2CD0", Slot = "4")]
	public int CompareTo(DBMMIPKMIHD<T1, T2> FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4DC34B0", Offset = "0x4DC1CB0", VA = "0x184DC34B0", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4DC4220", Offset = "0x4DC2A20", VA = "0x184DC4220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4DC48E0", Offset = "0x4DC30E0", VA = "0x184DC48E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MANOFAOODNN<T1, T2, T3> : IComparable<MANOFAOODNN<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 LAIICJGPICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 MAMKMJFJHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 GPGLBEDIFMK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C40A20", Offset = "0x3C3F220", VA = "0x183C40A20")]
	public MANOFAOODNN(T1 ELANIJIPFMJ, T2 OGHEFIFBOID, T3 FLEIHKMMKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C40220", Offset = "0x3C3EA20", VA = "0x183C40220", Slot = "4")]
	public int CompareTo(MANOFAOODNN<T1, T2, T3> FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C40470", Offset = "0x3C3EC70", VA = "0x183C40470", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C406B0", Offset = "0x3C3EEB0", VA = "0x183C406B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C40860", Offset = "0x3C3F060", VA = "0x183C40860", Slot = "3")]
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
	public T HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F20F50", Offset = "0x1F1F750", VA = "0x181F20F50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F210E0", Offset = "0x1F1F8E0", VA = "0x181F210E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float ONOMGFBENEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x430F950", Offset = "0x430E150", VA = "0x18430F950")]
	public T GFJAGHEFKAC(float OPLOPEJIHLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x430FAE0", Offset = "0x430E2E0", VA = "0x18430FAE0")]
	public T HCHDEDPMMIE(float OPLOPEJIHLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BOBOPMMAJNO(T NMCFAAKFHJI, T AKHEBCAILGG, float OPLOPEJIHLC);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0740", Offset = "0x5DDEF40", VA = "0x185DE0740", Slot = "4")]
	protected override float BOBOPMMAJNO(float NMCFAAKFHJI, float AKHEBCAILGG, float OPLOPEJIHLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0780", Offset = "0x5DDEF80", VA = "0x185DE0780")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC28F30", Offset = "0xC27730", VA = "0x180C28F30", Slot = "4")]
	protected override Vector3 BOBOPMMAJNO(Vector3 NMCFAAKFHJI, Vector3 AKHEBCAILGG, float OPLOPEJIHLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B60", Offset = "0x5DE3360", VA = "0x185DE4B60")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF4A0", Offset = "0x5DDDCA0", VA = "0x185DDF4A0", Slot = "4")]
	protected override Color BOBOPMMAJNO(Color NMCFAAKFHJI, Color AKHEBCAILGG, float OPLOPEJIHLC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF560", Offset = "0x5DDDD60", VA = "0x185DDF560")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AJKPPKCHKID : NDCNDJKFLEJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF450", Offset = "0x5DDDC50", VA = "0x185DDF450")]
	public AJKPPKCHKID(int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF3E0", Offset = "0x5DDDBE0", VA = "0x185DDF3E0", Slot = "6")]
	protected override uint CAPILBOJGAD(uint NNKNHLJGCKJ, string DOLICEBFIPF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IBJDJBPGNKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public IBJDJBPGNKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HPGFLCCGOHH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OOFEKEAIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int PMNBCIACCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int IKFPEKOCJOE;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x35F3970", Offset = "0x35F2170", VA = "0x1835F3970")]
	private HPGFLCCGOHH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ALHHENPLCMA, int JGGDOECHCNO, int IBNIEKLBGGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x35F1EF0", Offset = "0x35F06F0", VA = "0x1835F1EF0")]
	public static HPGFLCCGOHH<T> AKKFLOCCMNP()
	{
		return default(HPGFLCCGOHH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x35F26B0", Offset = "0x35F0EB0", VA = "0x1835F26B0")]
	public (int, int, Task<T>) DIOKJPGKBPE(int MIPDLHFJFIA, [Optional] CancellationToken GANAOLJLMGA, double GDAIBLFKMLM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x35F3430", Offset = "0x35F1C30", VA = "0x1835F3430")]
	public void FAJEIEAHIMB(int MIPDLHFJFIA, int IBNIEKLBGGD, [In] T MLABNLLFODC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IFNDOOPBACN
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1930", Offset = "0x5DE0130", VA = "0x185DE1930")]
	public static HPGFLCCGOHH<EGJHPKNOBOC> AKKFLOCCMNP()
	{
		return default(HPGFLCCGOHH<EGJHPKNOBOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1980", Offset = "0x5DE0180", VA = "0x185DE1980")]
	public static void FAJEIEAHIMB([In] this HPGFLCCGOHH<EGJHPKNOBOC> PIEBBHMNEOG, int MIPDLHFJFIA, int IBNIEKLBGGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class BKLNIGMHCHA<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> BPIFEOBDJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> IMJHLACAAHB;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F84100", Offset = "0x2F82900", VA = "0x182F84100", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool POGMNPDPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> OHLKCDBNFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3515070", Offset = "0x3513870", VA = "0x183515070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> KJHAFFLDAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4603A90", Offset = "0x4602290", VA = "0x184603A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4603A30", Offset = "0x4602230", VA = "0x184603A30", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4603AF0", Offset = "0x46022F0", VA = "0x184603AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4603640", Offset = "0x4601E40", VA = "0x184603640")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4602DA0", Offset = "0x46015A0", VA = "0x184602DA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4603860", Offset = "0x4602060", VA = "0x184603860", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4602D70", Offset = "0x4601570", VA = "0x184602D70", Slot = "9")]
	public void Add(TKey EMBEECDJLJB, TVal DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4602D00", Offset = "0x4601500", VA = "0x184602D00", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BPGGEPDHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x345C6E0", Offset = "0x345AEE0", VA = "0x18345C6E0", Slot = "8")]
	public bool ContainsKey(TKey EMBEECDJLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4602E00", Offset = "0x4601600", VA = "0x184602E00", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46037B0", Offset = "0x4601FB0", VA = "0x1846037B0", Slot = "10")]
	public bool Remove(TKey EMBEECDJLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4603780", Offset = "0x4601F80", VA = "0x184603780", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4603900", Offset = "0x4602100", VA = "0x184603900", Slot = "11")]
	public bool TryGetValue(TKey EMBEECDJLJB, [Out] TVal DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4603190", Offset = "0x4601990", VA = "0x184603190", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4602E90", Offset = "0x4601690", VA = "0x184602E90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CMKNCDNHDNA, int FJLHDHNDEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4603730", Offset = "0x4601F30", VA = "0x184603730")]
	public bool POGGOEPLKIB(TVal EMBEECDJLJB, [Out] TKey DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4603350", Offset = "0x4601B50", VA = "0x184603350")]
	private void IFLANAKFLBB(TKey EMBEECDJLJB, TVal IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x46035A0", Offset = "0x4601DA0", VA = "0x1846035A0")]
	private void LGNAOHEBPNH(TKey EMBEECDJLJB, TVal IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46030B0", Offset = "0x46018B0", VA = "0x1846030B0")]
	private bool GHKAJLBEJJD(TKey EMBEECDJLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4603940", Offset = "0x4602140", VA = "0x184603940")]
	public BKLNIGMHCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class DPDECKNKOBF<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private DPDECKNKOBF<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3189880", Offset = "0x3188080", VA = "0x183189880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x318AD30", Offset = "0x3189530", VA = "0x18318AD30")]
		public Enumerator(DPDECKNKOBF<T> IJPAPFCFHAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3188D40", Offset = "0x3187540", VA = "0x183188D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3189360", Offset = "0x3187B60", VA = "0x183189360", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3187600", Offset = "0x3185E00", VA = "0x183187600")]
		private void GPKLKELLDGF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] GMCMPCFFBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int DJIOGHHPANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GKJFKKBKEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int GLPKPIDPHCF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4DF3570", Offset = "0x4DF1D70", VA = "0x184DF3570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4DF36E0", Offset = "0x4DF1EE0", VA = "0x184DF36E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4DF2A60", Offset = "0x4DF1260", VA = "0x184DF2A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4DF38B0", Offset = "0x4DF20B0", VA = "0x184DF38B0")]
	public DPDECKNKOBF(int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF32E0", Offset = "0x4DF1AE0", VA = "0x184DF32E0")]
	public void INCGBOEKEGG(T OPLOPEJIHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF3550", Offset = "0x4DF1D50", VA = "0x184DF3550")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4DF3090", Offset = "0x4DF1890", VA = "0x184DF3090")]
	public void IIMDFCIBHIC(int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2F20", Offset = "0x4DF1720", VA = "0x184DF2F20")]
	public void HCGPPDLDFDK(T[] CMKNCDNHDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4DF34B0", Offset = "0x4DF1CB0", VA = "0x184DF34B0")]
	public Enumerator LLEMGPCMEFC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4DF37B0", Offset = "0x4DF1FB0", VA = "0x184DF37B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4DF37B0", Offset = "0x4DF1FB0", VA = "0x184DF37B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4DF24E0", Offset = "0x4DF0CE0", VA = "0x184DF24E0")]
	private int BEEGCPGHHHB(int EAHCFBMNNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x4DF3520", Offset = "0x4DF1D20", VA = "0x184DF3520")]
	private int MIJIDEGOIFC(int EAHCFBMNNCF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class NKJNOHJDHPO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> CLBPCEHMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> GKICFBMALOA;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E580", Offset = "0x3D2CD80", VA = "0x183D2E580", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E530", Offset = "0x3D2CD30", VA = "0x183D2E530", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	public NKJNOHJDHPO(Func<Internal, External> CLBPCEHMKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E4E0", Offset = "0x3D2CCE0", VA = "0x183D2E4E0")]
	public NKJNOHJDHPO(IReadOnlyList<Internal> GKICFBMALOA, Func<Internal, External> CLBPCEHMKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E460", Offset = "0x3D2CC60", VA = "0x183D2E460", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3124AA0", Offset = "0x31232A0", VA = "0x183124AA0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KJPGIGJPGNH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> LJGEIMGOBJO(TRequest KOFJNFGLAFK, CancellationToken GANAOLJLMGA);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum LNGAIAIEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class BBLFNBJGFMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float IDGNACHCLEC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan BDFJEHAKMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int CPDFFAFBPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LNGAIAIEEAF HNPCMCPGJJF;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly BBLFNBJGFMI FCIJPOCPFGE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float JFDEBDKAOPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x45714E0", Offset = "0x456FCE0", VA = "0x1845714E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan ABKOPKIFMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x45715C0", Offset = "0x456FDC0", VA = "0x1845715C0")]
		public BBLFNBJGFMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct PLICIKIBDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest KOFJNFGLAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken GANAOLJLMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> HDOBCOGKHBC;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F137E0", Offset = "0x3F11FE0", VA = "0x183F137E0")]
		public PLICIKIBDCO(TRequest KOFJNFGLAFK, TaskCompletionSource<TResult> HDOBCOGKHBC, CancellationToken GANAOLJLMGA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct FIFJOKLGPNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public KJPGIGJPGNH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x34694B0", Offset = "0x3467CB0", VA = "0x1834694B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x346A110", Offset = "0x3468910", VA = "0x18346A110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct CEGLCADDFJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KJPGIGJPGNH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private PLICIKIBDCO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x48F0B90", Offset = "0x48EF390", VA = "0x1848F0B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x48F1130", Offset = "0x48EF930", VA = "0x1848F1130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource FGMNAIDPPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<PLICIKIBDCO> EAIADEADFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly BBLFNBJGFMI OLIHHFDDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly LJGEIMGOBJO FDMPGOKCOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task BJFHHOLEPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int GCLPHPPCDLM;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3905290", Offset = "0x3903A90", VA = "0x183905290")]
	public KJPGIGJPGNH(LJGEIMGOBJO FDMPGOKCOGN, [Optional] BBLFNBJGFMI OLIHHFDDKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3904DA0", Offset = "0x39035A0", VA = "0x183904DA0")]
	public Task<TResult> PKLFCDOONEI(TRequest KOFJNFGLAFK, CancellationToken GANAOLJLMGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x39037E0", Offset = "0x3901FE0", VA = "0x1839037E0")]
	private void DCJONDGBIDJ(PLICIKIBDCO KENNOLPIIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x39040B0", Offset = "0x39028B0", VA = "0x1839040B0")]
	[AsyncStateMachine(typeof(KJPGIGJPGNH<, >.FIFJOKLGPNK))]
	private Task NHEMDHNMKLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3904410", Offset = "0x3902C10", VA = "0x183904410")]
	private PLICIKIBDCO OIJOFLPONNE()
	{
		return default(PLICIKIBDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3903D30", Offset = "0x3902530", VA = "0x183903D30")]
	[AsyncStateMachine(typeof(KJPGIGJPGNH<, >.CEGLCADDFJA))]
	private Task JJFGIBECMDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3903B40", Offset = "0x3902340", VA = "0x183903B40")]
	private void GAPLOHICIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3903920", Offset = "0x3902120", VA = "0x183903920", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class CHLOGKMPPBF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> GKICFBMALOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> HLIFJIJHAHB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F84100", Offset = "0x2F82900", VA = "0x182F84100", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool POGMNPDPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x38603A0", Offset = "0x385EBA0", VA = "0x1838603A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x49CF1E0", Offset = "0x49CD9E0", VA = "0x1849CF1E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x349FA20", Offset = "0x349E220", VA = "0x18349FA20", Slot = "11")]
	public void Add(T BPGGEPDHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x49CE9B0", Offset = "0x49CD1B0", VA = "0x1849CE9B0")]
	public bool CNOMDMOJGEA(T BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x49CF050", Offset = "0x49CD850", VA = "0x1849CF050", Slot = "15")]
	public bool Remove(T BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3124C80", Offset = "0x3123480", VA = "0x183124C80", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34C4370", Offset = "0x34C2B70", VA = "0x1834C4370", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x49CEB30", Offset = "0x49CD330", VA = "0x1849CEB30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49CEB90", Offset = "0x49CD390", VA = "0x1849CEB90", Slot = "13")]
	public bool Contains(T BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x49CEBD0", Offset = "0x49CD3D0", VA = "0x1849CEBD0", Slot = "14")]
	public void CopyTo(T[] CMKNCDNHDNA, int FJLHDHNDEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3998C70", Offset = "0x3997470", VA = "0x183998C70", Slot = "6")]
	public int IndexOf(T BPGGEPDHIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x49CECE0", Offset = "0x49CD4E0", VA = "0x1849CECE0", Slot = "7")]
	public void Insert(int EAHCFBMNNCF, T BPGGEPDHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49CEEC0", Offset = "0x49CD6C0", VA = "0x1849CEEC0", Slot = "8")]
	public void RemoveAt(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x49CF0F0", Offset = "0x49CD8F0", VA = "0x1849CF0F0")]
	public CHLOGKMPPBF()
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
			[Cpp2IlInjected.Address(RVA = "0x2064F70", Offset = "0x2063770", VA = "0x182064F70")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE40E0", Offset = "0x5DE28E0", VA = "0x185DE40E0")]
		public SerializedGuid([In] Guid CLGOKAHLILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3E70", Offset = "0x5DE2670", VA = "0x185DE3E70")]
		public static SerializedGuid EGDEKBECGCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3DD0", Offset = "0x5DE25D0", VA = "0x185DE3DD0")]
		public static SerializedGuid CMOLKJGBAFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3FD0", Offset = "0x5DE27D0", VA = "0x185DE3FD0")]
		public bool KODPMDJOGAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE40B0", Offset = "0x5DE28B0", VA = "0x185DE40B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4030", Offset = "0x5DE2830", VA = "0x185DE4030", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3EF0", Offset = "0x5DE26F0", VA = "0x185DE3EF0", Slot = "7")]
		public bool Equals(SerializedGuid FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3F30", Offset = "0x5DE2730", VA = "0x185DE3F30", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3FC0", Offset = "0x5DE27C0", VA = "0x185DE3FC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3E40", Offset = "0x5DE2640", VA = "0x185DE3E40", Slot = "6")]
		public int CompareTo(SerializedGuid FPJCFKAMJHL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KDGPCFJPGCC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type DKEAANAOKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string DMAKNHFLKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool PPMNCEPGKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool BPHPLLAPCDF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E90", Offset = "0x5DE0690", VA = "0x185DE1E90")]
	public KDGPCFJPGCC(Type NNACMGMJJEA, string JOIFLLOOJPB, bool JILHPNAOPDF = false, bool INMFFDOGONL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FHBHLKGBKLK<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct DDGIHIPIEHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long PMKJAECLDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long CCKKJFMIDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int MDBNEFLEBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int CJFCBJMODNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool HNMDHMBBLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string GPDAEBMILJC;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4DC7430", Offset = "0x4DC5C30", VA = "0x184DC7430")]
		public DDGIHIPIEHE(long PMKJAECLDPC, int MDBNEFLEBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4DC74A0", Offset = "0x4DC5CA0", VA = "0x184DC74A0")]
		public DDGIHIPIEHE(long PMKJAECLDPC, long CCKKJFMIDLF, int MDBNEFLEBFN, int CJFCBJMODNB, bool HNMDHMBBLHA, string GPDAEBMILJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4DC7360", Offset = "0x4DC5B60", VA = "0x184DC7360")]
		public int DCFHGKEEIHC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4DC73B0", Offset = "0x4DC5BB0", VA = "0x184DC73B0")]
		public int DJFKMICKOGI(int BKKFHIPPKLA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4DC73D0", Offset = "0x4DC5BD0", VA = "0x184DC73D0")]
		public double DOECOIKECCF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4DC72C0", Offset = "0x4DC5AC0", VA = "0x184DC72C0")]
		public DDGIHIPIEHE COCMAIJPJOP(long CCKKJFMIDLF, int CJFCBJMODNB)
		{
			return default(DDGIHIPIEHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class CAOEJONIOII : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct EKEJIDLDNLA<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public CAOEJONIOII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<CAOEJONIOII, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private CAOEJONIOII <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3109DF0", Offset = "0x31085F0", VA = "0x183109DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x30FA8A0", Offset = "0x30F90A0", VA = "0x1830FA8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey GKFGCIJBLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly FHBHLKGBKLK<TKey> PFAPIIDDMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly DNJICJAPBOC KIDCMOJGGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<CAOEJONIOII> HOHNPKPNKDB;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string MCIMILIHPJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x48DB2D0", Offset = "0x48D9AD0", VA = "0x1848DB2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<CAOEJONIOII> LFEDIAGMCGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x48DB130", Offset = "0x48D9930", VA = "0x1848DB130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public DDGIHIPIEHE MPDBECMHDBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x48DB0E0", Offset = "0x48D98E0", VA = "0x1848DB0E0")]
			[CompilerGenerated]
			get
			{
				return default(DDGIHIPIEHE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x48DB100", Offset = "0x48D9900", VA = "0x1848DB100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x48DB300", Offset = "0x48D9B00", VA = "0x1848DB300")]
		internal CAOEJONIOII(FHBHLKGBKLK<TKey> PFAPIIDDMDA, TKey EMBEECDJLJB, DNJICJAPBOC KIDCMOJGGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x48DB170", Offset = "0x48D9970", VA = "0x1848DB170")]
		public CAOEJONIOII IIJENBDGBJE(TKey EMBEECDJLJB, [Optional] DNJICJAPBOC? MGGFBLGBFOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2E1EAA0", Offset = "0x2E1D2A0", VA = "0x182E1EAA0")]
		[AsyncStateMachine(typeof(EKEJIDLDNLA<>))]
		public Task<T> FGOMLJDIPFF<T>(TKey EMBEECDJLJB, Func<CAOEJONIOII, Task<T>> KCILOJEPOFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x48DAEE0", Offset = "0x48D96E0", VA = "0x1848DAEE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JDPCAGIJLIL : IEnumerable<(TKey, List<TKey>, DDGIHIPIEHE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DDGIHIPIEHE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, DDGIHIPIEHE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public FHBHLKGBKLK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, DDGIHIPIEHE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, DDGIHIPIEHE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x20646E0", Offset = "0x2062EE0", VA = "0x1820646E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DDGIHIPIEHE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x388AE20", Offset = "0x3889620", VA = "0x18388AE20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20647D0", Offset = "0x2062FD0", VA = "0x1820647D0")]
		[DebuggerHidden]
		public JDPCAGIJLIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3124B20", Offset = "0x3123320", VA = "0x183124B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x388A910", Offset = "0x3889110", VA = "0x18388A910", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x388A850", Offset = "0x3889050", VA = "0x18388A850")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x388ADD0", Offset = "0x38895D0", VA = "0x18388ADD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x388AD10", Offset = "0x3889510", VA = "0x18388AD10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DDGIHIPIEHE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x33B9390", Offset = "0x33B7B90", VA = "0x1833B9390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FLEPGFOAGMF : IEnumerable<(TKey, List<TKey>, DDGIHIPIEHE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DDGIHIPIEHE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, DDGIHIPIEHE timerEntry) <>2__current;

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
		private CAOEJONIOII timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CAOEJONIOII <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public FHBHLKGBKLK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<CAOEJONIOII> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, DDGIHIPIEHE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, DDGIHIPIEHE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x20646E0", Offset = "0x2062EE0", VA = "0x1820646E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DDGIHIPIEHE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x347D8E0", Offset = "0x347C0E0", VA = "0x18347D8E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x20647D0", Offset = "0x2062FD0", VA = "0x1820647D0")]
		[DebuggerHidden]
		public FLEPGFOAGMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x347D940", Offset = "0x347C140", VA = "0x18347D940", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x347CF70", Offset = "0x347B770", VA = "0x18347CF70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x347CF10", Offset = "0x347B710", VA = "0x18347CF10")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x347D720", Offset = "0x347BF20", VA = "0x18347D720")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x347D890", Offset = "0x347C090", VA = "0x18347D890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x347D780", Offset = "0x347BF80", VA = "0x18347D780", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DDGIHIPIEHE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x347D860", Offset = "0x347C060", VA = "0x18347D860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, DDGIHIPIEHE, DNJICJAPBOC> KPFFAIAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, DDGIHIPIEHE, DNJICJAPBOC> AMEIGNPLLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<FHBHLKGBKLK<TKey>, DNJICJAPBOC> AGBLJPGNLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CAOEJONIOII MMDHEKHCFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool INDDNGMBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int PDGBPHPFLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch FLGBOBOLJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int GNKPCAOEAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string JMNEJONMCKM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CAOEJONIOII KGDFBJINDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string MCIMILIHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x772C80", Offset = "0x771480", VA = "0x180772C80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3467E60", Offset = "0x3466660", VA = "0x183467E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3467EC0", Offset = "0x34666C0", VA = "0x183467EC0")]
	public FHBHLKGBKLK(TKey JDJPGIPFGIJ, DNJICJAPBOC KIDCMOJGGGC, [Optional] int? MDBNEFLEBFN, [Optional][CanBeNull] Stopwatch FLGBOBOLJLL, [Optional] Action<TKey, DDGIHIPIEHE, DNJICJAPBOC> KPFFAIAIACJ, [Optional] Action<TKey, DDGIHIPIEHE, DNJICJAPBOC> AMEIGNPLLBD, [Optional] Action<FHBHLKGBKLK<TKey>, DNJICJAPBOC> AGBLJPGNLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3467BF0", Offset = "0x34663F0", VA = "0x183467BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3467C80", Offset = "0x3466480", VA = "0x183467C80")]
	[IteratorStateMachine(typeof(FHBHLKGBKLK<>.JDPCAGIJLIL))]
	public IEnumerable<(TKey, List<TKey>, DDGIHIPIEHE)> EBHDDBKEMHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3467D10", Offset = "0x3466510", VA = "0x183467D10")]
	[IteratorStateMachine(typeof(FHBHLKGBKLK<>.FLEPGFOAGMF))]
	private IEnumerable<(TKey, List<TKey>, DDGIHIPIEHE)> EBHDDBKEMHL(List<TKey> LIAIPLNEAGD, CAOEJONIOII MKCPNPLOABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3467DE0", Offset = "0x34665E0", VA = "0x183467DE0")]
	private (long, int) KKLEPADLIPJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class OJOAHBPPCMJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut COBJKKKDCCJ(FHBHLKGBKLK<TKey> PFAPIIDDMDA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected OJOAHBPPCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class PLKACHLJCHO<TKey> : OJOAHBPPCMJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string BBPIOHNBOAO(TKey EMBEECDJLJB);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3F19DD0", Offset = "0x3F185D0", VA = "0x183F19DD0")]
	private static string KDPGHLBNJOC(TKey EMBEECDJLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3F19D10", Offset = "0x3F18510", VA = "0x183F19D10", Slot = "4")]
	public override string COBJKKKDCCJ(FHBHLKGBKLK<TKey> PFAPIIDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3F19BC0", Offset = "0x3F183C0", VA = "0x183F19BC0")]
	public string COBJKKKDCCJ(FHBHLKGBKLK<TKey> PFAPIIDDMDA, [NotNull] BBPIOHNBOAO OOOICENLFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MLFNDCHOJGC(FHBHLKGBKLK<TKey> PFAPIIDDMDA, [NotNull] BBPIOHNBOAO OOOICENLFNI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x36C7250", Offset = "0x36C5A50", VA = "0x1836C7250")]
	protected PLKACHLJCHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HIIKKKHCBDJ<TKey> : OJOAHBPPCMJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string AHMLHGBMDDC(TKey EMBEECDJLJB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string BFNANOGHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double BALNPKIGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool LIFHAJMEMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int ILBKJBCCHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> CAOKILAMFHH;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x359D7D0", Offset = "0x359BFD0", VA = "0x18359D7D0")]
	private static string KDPGHLBNJOC(TKey EMBEECDJLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x359D810", Offset = "0x359C010", VA = "0x18359D810")]
	public HIIKKKHCBDJ(string BFNANOGHEOO = "F2", double BALNPKIGJCH = double.MaxValue, bool LIFHAJMEMLP = false, int ILBKJBCCHAK = int.MaxValue, [Optional] ISet<string> CAOKILAMFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x359CCA0", Offset = "0x359B4A0", VA = "0x18359CCA0", Slot = "4")]
	public override Dictionary<string, string> COBJKKKDCCJ(FHBHLKGBKLK<TKey> PFAPIIDDMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x359D590", Offset = "0x359BD90", VA = "0x18359D590")]
	private bool HFLHALKOOJF(string EKGGDFDPIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x359CD60", Offset = "0x359B560", VA = "0x18359CD60")]
	public Dictionary<string, string> COBJKKKDCCJ(FHBHLKGBKLK<TKey> PFAPIIDDMDA, AHMLHGBMDDC OOOICENLFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x359D350", Offset = "0x359BB50", VA = "0x18359D350")]
	private string HFJBLMPFBNO(StringBuilder IKMAMDOMLAF, List<TKey> MKHLEFCNGHK, AHMLHGBMDDC OOOICENLFNI, bool LAKLJNMCAJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x359D670", Offset = "0x359BE70", VA = "0x18359D670")]
	private static void INGKIGIOKCM(StringBuilder ADLHOFLKLPP, string MPMFMHGJKGE, bool CEJGFGBLKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class GAFLLEAFOIP<TKey> : PLKACHLJCHO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PBHPINPLIFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public BBPIOHNBOAO keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static GAFLLEAFOIP<TKey> ODCBNHJKAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] OJKCNLGBNDD;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x35101F0", Offset = "0x350E9F0", VA = "0x1835101F0")]
	private GAFLLEAFOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x350F280", Offset = "0x350DA80", VA = "0x18350F280", Slot = "5")]
	protected override string MLFNDCHOJGC(FHBHLKGBKLK<TKey> PFAPIIDDMDA, BBPIOHNBOAO OOOICENLFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x350F190", Offset = "0x350D990", VA = "0x18350F190")]
	[CompilerGenerated]
	internal static string AKHLCIKPBKC(string OIOENJCMJED, TKey EMBEECDJLJB, PBHPINPLIFF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class HDOAFHIAAMC : FHBHLKGBKLK<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class FJCDNCCIHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<HDOAFHIAAMC, DNJICJAPBOC> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public FJCDNCCIHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DE06B0", Offset = "0x5DDEEB0", VA = "0x185DE06B0")]
		internal void IIEFLNLLCNB(FHBHLKGBKLK<string> timer, DNJICJAPBOC log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DE09E0", Offset = "0x5DDF1E0", VA = "0x185DE09E0")]
	public HDOAFHIAAMC(DNJICJAPBOC KIDCMOJGGGC, [Optional] string HMPKMKJPMDJ, [Optional] int? MDBNEFLEBFN, [Optional] Stopwatch FLGBOBOLJLL, [Optional] Action<string, DDGIHIPIEHE, DNJICJAPBOC> KPFFAIAIACJ, [Optional] Action<string, DDGIHIPIEHE, DNJICJAPBOC> AMEIGNPLLBD, [Optional] Action<HDOAFHIAAMC, DNJICJAPBOC> AGBLJPGNLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0920", Offset = "0x5DDF120", VA = "0x185DE0920")]
	private static Action<FHBHLKGBKLK<string>, DNJICJAPBOC> FKJLMEHDPPI(Action<HDOAFHIAAMC, DNJICJAPBOC> CGEKFPDGHCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class OOHAAKKHJJI
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class NEIILOKIKFC : OOHAAKKHJJI
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static OOHAAKKHJJI ODCBNHJKAMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2140", Offset = "0x5DE0940", VA = "0x185DE2140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float NMLMHFNHKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1CA2590", Offset = "0x1CA0D90", VA = "0x181CA2590", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2240", Offset = "0x5DE0A40", VA = "0x185DE2240")]
		public NEIILOKIKFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static OOHAAKKHJJI DFAJIJHFEAI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static OOHAAKKHJJI FCIJPOCPFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DE27C0", Offset = "0x5DE0FC0", VA = "0x185DE27C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float NMLMHFNHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected OOHAAKKHJJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ECLAOFIOJIL : EIBKMDMDOCN<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF710", Offset = "0x5DDDF10", VA = "0x185DDF710")]
	public ECLAOFIOJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EIBKMDMDOCN<T> : LLCBDIPCFGG<T>, HFHNGBDMGJD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> DNLNEHKEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CNJPNJMNEEH<T> MNFMILJHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3102010", Offset = "0x3100810", VA = "0x183102010")]
	public EIBKMDMDOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JEHDBEIALLB<T> : LLCBDIPCFGG<T>, HFHNGBDMGJD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> DNLNEHKEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public CNJPNJMNEEH<T> MNFMILJHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x388C190", Offset = "0x388A990", VA = "0x18388C190")]
	public JEHDBEIALLB(Exception GKFJGAEIAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HFHNGBDMGJD : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LLCBDIPCFGG<T> : HFHNGBDMGJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> DNLNEHKEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	CNJPNJMNEEH<T> MNFMILJHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class GBDBDPINJNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool EDFJKBIFBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DE07C0", Offset = "0x5DDEFC0", VA = "0x185DE07C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0810", Offset = "0x5DDF010", VA = "0x185DE0810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0870", Offset = "0x5DDF070", VA = "0x185DE0870")]
	static GBDBDPINJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	protected GBDBDPINJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class OGEFLMCMDNA<TTask, T> : GBDBDPINJNI, LLCBDIPCFGG<T>, HFHNGBDMGJD, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KCPGPNOHMPD
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
			public KCPGPNOHMPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2F74FF0", Offset = "0x2F737F0", VA = "0x182F74FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F752C0", Offset = "0x2F73AC0", VA = "0x182F752C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public OGEFLMCMDNA<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public KCPGPNOHMPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x38EC0C0", Offset = "0x38EA8C0", VA = "0x1838EC0C0")]
		[AsyncStateMachine(typeof(OGEFLMCMDNA<, >.KCPGPNOHMPD.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OMECEOPFODN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> KONAOGGENMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource LFJFOBIGOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool INDDNGMBDBO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> DNLNEHKEEJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CNJPNJMNEEH<T> MNFMILJHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F980", Offset = "0x3E0E180", VA = "0x183E0F980")]
	protected OGEFLMCMDNA(TTask KONAOGGENMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F8F0", Offset = "0x3E0E0F0", VA = "0x183E0F8F0", Slot = "1")]
	~OGEFLMCMDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DCD0", Offset = "0x3A8C4D0", VA = "0x183A8DCD0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3E0F610", Offset = "0x3E0DE10", VA = "0x183E0F610")]
	private void ALEHCMDHAIF(bool LKNKNFCDKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GBNPKEOEJHA(TTask NPHJFNBFKGH);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void APNPIMFPKGA();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class NPLMHJGFADA
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2630", Offset = "0x5DE0E30", VA = "0x185DE2630")]
	[NotNull]
	public static byte[] CIFFOBNOEDB(this KPPGHGEKAIL DGEDAEFMGBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE25C0", Offset = "0x5DE0DC0", VA = "0x185DE25C0")]
	[NotNull]
	public static byte[] CIFFOBNOEDB(this KPPGHGEKAIL DGEDAEFMGBI, HashAlgorithmName HLNNFBGMJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2290", Offset = "0x5DE0A90", VA = "0x185DE2290")]
	public static bool ABBNPNDODHB([CanBeNull] this KPPGHGEKAIL DGEDAEFMGBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2420", Offset = "0x5DE0C20", VA = "0x185DE2420")]
	public static bool ABBNPNDODHB([CanBeNull] this KPPGHGEKAIL DGEDAEFMGBI, [Out] string MFCNDEMKIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DE26A0", Offset = "0x5DE0EA0", VA = "0x185DE26A0")]
	private static bool LFECKGNGNMC([NotNull] KPPGHGEKAIL DGEDAEFMGBI, [Out][CanBeNull] byte[] PBPICOICPOP, [Out][CanBeNull] byte[] PGAPFAHCECC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MHJLPMKIMBC
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1F00", Offset = "0x5DE0700", VA = "0x185DE1F00")]
	[NotNull]
	public static byte[] CIFFOBNOEDB(this AGILFGHECJL BFMBLBCODGL, HashAlgorithmName HLNNFBGMJKI, byte[] COPJGIEGBIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AGILFGHECJL
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NNKNHLJGCKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KPPGHGEKAIL : AGILFGHECJL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] DJMKNBHCNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] IABINFLCJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HLBAKMEPABG
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> OOPLFIMJOFP;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool MLCGLEHBGGI;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1000", Offset = "0x5DDF800", VA = "0x185DE1000")]
	public static void IEMHJIBAEEI(this IncrementalHash IPFDNJPDIGA, [CanBeNull] GameObject AOMHCMIECFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x24F53F0", Offset = "0x24F3BF0", VA = "0x1824F53F0")]
	public static void IEMHJIBAEEI<T>(this IncrementalHash IPFDNJPDIGA, [CanBeNull] T MPHNJKMAKJN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E40", Offset = "0x24F3640", VA = "0x1824F4E40")]
	public static void ADNIFCEDBAI<T>(this IncrementalHash IPFDNJPDIGA, [CanBeNull] T BFMBLBCODGL) where T : AGILFGHECJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x24F4ED0", Offset = "0x24F36D0", VA = "0x1824F4ED0")]
	public static void CCFIKDBBJIP<T>(this IncrementalHash IPFDNJPDIGA, [CanBeNull] IList<T> MFEKNADOOJM) where T : AGILFGHECJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DE12B0", Offset = "0x5DDFAB0", VA = "0x185DE12B0")]
	private static bool JPDILDCMLDB([CanBeNull] AGILFGHECJL BFMBLBCODGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1510", Offset = "0x5DDFD10", VA = "0x185DE1510")]
	public static void LNHGJBNKMAG(this IncrementalHash NNKNHLJGCKJ, [CanBeNull] string KKFMFIEAFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0CC0", Offset = "0x5DDF4C0", VA = "0x185DE0CC0")]
	public static void HFGMFIOKPHJ(this IncrementalHash NNKNHLJGCKJ, long CJIIKIGEPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1570", Offset = "0x5DDFD70", VA = "0x185DE1570")]
	public static void ONIGHEJIIBB(this IncrementalHash NNKNHLJGCKJ, int GENEDGBFMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1340", Offset = "0x5DDFB40", VA = "0x185DE1340")]
	public static void LLNIAHPILMG(this IncrementalHash NNKNHLJGCKJ, short OFECKJIGIMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE10E0", Offset = "0x5DDF8E0", VA = "0x185DE10E0")]
	public static void IGPBMKLGCFL(this IncrementalHash NNKNHLJGCKJ, byte KKJGCFIDMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0E90", Offset = "0x5DDF690", VA = "0x185DE0E90")]
	public static void IDDKBPNJMDI(this IncrementalHash NNKNHLJGCKJ, bool DELACCNJJEH, bool MPKEMGDIIHA = false, bool CFIPMACCGCL = false, bool PNNFODDPCJI = false, bool OKIDFBFFDNB = false, bool IOIPLNLACGE = false, bool BKECIDPNLMH = false, bool BABKAADFNFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x24F54B0", Offset = "0x24F3CB0", VA = "0x1824F54B0")]
	public static void KMBCKFAAJCH<T>(this IncrementalHash NNKNHLJGCKJ, T EMCGBONIADL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1250", Offset = "0x5DDFA50", VA = "0x185DE1250")]
	public static void JNEAAGCEMAC(this IncrementalHash NNKNHLJGCKJ, float DEKBGEFPJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B30", Offset = "0x5DDF330", VA = "0x185DE0B30")]
	public static void CHOLOEFILHE(this IncrementalHash NNKNHLJGCKJ, ulong EEJDPCJKCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1740", Offset = "0x5DDFF40", VA = "0x185DE1740")]
	public static void PLCNPMJMDCN(this IncrementalHash NNKNHLJGCKJ, uint LPFMIHPNMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DE11F0", Offset = "0x5DDF9F0", VA = "0x185DE11F0")]
	public static void IHHPDOLNGCP(this IncrementalHash NNKNHLJGCKJ, ushort AOJEBHNDAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B90", Offset = "0x5DDF390", VA = "0x185DE0B90")]
	public static void GDDGBILOGOF(this IncrementalHash NNKNHLJGCKJ, Vector3 CCCJPOPKELI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PMBMGEJAKPB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2930", Offset = "0x5DE1130", VA = "0x185DE2930")]
	public PMBMGEJAKPB(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class MBKDFEAFGAM<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class BGFNCPAMLNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode PIEBBHMNEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode DEINPDMGBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public LEIHIGLHLJL AOABDMELJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<LEIHIGLHLJL> KAMLGALHJBN;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public BGFNCPAMLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct LEIHIGLHLJL : IComparable<LEIHIGLHLJL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int LPKKLMEOBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant FNEOBNGABOD;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB58170", Offset = "0xB56970", VA = "0x180B58170")]
		public LEIHIGLHLJL(int LPKKLMEOBCL, TClaimant FNEOBNGABOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3A078F0", Offset = "0x3A060F0", VA = "0x183A078F0")]
		public bool EOGHAAPIEMO([In] LEIHIGLHLJL FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3A07950", Offset = "0x3A06150", VA = "0x183A07950")]
		public bool NOBLEDPGHPK([In] LEIHIGLHLJL FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3A078E0", Offset = "0x3A060E0", VA = "0x183A078E0", Slot = "4")]
		public int CompareTo(LEIHIGLHLJL FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3A07960", Offset = "0x3A06160", VA = "0x183A07960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum HNPBEENMDLA
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class FPOPLCPNCBJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public MBKDFEAFGAM<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8F6270", Offset = "0x8F4A70", VA = "0x1808F6270")]
		[DebuggerHidden]
		public FPOPLCPNCBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x348C2A0", Offset = "0x348AAA0", VA = "0x18348C2A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x348C460", Offset = "0x348AC60", VA = "0x18348C460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x348C380", Offset = "0x348AB80", VA = "0x18348C380", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x33B2380", Offset = "0x33B0B80", VA = "0x1833B2380", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly JJAIDCDGJDA<BGFNCPAMLNI> EOAMEENDJCI;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly JJAIDCDGJDA<List<LEIHIGLHLJL>> PLLDMMHMDEM;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int EAHHHFDHGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> OLCEOBBMLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, BGFNCPAMLNI> AHKIHCGDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private HNPBEENMDLA JECPNLKEDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EKMIKGPLLFI(TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BEKLCAGFMFL(TNode ELOONLEOBIM, TClaimant LDMINADHOBJ, TClaimant PDMMMLLJBMP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3C42290", Offset = "0x3C40A90", VA = "0x183C42290")]
	public MBKDFEAFGAM(HNPBEENMDLA JECPNLKEDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3C41490", Offset = "0x3C3FC90", VA = "0x183C41490")]
	public void GHCABKPGLEH(TNode ELOONLEOBIM, TNode AKJKKHGAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3C40CF0", Offset = "0x3C3F4F0", VA = "0x183C40CF0")]
	public void DHHMGHLFEJN(TClaimant FNEOBNGABOD, TNode NDKDJMJIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3C40E10", Offset = "0x3C3F610", VA = "0x183C40E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3C40C50", Offset = "0x3C3F450", VA = "0x183C40C50")]
	private void BKBPMMJGECD(TClaimant FNEOBNGABOD, TNode MIHACCKOMHD, TNode NDKDJMJIHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3C41A00", Offset = "0x3C40200", VA = "0x183C41A00")]
	private int NGCNENMKBAG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3C416C0", Offset = "0x3C3FEC0", VA = "0x183C416C0")]
	private void MGBAGDHKEGC(TClaimant FNEOBNGABOD, TNode JBNACMIFJGL, TNode HNCIFHAHNEJ, int JCOMHHBJJON = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3C41520", Offset = "0x3C3FD20", VA = "0x183C41520")]
	private void HBPNFLHOMCF(LEIHIGLHLJL KDCBKNLFGEH, BGFNCPAMLNI NJFBANGIDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3C41A70", Offset = "0x3C40270", VA = "0x183C41A70")]
	private void NLKHBNBBIAC(TClaimant FNEOBNGABOD, TNode JBNACMIFJGL, TNode HNCIFHAHNEJ, int JCOMHHBJJON = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3C415B0", Offset = "0x3C3FDB0", VA = "0x183C415B0")]
	private void JKAALLGOCDI(LEIHIGLHLJL KDCBKNLFGEH, TNode ELOONLEOBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3C40A70", Offset = "0x3C3F270", VA = "0x183C40A70")]
	private void AHEMHGMOAFM(LEIHIGLHLJL KDCBKNLFGEH, BGFNCPAMLNI NJFBANGIDHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3C41EC0", Offset = "0x3C406C0", VA = "0x183C41EC0")]
	private void OGPIHKHMFCN(BGFNCPAMLNI NJFBANGIDHJ, bool EOAPBMNFLHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3C41150", Offset = "0x3C3F950", VA = "0x183C41150")]
	private void GAODAABJOOA(BGFNCPAMLNI NJFBANGIDHJ, TNode AKJKKHGAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3C41FF0", Offset = "0x3C407F0", VA = "0x183C41FF0")]
	[IteratorStateMachine(typeof(MBKDFEAFGAM<, >.FPOPLCPNCBJ))]
	private IEnumerable<TNode> PLHEACBGIHA(TNode JBNACMIFJGL, TNode HNCIFHAHNEJ, bool JHBIPCPHGLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3C40B60", Offset = "0x3C3F360", VA = "0x183C40B60")]
	private BGFNCPAMLNI ANDNGJNIDPI(TNode ELOONLEOBIM, TNode DEINPDMGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3C40FE0", Offset = "0x3C3F7E0", VA = "0x183C40FE0")]
	private BGFNCPAMLNI EHOGNENPCOP(TNode ELOONLEOBIM, TNode DEINPDMGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3C41D50", Offset = "0x3C40550", VA = "0x183C41D50")]
	private void OBIAPEJBEMA(BGFNCPAMLNI NJFBANGIDHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NDCNDJKFLEJ<T> : IEnumerable<NDCNDJKFLEJ<T>.DPEFOAMKLDM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct DPEFOAMKLDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T DOLICEBFIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int EAHCFBMNNCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class HKMHLEJKMMF : IEnumerator<DPEFOAMKLDM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private NDCNDJKFLEJ<T> GJBMHFINPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int EAHCFBMNNCF;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x312F500", Offset = "0x312DD00", VA = "0x18312F500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DPEFOAMKLDM POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x35A70C0", Offset = "0x35A58C0", VA = "0x1835A70C0", Slot = "4")]
			get
			{
				return default(DPEFOAMKLDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x35A7080", Offset = "0x35A5880", VA = "0x1835A7080")]
		public HKMHLEJKMMF(NDCNDJKFLEJ<T> GJBMHFINPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35A7000", Offset = "0x35A5800", VA = "0x1835A7000", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3181E80", Offset = "0x3180680", VA = "0x183181E80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B13680", Offset = "0x1B11E80", VA = "0x181B13680", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct AJMIKMBPIOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool AIFJLDODBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T DOLICEBFIPF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int EDFCJIHBHPO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> NKLJPDEOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AJMIKMBPIOA[] AIEOOEDJJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int DENCCBFMGND;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int DDEABLEHLJM
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FA0", Offset = "0x7B17A0", VA = "0x1807B2FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2690", Offset = "0x7B0E90", VA = "0x1807B2690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2F84100", Offset = "0x2F82900", VA = "0x182F84100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB4A0", Offset = "0x3CF9CA0", VA = "0x183CFB4A0")]
	public NDCNDJKFLEJ(int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB0D0", Offset = "0x3CF98D0", VA = "0x183CFB0D0")]
	public NDCNDJKFLEJ(DPEFOAMKLDM[] GACMGLAGEBH, bool HMEONEIMGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAE80", Offset = "0x3CF9680", VA = "0x183CFAE80")]
	public int MPLOKFFKOJM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAC90", Offset = "0x3CF9490", VA = "0x183CFAC90")]
	private int DIDMONFGIJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA3D0", Offset = "0x3CF8BD0", VA = "0x183CFA3D0", Slot = "6")]
	protected virtual uint CAPILBOJGAD(uint NNKNHLJGCKJ, T DOLICEBFIPF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB000", Offset = "0x3CF9800", VA = "0x183CFB000")]
	public bool PNHOCBOGFHC(T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA460", Offset = "0x3CF8C60", VA = "0x183CFA460")]
	public int CFKFJOPBJAA(T DOLICEBFIPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAA30", Offset = "0x3CF9230", VA = "0x183CFAA30")]
	public T CPJAGPMBALN(int EAHCFBMNNCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA990", Offset = "0x3CF9190", VA = "0x183CFA990")]
	public bool CNOMDMOJGEA(T DOLICEBFIPF, bool BJJBIDCNDGA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA4D0", Offset = "0x3CF8CD0", VA = "0x183CFA4D0")]
	public bool CNOMDMOJGEA(T DOLICEBFIPF, int EAHCFBMNNCF, bool BJJBIDCNDGA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAF10", Offset = "0x3CF9710", VA = "0x183CFAF10")]
	private int PDFEKKEKJAO(int DJIOGHHPANO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB050", Offset = "0x3CF9850", VA = "0x183CFB050", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3CFB050", Offset = "0x3CF9850", VA = "0x183CFB050", Slot = "4")]
	private IEnumerator<DPEFOAMKLDM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class JJAIDCDGJDA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> FFMCMFFBOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> KOIJINFKAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int BJEDANEIDNH;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x38936A0", Offset = "0x3891EA0", VA = "0x1838936A0")]
	public static JJAIDCDGJDA<T> IAJOJNDAHIB(int JHAJBCMGPDO = 0, int BJEDANEIDNH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3893920", Offset = "0x3892120", VA = "0x183893920")]
	public JJAIDCDGJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3893950", Offset = "0x3892150", VA = "0x183893950")]
	public JJAIDCDGJDA(int JHAJBCMGPDO, int BJEDANEIDNH = int.MaxValue, bool HBAGNCECAKB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3893780", Offset = "0x3891F80", VA = "0x183893780")]
	public T LGHMKLDEEDM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3893130", Offset = "0x3891930", VA = "0x183893130")]
	public void DABJCHJIOBI(T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x38935C0", Offset = "0x3891DC0", VA = "0x1838935C0")]
	private void FHJEIKMBGMN(T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3893900", Offset = "0x3892100", VA = "0x183893900")]
	private void NHLDDNJFDNI(T DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3893480", Offset = "0x3891C80", VA = "0x183893480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3893200", Offset = "0x3891A00", VA = "0x183893200")]
	private void DKINKJGBOLM(IEnumerable<T> JCBAGKALIOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OBCFLLADDNI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> JJJHLPMHAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T JHBHOGLOAIA;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T ADFLOBKLKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x774F80", Offset = "0x773780", VA = "0x180774F80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD890", Offset = "0x3DFC090", VA = "0x183DFD890")]
	public bool GKALFLGHMJG(T DOLICEBFIPF, int LPKKLMEOBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x354FA40", Offset = "0x354E240", VA = "0x18354FA40")]
	public bool ICDPLBICDFC(int LPKKLMEOBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD980", Offset = "0x3DFC180", VA = "0x183DFD980")]
	public T GKCMBNEBMPE(int AOOIPNFNBHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DFD6E0", Offset = "0x3DFBEE0", VA = "0x183DFD6E0")]
	private bool BMJGBEENBAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDD60", Offset = "0x3DFC560", VA = "0x183DFDD60")]
	public bool POGGOEPLKIB(int LPKKLMEOBCL, [Out] T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDDB0", Offset = "0x3DFC5B0", VA = "0x183DFDDB0")]
	public OBCFLLADDNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class BLMHJDFJGGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct NFOJGCJDHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T HMHFMLFLMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int IKPKFIBOCJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<NFOJGCJDHJO> GMCMPCFFBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T HPONEBLOPEL;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F84100", Offset = "0x2F82900", VA = "0x182F84100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4604A30", Offset = "0x4603230", VA = "0x184604A30")]
	public bool JOIKPGDKLEA(T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4604990", Offset = "0x4603190", VA = "0x184604990")]
	public void INCGBOEKEGG(T DOLICEBFIPF, int LPKKLMEOBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4604840", Offset = "0x4603040", VA = "0x184604840")]
	public bool FMCALLKJEMI(T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4604D90", Offset = "0x4603590", VA = "0x184604D90")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4604BB0", Offset = "0x46033B0", VA = "0x184604BB0")]
	public T LLFCEBOGACD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4604C30", Offset = "0x4603430", VA = "0x184604C30")]
	private void MDCBDCGDOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4604DF0", Offset = "0x46035F0", VA = "0x184604DF0")]
	public BLMHJDFJGGA()
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
		[CMCMKAFNABN(JEAHCFCDLNC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2AD0", Offset = "0x5DE12D0", VA = "0x185DE2AD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2DA0", Offset = "0x5DE15A0", VA = "0x185DE2DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2CB0", Offset = "0x5DE14B0", VA = "0x185DE2CB0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2A20", Offset = "0x5DE1220", VA = "0x185DE2A20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2CF0", Offset = "0x5DE14F0", VA = "0x185DE2CF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DE2C00", Offset = "0x5DE1400", VA = "0x185DE2C00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2990", Offset = "0x5DE1190", VA = "0x185DE2990")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C98D0", Offset = "0x40C80D0", VA = "0x1840C98D0", Slot = "4")]
		public virtual T OGAPCCHCLLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FFLDAJIONCD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, JGAMMIGBOCL> MDNNLCIJFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly JJAIDCDGJDA<JGAMMIGBOCL> EFLBHEJODDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool CPJOPBIGPMB;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JGAMMIGBOCL HFGPENBAEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 OHPGLCCKNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAFD740", Offset = "0xAFBF40", VA = "0x180AFD740")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xDCA240", Offset = "0xDC8A40", VA = "0x180DCA240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 DIGGBACKEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDFAB60", Offset = "0xDF9360", VA = "0x180DFAB60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 HAFBEPKFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF750", Offset = "0x5DDDF50", VA = "0x185DDF750")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x77D810", Offset = "0x77C010", VA = "0x18077D810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int LLNBJBIGHPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x778D40", Offset = "0x777540", VA = "0x180778D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x778B50", Offset = "0x777350", VA = "0x180778B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0220", Offset = "0x5DDEA20", VA = "0x185DE0220")]
	public FFLDAJIONCD(Bounds EMOLDODBHLE, Vector2[] PDGCHCGAMHF, int DHFBGIIPDAO, byte DJIOGHHPANO, float JPIJBCIIPEB = 0f, [Optional] JJAIDCDGJDA<JGAMMIGBOCL> EFLBHEJODDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF7D0", Offset = "0x5DDDFD0", VA = "0x185DDF7D0")]
	public JGAMMIGBOCL EKMPPCHJBHD(byte EAHCFBMNNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFDA0", Offset = "0x5DDE5A0", VA = "0x185DDFDA0")]
	public void LNCOIENDOCC(Vector3 FLFCGPFDCMD, float HBKPFKALGAO, float NOHHEIEGOIL, List<byte> POMBDBMAKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B0D920", Offset = "0x1B0C120", VA = "0x181B0D920")]
	public void CLHDNBOCPEH(JGAMMIGBOCL.FELHBMAPING NNMECIPDLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFAB0", Offset = "0x5DDE2B0", VA = "0x185DDFAB0")]
	public static int IPAHCAPIPNC(Vector2[] PDGCHCGAMHF, int DHFBGIIPDAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFBA0", Offset = "0x5DDE3A0", VA = "0x185DDFBA0")]
	private JGAMMIGBOCL KKAKCKFJHOB(byte EAHCFBMNNCF, JGAMMIGBOCL.HLCKNGEAIBB APFHCIGMDDD, JGAMMIGBOCL DEINPDMGBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFE70", Offset = "0x5DDE670", VA = "0x185DDFE70")]
	private void OCKKLEIOJHB(JGAMMIGBOCL DEINPDMGBDC, Vector2[] PDGCHCGAMHF, int GKMDMBAJNJI, int CGOMLEJDNBA, int NMGOHCOOKID, int MGFBPPMICPG, float JPIJBCIIPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF830", Offset = "0x5DDE030", VA = "0x185DDF830")]
	private void EOELNBFOLFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF770", Offset = "0x5DDDF70", VA = "0x185DDF770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFA50", Offset = "0x5DDE250", VA = "0x185DDFA50", Slot = "1")]
	~FFLDAJIONCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JGAMMIGBOCL
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum HLCKNGEAIBB
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum FELHBMAPING
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
	public byte ALAIFGAODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 EHMJLNEPACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 PCGHIJCLEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 IFICCFJMJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 DCDAEADEFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HLCKNGEAIBB MDHFJOGKBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public JGAMMIGBOCL LLPGCPJGINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<JGAMMIGBOCL> PCGDKEHPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool ICLDBEEPJIL;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E70", Offset = "0x5DE0670", VA = "0x185DE1E70")]
	public JGAMMIGBOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AC0", Offset = "0x5DE02C0", VA = "0x185DE1AC0")]
	public void INCJAOOAMKN(JGAMMIGBOCL EAAFIBGEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
	public void CLHDNBOCPEH(int CNENMMBPMBI, FELHBMAPING NNMECIPDLBH, int ENLHPKJPMMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1BE0", Offset = "0x5DE03E0", VA = "0x185DE1BE0")]
	public void LNCOIENDOCC(List<byte> POMBDBMAKHG, Vector3 FLFCGPFDCMD, float HBKPFKALGAO, float NOHHEIEGOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A90", Offset = "0x5DE0290", VA = "0x185DE1A90")]
	public bool ENFAKHKFCGM(Vector3 JCKCLHMKLHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E40", Offset = "0x5DE0640", VA = "0x185DE1E40")]
	public bool ONPPECHLBGB(Vector3 JCKCLHMKLHE, float OBCOEMLGMOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A00", Offset = "0x5DE0200", VA = "0x185DE1A00")]
	public void EBEAKPIECKB()
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
		public struct JOAAPNIFMPC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> GKICFBMALOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool MENOFOHONCO;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x38B2DB0", Offset = "0x38B15B0", VA = "0x1838B2DB0")]
			public JOAAPNIFMPC(List<Component> GKICFBMALOA, bool MENOFOHONCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x38B2C70", Offset = "0x38B1470", VA = "0x1838B2C70")]
			public KHOPOKOKPHI<T> LLEMGPCMEFC()
			{
				return default(KHOPOKOKPHI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x38B2CE0", Offset = "0x38B14E0", VA = "0x1838B2CE0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x38B2CE0", Offset = "0x38B14E0", VA = "0x1838B2CE0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct KHOPOKOKPHI<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> GKICFBMALOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool MENOFOHONCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int EAHCFBMNNCF;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T POHDIFHCONG
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x39018B0", Offset = "0x39000B0", VA = "0x1839018B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3901840", Offset = "0x3900040", VA = "0x183901840", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3901880", Offset = "0x3900080", VA = "0x183901880")]
			public KHOPOKOKPHI(List<Component> GKICFBMALOA, bool MENOFOHONCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3901780", Offset = "0x38FFF80", VA = "0x183901780", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3901790", Offset = "0x38FFF90", VA = "0x183901790", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x3170C10", Offset = "0x316F410", VA = "0x183170C10", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4620", Offset = "0x5DE2E20", VA = "0x185DE4620")]
		private void EBEAKPIECKB(GameObject FGGLKICLOCB, bool PPEPKNMOGPK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4460", Offset = "0x5DE2C60", VA = "0x185DE4460")]
		public static void EBEAKPIECKB(GameObject FGGLKICLOCB, ToolHierarchyCache KPAIMHKKLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x2799210", Offset = "0x2797A10", VA = "0x182799210")]
		public void OGEHGHIDLON<T>(Action<T> KJDOCFCKCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x27990E0", Offset = "0x27978E0", VA = "0x1827990E0")]
		public T GMCBEBLCCKJ<T>(bool MENOFOHONCO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2799150", Offset = "0x2797950", VA = "0x182799150")]
		public JOAAPNIFMPC<T> HDIDGKHPGEC<T>(bool MENOFOHONCO = false) where T : class
		{
			return default(JOAAPNIFMPC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4110", Offset = "0x5DE2910", VA = "0x185DE4110")]
		public List<Component> APIOABMJOFC(Type HJNJPNKDEFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4790", Offset = "0x5DE2F90", VA = "0x185DE4790", Slot = "4")]
		public bool Equals(ToolHierarchyCache GJPJIELLCID, ToolHierarchyCache HBNKALMNLPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4810", Offset = "0x5DE3010", VA = "0x185DE4810", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BEKFGDCEJDH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DKDGJHKDNPB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int JHAJBCMGPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int GHNNJFIDGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> HHKFGLJIGDM;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x344E300", Offset = "0x344CB00", VA = "0x18344E300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T GAFBCNBLEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4DDDFD0", Offset = "0x4DDC7D0", VA = "0x184DDDFD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T JECPHDPHEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4DDDA70", Offset = "0x4DDC270", VA = "0x184DDDA70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T JHIEEOILOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4DDDD90", Offset = "0x4DDC590", VA = "0x184DDDD90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE090", Offset = "0x4DDC890", VA = "0x184DDE090")]
	public DKDGJHKDNPB(int JHAJBCMGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDAE0", Offset = "0x4DDC2E0", VA = "0x184DDDAE0")]
	public void INCGBOEKEGG(T GHNFPDHOJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDEE0", Offset = "0x4DDC6E0", VA = "0x184DDDEE0")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDE10", Offset = "0x4DDC610", VA = "0x184DDDE10")]
	public void MAAJFFIFHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDCD0", Offset = "0x4DDC4D0", VA = "0x184DDDCD0")]
	public void KGAJOCPPEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4DDDA00", Offset = "0x4DDC200", VA = "0x184DDDA00")]
	public void AFONLBBNMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FLFGEOKLLIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct IDOGHKCKEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int IKPKFIBOCJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T HMHFMLFLMGB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, IDOGHKCKEJL> JJJHLPMHAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> DKGACEPFJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T JHBHOGLOAIA;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T ADFLOBKLKPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xEE20B0", Offset = "0xEE08B0", VA = "0x180EE20B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3480FB0", Offset = "0x347F7B0", VA = "0x183480FB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool KENEKKIHELD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3480F30", Offset = "0x347F730", VA = "0x183480F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object CAEHDMFALMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x34806D0", Offset = "0x347EED0", VA = "0x1834806D0")]
	public bool GKALFLGHMJG(T DOLICEBFIPF, object JECMOKMEJED, int LPKKLMEOBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3480EA0", Offset = "0x347F6A0", VA = "0x183480EA0")]
	public bool ICDPLBICDFC(object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x34815C0", Offset = "0x347FDC0", VA = "0x1834815C0")]
	public bool POGGOEPLKIB(object JECMOKMEJED, [Out] T DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3481020", Offset = "0x347F820", VA = "0x183481020")]
	public void MJBDPJEPBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x347EC00", Offset = "0x347D400", VA = "0x18347EC00")]
	private bool BMJGBEENBAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3481860", Offset = "0x3480060", VA = "0x183481860")]
	public FLFGEOKLLIE()
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
