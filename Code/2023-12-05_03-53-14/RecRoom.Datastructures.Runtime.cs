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
public class ELEPBIPAOEM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x781100", Offset = "0x780500", VA = "0x180781100")]
	public ELEPBIPAOEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, OABNEOHEDGO, PGFNKMHLAHB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x775420", Offset = "0x774820", VA = "0x180775420", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LHOFGACBHAN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5E90", VA = "0x1807F6A90")]
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
	[NDFCALBHJND]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[HideInInspector]
	[NDFCALBHJND]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4F00", Offset = "0x5DE4300", VA = "0x185DE4F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4EC0", Offset = "0x5DE42C0", VA = "0x185DE4EC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4F40", Offset = "0x5DE4340", VA = "0x185DE4F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE50F0", Offset = "0x5DE44F0", VA = "0x185DE50F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5060", Offset = "0x5DE4460", VA = "0x185DE5060")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8710E0", Offset = "0x8704E0", VA = "0x1808710E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x912D40", Offset = "0x912140", VA = "0x180912D40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4E80", Offset = "0x5DE4280", VA = "0x185DE4E80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4FD0", Offset = "0x5DE43D0", VA = "0x185DE4FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49B0", Offset = "0x5DE3DB0", VA = "0x185DE49B0")]
	public void CopyBounds(SavedExtents LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4DD0", Offset = "0x5DE41D0", VA = "0x185DE4DD0")]
	public void SetLocalSpaceBounds(Bounds PFOBCKCBNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9844A0", Offset = "0x9838A0", VA = "0x1809844A0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4DC0", Offset = "0x5DE41C0", VA = "0x185DE4DC0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49E0", Offset = "0x5DE3DE0", VA = "0x185DE49E0")]
	private void DBJPNIJOMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4BA0", Offset = "0x5DE3FA0", VA = "0x185DE4BA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4340", Offset = "0x5DE3740", VA = "0x185DE4340")]
	public static void CalculateLocalBoundsFor(GameObject PLLPJJEOIKJ, [Out] Bounds PFOBCKCBNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4280", Offset = "0x5DE3680", VA = "0x185DE4280")]
	private static void AGIIOHHIPFH(Bounds MLKGDIFPGGI, Color CPHKPECCMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4DF0", Offset = "0x5DE41F0", VA = "0x185DE4DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77EAC0", Offset = "0x77DEC0", VA = "0x18077EAC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD486C0", Offset = "0xD47AC0", VA = "0x180D486C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4100C70", Offset = "0x4100070", VA = "0x184100C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
	public virtual void AMPOJFLCKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
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
	[ELEPBIPAOEM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4100850", Offset = "0x40FFC50", VA = "0x184100850", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40FF4F0", Offset = "0x40FE8F0", VA = "0x1840FF4F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4100BA0", Offset = "0x40FFFA0", VA = "0x184100BA0")]
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
	private sealed class MMGIOPKDKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public MMGIOPKDKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1330", Offset = "0x3CE0730", VA = "0x183CE1330")]
		internal int GDLGKFIJJDO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ELEPBIPAOEM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3118E90", Offset = "0x3118290", VA = "0x183118E90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3118EE0", Offset = "0x31182E0", VA = "0x183118EE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3118D90", Offset = "0x3118190", VA = "0x183118D90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MIMFBLPNKOG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3118E30", Offset = "0x3118230", VA = "0x183118E30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3118C70", Offset = "0x3118070", VA = "0x183118C70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3118990", Offset = "0x3117D90", VA = "0x183118990", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3117E30", Offset = "0x3117230", VA = "0x183117E30", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3117DA0", Offset = "0x31171A0", VA = "0x183117DA0", Slot = "14")]
	protected virtual string MFGIKEJOAGH(TKeyVal FKJCJEMHCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3117CB0", Offset = "0x31170B0", VA = "0x183117CB0", Slot = "4")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3118B30", Offset = "0x3117F30", VA = "0x183118B30", Slot = "5")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3117D00", Offset = "0x3117100", VA = "0x183117D00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3117D00", Offset = "0x3117100", VA = "0x183117D00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3118B80", Offset = "0x3117F80", VA = "0x183118B80")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KCKMDLFEJLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AJPHKEFKILB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public AJPHKEFKILB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3562DA0", Offset = "0x35621A0", VA = "0x183562DA0")]
		internal bool MOMKLKLKEBM(CMJMNONAAOE<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float AABKOCNJKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float EBMJGODMGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<CMJMNONAAOE<float, T>> AMENKKLHOGI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int CAPCIMGHHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3963370", Offset = "0x3962770", VA = "0x183963370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3963B80", Offset = "0x3962F80", VA = "0x183963B80")]
	public KCKMDLFEJLI(float ELOKGPKKGGH, float OAFAIJGKPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3963050", Offset = "0x3962450", VA = "0x183963050")]
	public bool AJMNFLNABNC(float EMHCHPDFFJH, T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3963870", Offset = "0x3962C70", VA = "0x183963870")]
	public IEnumerable<T> LNBIJLJIOJM(float EMHCHPDFFJH, [Optional] float? LIKEKJBBPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3963450", Offset = "0x3962850", VA = "0x183963450")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3963480", Offset = "0x3962880", VA = "0x183963480")]
	private void JAMOPIINKGP(float EMHCHPDFFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class GMGLBHMJALE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct DALKLLBMOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T ILNPCEAPFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float FEMKAMBIIKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float OFPLKCFKAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> BBOECPKHNOH;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int GCNPBDDDFML = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DALKLLBMOHA[] NCABOBFFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int FMBDBJEBOMM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float PMANFKCIPMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB38FE0", Offset = "0xB383E0", VA = "0x180B38FE0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB38FC0", Offset = "0xB383C0", VA = "0x180B38FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3577B80", Offset = "0x3576F80", VA = "0x183577B80")]
	public GMGLBHMJALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3577BA0", Offset = "0x3576FA0", VA = "0x183577BA0")]
	public GMGLBHMJALE(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3576D60", Offset = "0x3576160", VA = "0x183576D60")]
	public void BKKEPFPDOJH(float EMHCHPDFFJH, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35772A0", Offset = "0x35766A0", VA = "0x1835772A0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35776A0", Offset = "0x3576AA0", VA = "0x1835776A0")]
	public bool NGNOAKNAGPI(float GDGJKFLFKCP, float DLAICJOBAGL, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3576E20", Offset = "0x3576220", VA = "0x183576E20")]
	public bool HCBDHBKGKIH(float GDGJKFLFKCP, float DLAICJOBAGL, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3577510", Offset = "0x3576910", VA = "0x183577510")]
	public void LPPOGLLKGBH(float GDGJKFLFKCP, float DLAICJOBAGL, List<T> PNJHGINLCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3577390", Offset = "0x3576790", VA = "0x183577390")]
	private int KACIFCJONLG(int DJCMHPGMECB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3577650", Offset = "0x3576A50", VA = "0x183577650")]
	private void MOPPPMEGIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AJBDIFCJAAJ();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CMDODLFOPMG(T NMENOOMOOJP, float AINBOEMJDAE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T AKBPLAMNLAK(T CGOLGFILFFA, T EFDLLCLEIOO);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KFADEEOFAHL(T CGOLGFILFFA, T EFDLLCLEIOO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LCALIFMOBNP : GMGLBHMJALE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x781990", Offset = "0x780D90", VA = "0x180781990", Slot = "4")]
	protected override Vector3 AJBDIFCJAAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3410", Offset = "0x5DE2810", VA = "0x185DE3410", Slot = "5")]
	protected override Vector3 CMDODLFOPMG(Vector3 NMENOOMOOJP, float AINBOEMJDAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DE33C0", Offset = "0x5DE27C0", VA = "0x185DE33C0", Slot = "6")]
	protected override Vector3 AKBPLAMNLAK(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3450", Offset = "0x5DE2850", VA = "0x185DE3450", Slot = "7")]
	protected override Vector3 KFADEEOFAHL(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DE34D0", Offset = "0x5DE28D0", VA = "0x185DE34D0")]
	public LCALIFMOBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KLGJHPDBIPJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x257A3A0", Offset = "0x25797A0", VA = "0x18257A3A0")]
	public static CMJMNONAAOE<T1, T2> EBILOFOJHAE<T1, T2>(T1 IEOAFPFFIOF, T2 GMADBNICDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x257A420", Offset = "0x2579820", VA = "0x18257A420")]
	public static IBIBEMBICOC<T1, T2, T3> EBILOFOJHAE<T1, T2, T3>(T1 IEOAFPFFIOF, T2 GMADBNICDPL, T3 LFHMOALNBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B3F0", Offset = "0x3D0A7F0", VA = "0x183D0B3F0")]
	internal static int BGEAOCDEBDO(int JMOEEHHBNAA, int HPOINDKHAMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52B3290", Offset = "0x52B2690", VA = "0x1852B3290")]
	internal static int BGEAOCDEBDO(int JMOEEHHBNAA, int HPOINDKHAMM, int LGGGGDJIBKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CMJMNONAAOE<T1, T2> : IComparable<CMJMNONAAOE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T1 ODCAABJNHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T2 FBPINNHFMLE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4904930", Offset = "0x4903D30", VA = "0x184904930")]
	public CMJMNONAAOE(T1 IEOAFPFFIOF, T2 GMADBNICDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4902AC0", Offset = "0x4901EC0", VA = "0x184902AC0", Slot = "4")]
	public int CompareTo(CMJMNONAAOE<T1, T2> LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x49033A0", Offset = "0x49027A0", VA = "0x1849033A0", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4903D40", Offset = "0x4903140", VA = "0x184903D40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4903E10", Offset = "0x4903210", VA = "0x184903E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IBIBEMBICOC<T1, T2, T3> : IComparable<IBIBEMBICOC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T1 ODCAABJNHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T2 FBPINNHFMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T3 LPCGBAPLMHI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x36C6240", Offset = "0x36C5640", VA = "0x1836C6240")]
	public IBIBEMBICOC(T1 IEOAFPFFIOF, T2 GMADBNICDPL, T3 LFHMOALNBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36C5A40", Offset = "0x36C4E40", VA = "0x1836C5A40", Slot = "4")]
	public int CompareTo(IBIBEMBICOC<T1, T2, T3> LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x36C5B80", Offset = "0x36C4F80", VA = "0x1836C5B80", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36C5E40", Offset = "0x36C5240", VA = "0x1836C5E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x36C5F70", Offset = "0x36C5370", VA = "0x1836C5F70", Slot = "3")]
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
	public T ILNPCEAPFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EEE0", Offset = "0x1F1E2E0", VA = "0x181F1EEE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F1ED90", Offset = "0x1F1E190", VA = "0x181F1ED90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float AEPCGBLCGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80DA90", Offset = "0x80CE90", VA = "0x18080DA90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x430FC80", Offset = "0x430F080", VA = "0x18430FC80")]
	public T LKNDNCJMPJJ(float AINBOEMJDAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x430F920", Offset = "0x430ED20", VA = "0x18430F920")]
	public T HAJLNPLJHHG(float AINBOEMJDAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JLPKMGCCDGA(T CGOLGFILFFA, T EFDLLCLEIOO, float AINBOEMJDAE);

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C70", Offset = "0x5DE2070", VA = "0x185DE2C70", Slot = "4")]
	protected override float JLPKMGCCDGA(float CGOLGFILFFA, float EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2CB0", Offset = "0x5DE20B0", VA = "0x185DE2CB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC2A000", Offset = "0xC29400", VA = "0x180C2A000", Slot = "4")]
	protected override Vector3 JLPKMGCCDGA(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5F10", Offset = "0x5DE5310", VA = "0x185DE5F10")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AC0", Offset = "0x5DE0EC0", VA = "0x185DE1AC0", Slot = "4")]
	protected override Color JLPKMGCCDGA(Color CGOLGFILFFA, Color EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B80", Offset = "0x5DE0F80", VA = "0x185DE1B80")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BHKLKEBDMKF : FNAEHDJEJDN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A70", Offset = "0x5DE0E70", VA = "0x185DE1A70")]
	public BHKLKEBDMKF(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A00", Offset = "0x5DE0E00", VA = "0x185DE1A00", Slot = "6")]
	protected override uint IDBBEIKPIDH(uint LHOFGACBHAN, string NMENOOMOOJP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DMIMFDLCNOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly IDisposable NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DMIMFDLCNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NGAIOCCOKPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FBBALBMIIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int DMACLBIJPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private int CHJGHEDHDDA;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x376DCC0", Offset = "0x376D0C0", VA = "0x18376DCC0")]
	private NGAIOCCOKPO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OOCDFLGPFMD, int HLEINPDLHLC, int HLGFKBPLPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D275A0", Offset = "0x3D269A0", VA = "0x183D275A0")]
	public static NGAIOCCOKPO<T> PBDMNAJCIOP()
	{
		return default(NGAIOCCOKPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D25C20", Offset = "0x3D25020", VA = "0x183D25C20")]
	public (int, int, Task<T>) CNNFFAJGANO(int GACBLILIICC, [Optional] CancellationToken EANFAKGANNH, double IODAOFLOKJG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D273B0", Offset = "0x3D267B0", VA = "0x183D273B0")]
	public void DOMFPLGKCJP(int GACBLILIICC, int HLGFKBPLPKF, [In] T KHFCBCPBAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IDHEMLBCMOB
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32A0", Offset = "0x5DE26A0", VA = "0x185DE32A0")]
	public static NGAIOCCOKPO<CPIOBHNHOJN> PBDMNAJCIOP()
	{
		return default(NGAIOCCOKPO<CPIOBHNHOJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3220", Offset = "0x5DE2620", VA = "0x185DE3220")]
	public static void DOMFPLGKCJP([In] this NGAIOCCOKPO<CPIOBHNHOJN> EAODMOEAJOC, int GACBLILIICC, int HLGFKBPLPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DefaultMember("Item")]
public class DFFDBGFEMJN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TKey, TVal> OBCPHPFOLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly Dictionary<TVal, TKey> IMODIHCHJFI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F85530", VA = "0x182F86130", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool AHEALAJHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> LAIPAOGLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3104780", Offset = "0x3103B80", VA = "0x183104780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3210", Offset = "0x4DC2610", VA = "0x184DC3210", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4DC31B0", Offset = "0x4DC25B0", VA = "0x184DC31B0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3270", Offset = "0x4DC2670", VA = "0x184DC3270", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4DC2A70", Offset = "0x4DC1E70", VA = "0x184DC2A70")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2780", Offset = "0x4DC1B80", VA = "0x184DC2780", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3030", Offset = "0x4DC2430", VA = "0x184DC3030", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2750", Offset = "0x4DC1B50", VA = "0x184DC2750", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2700", Offset = "0x4DC1B00", VA = "0x184DC2700", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30E57B0", Offset = "0x30E4BB0", VA = "0x1830E57B0", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4DC27E0", Offset = "0x4DC1BE0", VA = "0x184DC27E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2F00", Offset = "0x4DC2300", VA = "0x184DC2F00", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2F30", Offset = "0x4DC2330", VA = "0x184DC2F30", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3080", Offset = "0x4DC2480", VA = "0x184DC3080", Slot = "11")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2980", Offset = "0x4DC1D80", VA = "0x184DC2980", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2870", Offset = "0x4DC1C70", VA = "0x184DC2870", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2670", Offset = "0x4DC1A70", VA = "0x184DC2670")]
	public bool AFCHMNEGHNL(TVal MIMFBLPNKOG, [Out] TKey NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4DC24F0", Offset = "0x4DC18F0", VA = "0x184DC24F0")]
	private void AEAFPLCJANA(TKey MIMFBLPNKOG, TVal OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2E60", Offset = "0x4DC2260", VA = "0x184DC2E60")]
	private void LPDNBCFHHOA(TKey MIMFBLPNKOG, TVal OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2C60", Offset = "0x4DC2060", VA = "0x184DC2C60")]
	private bool JDNPPFNHIOL(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4DC30C0", Offset = "0x4DC24C0", VA = "0x184DC30C0")]
	public DFFDBGFEMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public class LJAGKPEGIDK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private LJAGKPEGIDK<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3172980", Offset = "0x3171D80", VA = "0x183172980", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3173E90", Offset = "0x3173290", VA = "0x183173E90")]
		public Enumerator(LJAGKPEGIDK<T> PNJHGINLCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3170B60", Offset = "0x316FF60", VA = "0x183170B60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3172320", Offset = "0x3171720", VA = "0x183172320", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x316FB50", Offset = "0x316EF50", VA = "0x18316FB50")]
		private void ABIDAKMDHPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private T[] ABDBKDILDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HHKMAFFMIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HBMMENBNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private int AJLAIKHEKDH;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A9AD20", Offset = "0x3A9A120", VA = "0x183A9AD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B420", Offset = "0x3A9A820", VA = "0x183A9B420")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B090", Offset = "0x3A9A490", VA = "0x183A9B090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BCB0", Offset = "0x3A9B0B0", VA = "0x183A9BCB0")]
	public LJAGKPEGIDK(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AEF0", Offset = "0x3A9A2F0", VA = "0x183A9AEF0")]
	public void BKKEPFPDOJH(T AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B550", Offset = "0x3A9A950", VA = "0x183A9B550")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B270", Offset = "0x3A9A670", VA = "0x183A9B270")]
	public void FGCEGMGKOFJ(int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B850", Offset = "0x3A9AC50", VA = "0x183A9B850")]
	public void MCOHMDHFFHG(T[] NCABOBFFNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B390", Offset = "0x3A9A790", VA = "0x183A9B390")]
	public Enumerator HMFAGAOEPDF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BB30", Offset = "0x3A9AF30", VA = "0x183A9BB30", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BB30", Offset = "0x3A9AF30", VA = "0x183A9BB30", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AC10", Offset = "0x3A9A010", VA = "0x183A9AC10")]
	private int ABOACPKMOMH(int DIENMHDGFGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B240", Offset = "0x3A9A640", VA = "0x183A9B240")]
	private int CPFOBBJDKEE(int DIENMHDGFGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class PBOLJEIJDAH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Func<Internal, External> LDCNDLKEBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private IReadOnlyList<Internal> HAPGAOAPCEH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public External BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2A80", Offset = "0x3EC1E80", VA = "0x183EC2A80", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EC29C0", Offset = "0x3EC1DC0", VA = "0x183EC29C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public PBOLJEIJDAH(Func<Internal, External> LDCNDLKEBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2970", Offset = "0x3EC1D70", VA = "0x183EC2970")]
	public PBOLJEIJDAH(IReadOnlyList<Internal> HAPGAOAPCEH, Func<Internal, External> LDCNDLKEBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2890", Offset = "0x3EC1C90", VA = "0x183EC2890", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33CB230", Offset = "0x33CA630", VA = "0x1833CB230", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NPLEEFFCEBE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate Task<TResult> BBKBOPMFMLC(TRequest JAFMNEFDFCM, CancellationToken EANFAKGANNH);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum OLPGKEBBCKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class GNJMDBNAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const float BNJAONDNBAL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TimeSpan MHCNBADCGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int PGEOBPJHBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public OLPGKEBBCKM MCFOJADPALC;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly GNJMDBNAAOA LHECNHAABJO;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float CNJBPJNNDDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x357C5A0", Offset = "0x357B9A0", VA = "0x18357C5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan MJLHCIPJGBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x357C7D0", Offset = "0x357BBD0", VA = "0x18357C7D0")]
		public GNJMDBNAAOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private readonly struct IKKFOAIIPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly TRequest JAFMNEFDFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly CancellationToken EANFAKGANNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly TaskCompletionSource<TResult> DIKGLCLJFIC;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x375E900", Offset = "0x375DD00", VA = "0x18375E900")]
		public IKKFOAIIPIN(TRequest JAFMNEFDFCM, TaskCompletionSource<TResult> DIKGLCLJFIC, CancellationToken EANFAKGANNH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct AHDIFHGPLND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NPLEEFFCEBE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x355AE70", Offset = "0x355A270", VA = "0x18355AE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x355B630", Offset = "0x355AA30", VA = "0x18355B630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct GEDLKBBOPEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NPLEEFFCEBE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private IKKFOAIIPIN <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x352FD00", Offset = "0x352F100", VA = "0x18352FD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3530980", Offset = "0x352FD80", VA = "0x183530980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CancellationTokenSource PPLFHCDJKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly List<IKKFOAIIPIN> EDBMCODNDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly GNJMDBNAAOA GKCKIHFKHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly BBKBOPMFMLC KAONABANHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Task PKNIMKJHFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int PBNKEJAJDIP;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3D3AA00", Offset = "0x3D39E00", VA = "0x183D3AA00")]
	public NPLEEFFCEBE(BBKBOPMFMLC KAONABANHPF, [Optional] GNJMDBNAAOA GKCKIHFKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D39C70", Offset = "0x3D39070", VA = "0x183D39C70")]
	public Task<TResult> MOCPHLKKHEN(TRequest JAFMNEFDFCM, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3D39920", Offset = "0x3D38D20", VA = "0x183D39920")]
	private void KEOOEAIFIIG(IKKFOAIIPIN NFDMGBNANMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D396E0", Offset = "0x3D38AE0", VA = "0x183D396E0")]
	[AsyncStateMachine(typeof(NPLEEFFCEBE<, >.AHDIFHGPLND))]
	private Task HMPLCCEIFOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D3A340", Offset = "0x3D39740", VA = "0x183D3A340")]
	private IKKFOAIIPIN MPDGBNOIHML()
	{
		return default(IKKFOAIIPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D39430", Offset = "0x3D38830", VA = "0x183D39430")]
	[AsyncStateMachine(typeof(NPLEEFFCEBE<, >.GEDLKBBOPEH))]
	private Task FHOEKACHDHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D39200", Offset = "0x3D38600", VA = "0x183D39200")]
	private void CHPGGMAKFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D392F0", Offset = "0x3D386F0", VA = "0x183D392F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class EPEPOMBNBNF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly List<T> HAPGAOAPCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private HashSet<T> IODIFDMPKPL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F85530", VA = "0x182F86130", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AHEALAJHHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x30F9750", Offset = "0x30F8B50", VA = "0x1830F9750", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3112DD0", Offset = "0x31121D0", VA = "0x183112DD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3112470", Offset = "0x3111870", VA = "0x183112470", Slot = "11")]
	public void Add(T EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3112550", Offset = "0x3111950", VA = "0x183112550")]
	public bool BMPLIEBGIDJ(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3112C10", Offset = "0x3112010", VA = "0x183112C10", Slot = "15")]
	public bool Remove(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31126E0", Offset = "0x3111AE0", VA = "0x1831126E0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3112CB0", Offset = "0x31120B0", VA = "0x183112CB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3112610", Offset = "0x3111A10", VA = "0x183112610", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3112670", Offset = "0x3111A70", VA = "0x183112670", Slot = "13")]
	public bool Contains(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31126B0", Offset = "0x3111AB0", VA = "0x1831126B0", Slot = "14")]
	public void CopyTo(T[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3112770", Offset = "0x3111B70", VA = "0x183112770", Slot = "6")]
	public int IndexOf(T EDPLJLLHNEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x31128A0", Offset = "0x3111CA0", VA = "0x1831128A0", Slot = "7")]
	public void Insert(int DIENMHDGFGP, T EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3112A80", Offset = "0x3111E80", VA = "0x183112A80", Slot = "8")]
	public void RemoveAt(int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3112CE0", Offset = "0x31120E0", VA = "0x183112CE0")]
	public EPEPOMBNBNF()
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
			[Cpp2IlInjected.Address(RVA = "0x2061BE0", Offset = "0x2060FE0", VA = "0x182061BE0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5490", Offset = "0x5DE4890", VA = "0x185DE5490")]
		public SerializedGuid([In] Guid GJKCBNEBGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52F0", Offset = "0x5DE46F0", VA = "0x185DE52F0")]
		public static SerializedGuid KGCFKMMNJNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5370", Offset = "0x5DE4770", VA = "0x185DE5370")]
		public static SerializedGuid NENKMODCNKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5180", Offset = "0x5DE4580", VA = "0x185DE5180")]
		public bool BKHFNIBKMNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5460", Offset = "0x5DE4860", VA = "0x185DE5460", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE53E0", Offset = "0x5DE47E0", VA = "0x185DE53E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5210", Offset = "0x5DE4610", VA = "0x185DE5210", Slot = "7")]
		public bool Equals(SerializedGuid LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5250", Offset = "0x5DE4650", VA = "0x185DE5250", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52E0", Offset = "0x5DE46E0", VA = "0x185DE52E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE51E0", Offset = "0x5DE45E0", VA = "0x185DE51E0", Slot = "6")]
		public int CompareTo(SerializedGuid LFMLAKDHEFO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EDHLLHOCIDJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly Type DKPKEOLJMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string MJBFCILFHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly bool IBNNHAJGIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly bool DJJBPOMELHF;

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2BA0", Offset = "0x5DE1FA0", VA = "0x185DE2BA0")]
	public EDHLLHOCIDJ(Type CGKJPFOOJJN, string KBBNMNNHGKA, bool IGPLLDJLCOL = false, bool LOPBMPDLBKH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PIHHFPKOALH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public readonly struct AJEHHNHHBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly long NDIHPFMLNID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly long ENACCCMAMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly int ODFDOAKBDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly int PNKDAAHGGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool LBHJNJGMMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string FFEGBBHBJAH;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3562750", Offset = "0x3561B50", VA = "0x183562750")]
		public AJEHHNHHBCP(long NDIHPFMLNID, int ODFDOAKBDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35627C0", Offset = "0x3561BC0", VA = "0x1835627C0")]
		public AJEHHNHHBCP(long NDIHPFMLNID, long ENACCCMAMBC, int ODFDOAKBDGN, int PNKDAAHGGFO, bool LBHJNJGMMDG, string FFEGBBHBJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35625E0", Offset = "0x35619E0", VA = "0x1835625E0")]
		public int BFPBCMJLDCD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3562730", Offset = "0x3561B30", VA = "0x183562730")]
		public int MIAEMDGGCCD(int COEDICOBHHC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3562630", Offset = "0x3561A30", VA = "0x183562630")]
		public double EGKOHHJDBAN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3562690", Offset = "0x3561A90", VA = "0x183562690")]
		public AJEHHNHHBCP FPLHHMJBEJP(long ENACCCMAMBC, int PNKDAAHGGFO)
		{
			return default(AJEHHNHHBCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class NABJKOHEGKG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct BOFODIABBPI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NABJKOHEGKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Func<NABJKOHEGKG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private NABJKOHEGKG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4587FF0", Offset = "0x45873F0", VA = "0x184587FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3559460", Offset = "0x3558860", VA = "0x183559460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly TKey BOGLOOJGMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly PIHHFPKOALH<TKey> HINBFABCJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly GBIKKFKHKKF BLHBFCHIDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private List<NABJKOHEGKG> MEILBOAALDP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string CJIPGHGAHIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A530", Offset = "0x3D19930", VA = "0x183D1A530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<NABJKOHEGKG> AAHFLMHFOND
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A2A0", Offset = "0x3D196A0", VA = "0x183D1A2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AJEHHNHHBCP EKLLKFIAHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A510", Offset = "0x3D19910", VA = "0x183D1A510")]
			[CompilerGenerated]
			get
			{
				return default(AJEHHNHHBCP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3D1A2E0", Offset = "0x3D196E0", VA = "0x183D1A2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A560", Offset = "0x3D19960", VA = "0x183D1A560")]
		internal NABJKOHEGKG(PIHHFPKOALH<TKey> HINBFABCJMK, TKey MIMFBLPNKOG, GBIKKFKHKKF BLHBFCHIDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A140", Offset = "0x3D19540", VA = "0x183D1A140")]
		public NABJKOHEGKG BCEEDKFFGBD(TKey MIMFBLPNKOG, [Optional] GBIKKFKHKKF? DHKPEJIHICJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2444940", Offset = "0x2443D40", VA = "0x182444940")]
		[AsyncStateMachine(typeof(BOFODIABBPI<>))]
		public Task<T> OKBEHBGIMJF<T>(TKey MIMFBLPNKOG, Func<NABJKOHEGKG, Task<T>> KMOKEKJAEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D1A310", Offset = "0x3D19710", VA = "0x183D1A310", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class JNJDLDDEOBH : IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private (TKey key, List<TKey> path, AJEHHNHHBCP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PIHHFPKOALH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private IEnumerator<(TKey key, List<TKey> path, AJEHHNHHBCP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, AJEHHNHHBCP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x20617F0", Offset = "0x2060BF0", VA = "0x1820617F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AJEHHNHHBCP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3914D90", Offset = "0x3914190", VA = "0x183914D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20618E0", Offset = "0x2060CE0", VA = "0x1820618E0")]
		[DebuggerHidden]
		public JNJDLDDEOBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x33C5DB0", Offset = "0x33C51B0", VA = "0x1833C5DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3914890", Offset = "0x3913C90", VA = "0x183914890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3914C30", Offset = "0x3914030", VA = "0x183914C30")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3914D40", Offset = "0x3914140", VA = "0x183914D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3914C80", Offset = "0x3914080", VA = "0x183914C80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x33CE260", Offset = "0x33CD660", VA = "0x1833CE260", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class LNAMALACILP : IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private (TKey key, List<TKey> path, AJEHHNHHBCP timerEntry) <>2__current;

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
		private NABJKOHEGKG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NABJKOHEGKG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public PIHHFPKOALH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private IEnumerator<NABJKOHEGKG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private IEnumerator<(TKey key, List<TKey> path, AJEHHNHHBCP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, AJEHHNHHBCP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x20617F0", Offset = "0x2060BF0", VA = "0x1820617F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, AJEHHNHHBCP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3AADF00", Offset = "0x3AAD300", VA = "0x183AADF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x20618E0", Offset = "0x2060CE0", VA = "0x1820618E0")]
		[DebuggerHidden]
		public LNAMALACILP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3AADF60", Offset = "0x3AAD360", VA = "0x183AADF60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD590", Offset = "0x3AAC990", VA = "0x183AAD590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3AADD40", Offset = "0x3AAD140", VA = "0x183AADD40")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD530", Offset = "0x3AAC930", VA = "0x183AAD530")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AADEB0", Offset = "0x3AAD2B0", VA = "0x183AADEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3AADDA0", Offset = "0x3AAD1A0", VA = "0x183AADDA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3AADE80", Offset = "0x3AAD280", VA = "0x183AADE80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> ADKHFOPOGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> CIHPHFNBNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly Action<PIHHFPKOALH<TKey>, GBIKKFKHKKF> BFLHJEHNHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GBIKKFKHKKF BLHBFCHIDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NABJKOHEGKG GLINIEEFDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool CIECAMCCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int DBICJCLEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Stopwatch BKOAKFJFGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly int OPLIJLFILFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string LPFOEKFDPJG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NABJKOHEGKG FKKFBIEDIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string CJIPGHGAHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x778420", Offset = "0x777820", VA = "0x180778420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F16170", Offset = "0x3F15570", VA = "0x183F16170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F161D0", Offset = "0x3F155D0", VA = "0x183F161D0")]
	public PIHHFPKOALH(TKey CBGPOPFODNO, GBIKKFKHKKF BLHBFCHIDPL, [Optional] int? ODFDOAKBDGN, [Optional][CanBeNull] Stopwatch BKOAKFJFGDI, [Optional] Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> ADKHFOPOGKA, [Optional] Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> CIHPHFNBNLO, [Optional] Action<PIHHFPKOALH<TKey>, GBIKKFKHKKF> BFLHJEHNHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F15F80", Offset = "0x3F15380", VA = "0x183F15F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F16010", Offset = "0x3F15410", VA = "0x183F16010")]
	[IteratorStateMachine(typeof(PIHHFPKOALH<>.JNJDLDDEOBH))]
	public IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)> FONEJGJKFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F160A0", Offset = "0x3F154A0", VA = "0x183F160A0")]
	[IteratorStateMachine(typeof(PIHHFPKOALH<>.LNAMALACILP))]
	private IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)> FONEJGJKFLK(List<TKey> NLAOLIJBIMP, NABJKOHEGKG IGOKCLHKDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3F15F00", Offset = "0x3F15300", VA = "0x183F15F00")]
	private (long, int) CJPEDKNHGHC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public abstract class JFPAFMMGAPJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected JFPAFMMGAPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public abstract class DPANGIHJFFI<TKey> : JFPAFMMGAPJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate string MMDLIGCELFJ(TKey MIMFBLPNKOG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4DECB60", Offset = "0x4DEBF60", VA = "0x184DECB60")]
	private static string KBKFKGAJEKE(TKey MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4DECCF0", Offset = "0x4DEC0F0", VA = "0x184DECCF0", Slot = "4")]
	public override string KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4DECBA0", Offset = "0x4DEBFA0", VA = "0x184DECBA0")]
	public string KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK, [NotNull] MMDLIGCELFJ JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLEHPPLIHNO(PIHHFPKOALH<TKey> HINBFABCJMK, [NotNull] MMDLIGCELFJ JAHJPPENOFA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x352A300", Offset = "0x3529700", VA = "0x18352A300")]
	protected DPANGIHJFFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class IBOFKOIHLNG<TKey> : JFPAFMMGAPJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate string GMJMLBCCDIN(TKey MIMFBLPNKOG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly string GNEGIMHONMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly double JPMAGDJKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly bool OONMKCCDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int JMLDPPPGCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly ISet<string> HCKCHPMANHG;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x36CC230", Offset = "0x36CB630", VA = "0x1836CC230")]
	private static string KBKFKGAJEKE(TKey MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x36CCA80", Offset = "0x36CBE80", VA = "0x1836CCA80")]
	public IBOFKOIHLNG(string GNEGIMHONMB = "F2", double JPMAGDJKCOH = double.MaxValue, bool OONMKCCDGBF = false, int JMLDPPPGCHC = int.MaxValue, [Optional] ISet<string> HCKCHPMANHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36CC270", Offset = "0x36CB670", VA = "0x1836CC270", Slot = "4")]
	public override Dictionary<string, string> KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x36CBF10", Offset = "0x36CB310", VA = "0x1836CBF10")]
	private bool AOEKIAGJOKN(string MNNOIAJEFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x36CC330", Offset = "0x36CB730", VA = "0x1836CC330")]
	public Dictionary<string, string> KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK, GMJMLBCCDIN JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x36CBFF0", Offset = "0x36CB3F0", VA = "0x1836CBFF0")]
	private string GJNFIHNHBGL(StringBuilder GLLDNDEBOFD, List<TKey> PHAIBMOKGCF, GMJMLBCCDIN JAHJPPENOFA, bool BFMIILBCCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x36CC920", Offset = "0x36CBD20", VA = "0x1836CC920")]
	private static void LNMEELDDAFL(StringBuilder MCDDBPLKBBH, string EMIGIDOMKDH, bool IHFODLKABOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NFDBKGOJFJF<TKey> : DPANGIHJFFI<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MAMAMNGFKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public MMDLIGCELFJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static NFDBKGOJFJF<TKey> NMGLFNHIICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string[] IAHDLDHAEID;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3D250B0", Offset = "0x3D244B0", VA = "0x183D250B0")]
	private NFDBKGOJFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D24050", Offset = "0x3D23450", VA = "0x183D24050", Slot = "5")]
	protected override string BLEHPPLIHNO(PIHHFPKOALH<TKey> HINBFABCJMK, MMDLIGCELFJ JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D24E80", Offset = "0x3D24280", VA = "0x183D24E80")]
	[CompilerGenerated]
	internal static string EDIMFMGOEEN(string JIMANCBDAFN, TKey MIMFBLPNKOG, MAMAMNGFKJE P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LIMGENJPIFA : PIHHFPKOALH<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class KGDHMCPBJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Action<LIMGENJPIFA, GBIKKFKHKKF> callback;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KGDHMCPBJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3330", Offset = "0x5DE2730", VA = "0x185DE3330")]
		internal void KDAMAHIBEAK(PIHHFPKOALH<string> timer, GBIKKFKHKKF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A80", Offset = "0x5DE2E80", VA = "0x185DE3A80")]
	public LIMGENJPIFA(GBIKKFKHKKF BLHBFCHIDPL, [Optional] string DFGHFHNEBFB, [Optional] int? ODFDOAKBDGN, [Optional] Stopwatch BKOAKFJFGDI, [Optional] Action<string, AJEHHNHHBCP, GBIKKFKHKKF> ADKHFOPOGKA, [Optional] Action<string, AJEHHNHHBCP, GBIKKFKHKKF> CIHPHFNBNLO, [Optional] Action<LIMGENJPIFA, GBIKKFKHKKF> BFLHJEHNHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE39C0", Offset = "0x5DE2DC0", VA = "0x185DE39C0")]
	private static Action<PIHHFPKOALH<string>, GBIKKFKHKKF> NDNCLAIFHJC(Action<LIMGENJPIFA, GBIKKFKHKKF> PDECDCHNHMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class OGMBNNGOAAL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class ANHNPIEJPAG : OGMBNNGOAAL
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static OGMBNNGOAAL NMGLFNHIICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5DE0B30", Offset = "0x5DDFF30", VA = "0x185DE0B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float ADCPLMDBKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1C9E810", Offset = "0x1C9DC10", VA = "0x181C9E810", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0C30", Offset = "0x5DE0030", VA = "0x185DE0C30")]
		public ANHNPIEJPAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static OGMBNNGOAAL GAJFKANPIFN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static OGMBNNGOAAL LHECNHAABJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3BD0", Offset = "0x5DE2FD0", VA = "0x185DE3BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float ADCPLMDBKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected OGMBNNGOAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JFAHHHHOPDB : PCHLBPIPACH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE32F0", Offset = "0x5DE26F0", VA = "0x185DE32F0")]
	public JFAHHHHOPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PCHLBPIPACH<T> : OBCMOPCNEDJ<T>, IEDPNBJPIEH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task<T> CGHMHGKHODA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public CJNEKNCGBDK<T> MKHHKJAEINF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2E40", Offset = "0x3EC2240", VA = "0x183EC2E40")]
	public PCHLBPIPACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ELHNJMHJDNG<T> : OBCMOPCNEDJ<T>, IEDPNBJPIEH, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Task<T> CGHMHGKHODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public CJNEKNCGBDK<T> MKHHKJAEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3103E50", Offset = "0x3103250", VA = "0x183103E50")]
	public ELHNJMHJDNG(Exception GAFOFJBHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IEDPNBJPIEH : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OBCMOPCNEDJ<T> : IEDPNBJPIEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[NotNull]
	Task<T> CGHMHGKHODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	CJNEKNCGBDK<T> MKHHKJAEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class AGEHHECLDGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	protected static bool BLMOMMOODOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0A30", Offset = "0x5DDFE30", VA = "0x185DE0A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DE09D0", Offset = "0x5DDFDD0", VA = "0x185DE09D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0A80", Offset = "0x5DDFE80", VA = "0x185DE0A80")]
	static AGEHHECLDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	protected AGEHHECLDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public abstract class DGBEBIFCLJD<TTask, T> : AGEHHECLDGJ, OBCMOPCNEDJ<T>, IEDPNBJPIEH, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class JMMAKCCBELC
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
			public JMMAKCCBELC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x2F77020", Offset = "0x2F76420", VA = "0x182F77020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F772F0", Offset = "0x2F766F0", VA = "0x182F772F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public DGBEBIFCLJD<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public JMMAKCCBELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x39140A0", Offset = "0x39134A0", VA = "0x1839140A0")]
		[AsyncStateMachine(typeof(DGBEBIFCLJD<, >.JMMAKCCBELC.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ANMKENHMIGF(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Task<T> BPGIJHHDFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	protected readonly CancellationTokenSource FNCADPJKBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool CIECAMCCGCB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task<T> CGHMHGKHODA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CJNEKNCGBDK<T> MKHHKJAEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HCOCIBGGEOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x857250", Offset = "0x856650", VA = "0x180857250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD890", Offset = "0x4DCCC90", VA = "0x184DCD890")]
	protected DGBEBIFCLJD(TTask BPGIJHHDFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD650", Offset = "0x4DCCA50", VA = "0x184DCD650", Slot = "1")]
	~DGBEBIFCLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0B70", Offset = "0x3ACFF70", VA = "0x183AD0B70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD370", Offset = "0x4DCC770", VA = "0x184DCD370")]
	private void FJNCMFNOBDL(bool GEHOGBFBDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JAHDBHHGHFI(TTask EHPIIEBCBGJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract void KNKJKMJIGFG();
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GMDPPIBKFCP
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2D60", Offset = "0x5DE2160", VA = "0x185DE2D60")]
	[NotNull]
	public static byte[] KKMPHFMPHEM(this OABNEOHEDGO CDNKMKNCNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2CF0", Offset = "0x5DE20F0", VA = "0x185DE2CF0")]
	[NotNull]
	public static byte[] KKMPHFMPHEM(this OABNEOHEDGO CDNKMKNCNIL, HashAlgorithmName DECGFNENDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3090", Offset = "0x5DE2490", VA = "0x185DE3090")]
	public static bool PHNJIEMKGDG([CanBeNull] this OABNEOHEDGO CDNKMKNCNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2EF0", Offset = "0x5DE22F0", VA = "0x185DE2EF0")]
	public static bool PHNJIEMKGDG([CanBeNull] this OABNEOHEDGO CDNKMKNCNIL, [Out] string HCMLCAPJMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2DD0", Offset = "0x5DE21D0", VA = "0x185DE2DD0")]
	private static bool OJNGLKLDPCC([NotNull] OABNEOHEDGO CDNKMKNCNIL, [Out][CanBeNull] byte[] JONEGCBPEPF, [Out][CanBeNull] byte[] KGNGFHDPFDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ABFPBDHIAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0790", Offset = "0x5DDFB90", VA = "0x185DE0790")]
	[NotNull]
	public static byte[] KKMPHFMPHEM(this PGFNKMHLAHB LLJIKPBOOGA, HashAlgorithmName DECGFNENDNP, byte[] FHELOIIOCMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PGFNKMHLAHB
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LHOFGACBHAN);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OABNEOHEDGO : PGFNKMHLAHB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[CanBeNull]
	byte[] JFONKHAJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[CanBeNull]
	byte[] MDLJGBMOHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class APJDIBEBFCC
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static readonly ArrayPool<byte> DICHKDGEBPC;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static bool JLAIKNPEBFG;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1280", Offset = "0x5DE0680", VA = "0x185DE1280")]
	public static void JNEPKIDMKHN(this IncrementalHash GOEPOJAJOLN, [CanBeNull] GameObject PLLPJJEOIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AB30", Offset = "0x2B39F30", VA = "0x182B3AB30")]
	public static void JNEPKIDMKHN<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] T AIKEEEBGAIM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2B3ABF0", Offset = "0x2B39FF0", VA = "0x182B3ABF0")]
	public static void MMNACAOAOHH<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] T LLJIKPBOOGA) where T : PGFNKMHLAHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A610", Offset = "0x2B39A10", VA = "0x182B3A610")]
	public static void INKMMNBPMMD<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] IList<T> LJDDEBCNPPB) where T : PGFNKMHLAHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0CE0", Offset = "0x5DE00E0", VA = "0x185DE0CE0")]
	private static bool DJPKAACJKAJ([CanBeNull] PGFNKMHLAHB LLJIKPBOOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE14D0", Offset = "0x5DE08D0", VA = "0x185DE14D0")]
	public static void NLDPBLIKNCL(this IncrementalHash LHOFGACBHAN, [CanBeNull] string KFFAMCKAPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0F40", Offset = "0x5DE0340", VA = "0x185DE0F40")]
	public static void FIMODBKFEBC(this IncrementalHash LHOFGACBHAN, long BKKMLHJABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1530", Offset = "0x5DE0930", VA = "0x185DE1530")]
	public static void OKHACPGGGOG(this IncrementalHash LHOFGACBHAN, int DGEKHHMJPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D70", Offset = "0x5DE0170", VA = "0x185DE0D70")]
	public static void DMAKOEAGDAB(this IncrementalHash LHOFGACBHAN, short ABIOHIDKEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1360", Offset = "0x5DE0760", VA = "0x185DE1360")]
	public static void LEFOEFGOBBC(this IncrementalHash LHOFGACBHAN, byte PJEKMLDFONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1110", Offset = "0x5DE0510", VA = "0x185DE1110")]
	public static void GCFIOFODILD(this IncrementalHash LHOFGACBHAN, bool MCHCOEMEBCO, bool KMGLCJPGDNF = false, bool DFIMMHLHDBP = false, bool JAFHIGGAGJP = false, bool AFAJFMGOAJP = false, bool FPHAKFALFGL = false, bool KJMADBFLNNF = false, bool NCHAKNJIDAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AC80", Offset = "0x2B3A080", VA = "0x182B3AC80")]
	public static void OEOOJGKNJJO<T>(this IncrementalHash LHOFGACBHAN, T PNHGPNJINIO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1470", Offset = "0x5DE0870", VA = "0x185DE1470")]
	public static void NIBNHJHGECI(this IncrementalHash LHOFGACBHAN, float FCLANNFCLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1890", Offset = "0x5DE0C90", VA = "0x185DE1890")]
	public static void PNLHHBEJIMM(this IncrementalHash LHOFGACBHAN, ulong IDPADHCHPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0C80", Offset = "0x5DE0080", VA = "0x185DE0C80")]
	public static void BAMHBCDFJHC(this IncrementalHash LHOFGACBHAN, uint AMGNGEEDFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1830", Offset = "0x5DE0C30", VA = "0x185DE1830")]
	public static void PENLLLLDPEF(this IncrementalHash LHOFGACBHAN, ushort AIBGEDELNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1700", Offset = "0x5DE0B00", VA = "0x185DE1700")]
	public static void OPHLIFDAPEP(this IncrementalHash LHOFGACBHAN, Vector3 IJCHCDMKKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FCCPJJHBLIA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C10", Offset = "0x5DE2010", VA = "0x185DE2C10")]
	public FCCPJJHBLIA(string KCFFPPIEBHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class IEJEJGDELAP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	internal class EKFAHKPLNEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TNode EAODMOEAJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public TNode ECLIMLPEPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public KINNJBJCKNK EPJCHCPCJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public List<KINNJBJCKNK> KPBLAEFPJEF;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public EKFAHKPLNEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal struct KINNJBJCKNK : IComparable<KINNJBJCKNK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int CLNHOKCOILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public TClaimant KKBKFKENENL;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xB65DF0", Offset = "0xB651F0", VA = "0x180B65DF0")]
		public KINNJBJCKNK(int CLNHOKCOILM, TClaimant KKBKFKENENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39C5990", Offset = "0x39C4D90", VA = "0x1839C5990")]
		public bool LJGAIMKHHDK([In] KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x39C59F0", Offset = "0x39C4DF0", VA = "0x1839C59F0")]
		public bool NKOIPBLPPCH([In] KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39C5980", Offset = "0x39C4D80", VA = "0x1839C5980", Slot = "4")]
		public int CompareTo(KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39C5A00", Offset = "0x39C4E00", VA = "0x1839C5A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum JIBPNPAJKJB
	{
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class IMJCCPIJBAN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public IEJEJGDELAP<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8ECB00", Offset = "0x8EBF00", VA = "0x1808ECB00")]
		[DebuggerHidden]
		public IMJCCPIJBAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x37608F0", Offset = "0x375FCF0", VA = "0x1837608F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3760AB0", Offset = "0x375FEB0", VA = "0x183760AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x37609D0", Offset = "0x375FDD0", VA = "0x1837609D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x33C7220", Offset = "0x33C6620", VA = "0x1833C7220", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly ECCHAMMCFJL<EKFAHKPLNEO> AFMJFCAKGGK;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static readonly ECCHAMMCFJL<List<KINNJBJCKNK>> AFOGCLBJHOF;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static int NOMOFCBAPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal readonly Dictionary<TClaimant, TNode> JANJMGNNOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal readonly Dictionary<TNode, EKFAHKPLNEO> HNNAOJNDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private JIBPNPAJKJB LEIDKMNBCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool DEPIKGHNAID;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FIHPFNMDHDI(TNode JKACDAAJHJD);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FOGKNLOAEBM(TNode JKACDAAJHJD, TClaimant LKDHJCONJJH, TClaimant ODKFOGBKDJP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x37421E0", Offset = "0x37415E0", VA = "0x1837421E0")]
	public IEJEJGDELAP(JIBPNPAJKJB LEIDKMNBCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3741080", Offset = "0x3740480", VA = "0x183741080")]
	public void EKHCMEDKOFM(TNode JKACDAAJHJD, TNode IPAKJOEMEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3740A50", Offset = "0x373FE50", VA = "0x183740A50")]
	public void DHHKOELGLPP(TClaimant KKBKFKENENL, TNode BOJKLANAFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3740B70", Offset = "0x373FF70", VA = "0x183740B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x37417C0", Offset = "0x3740BC0", VA = "0x1837417C0")]
	private void KEGBEPIOECB(TClaimant KKBKFKENENL, TNode IDJMEHAFBPL, TNode BOJKLANAFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3741750", Offset = "0x3740B50", VA = "0x183741750")]
	private int KDKCFAJFAHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3740D40", Offset = "0x3740140", VA = "0x183740D40")]
	private void EIPBOLANKKG(TClaimant KKBKFKENENL, TNode NJKKONOAGGC, TNode NJFOAHFANFG, int DBHGLDMHAKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x37409C0", Offset = "0x373FDC0", VA = "0x1837409C0")]
	private void BIACNIBNJJD(KINNJBJCKNK ACCHIOJKLCL, EKFAHKPLNEO LAIGFFBGCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3741110", Offset = "0x3740510", VA = "0x183741110")]
	private void GEOIEOKAGIE(TClaimant KKBKFKENENL, TNode NJKKONOAGGC, TNode NJFOAHFANFG, int DBHGLDMHAKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3741640", Offset = "0x3740A40", VA = "0x183741640")]
	private void JOIOLGFGILC(KINNJBJCKNK ACCHIOJKLCL, TNode JKACDAAJHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3741C90", Offset = "0x3741090", VA = "0x183741C90")]
	private void NFCGACHLGHK(KINNJBJCKNK ACCHIOJKLCL, EKFAHKPLNEO LAIGFFBGCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3741D80", Offset = "0x3741180", VA = "0x183741D80")]
	private void NOPKAAAIBFP(EKFAHKPLNEO LAIGFFBGCFN, bool LCAANNMOCFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3741950", Offset = "0x3740D50", VA = "0x183741950")]
	private void LIMBFKMIPIA(EKFAHKPLNEO LAIGFFBGCFN, TNode IPAKJOEMEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x37413F0", Offset = "0x37407F0", VA = "0x1837413F0")]
	[IteratorStateMachine(typeof(IEJEJGDELAP<, >.IMJCCPIJBAN))]
	private IEnumerable<TNode> IAMAJHKCEAM(TNode NJKKONOAGGC, TNode NJFOAHFANFG, bool OHACBHBOFOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3741860", Offset = "0x3740C60", VA = "0x183741860")]
	private EKFAHKPLNEO KHHNJHKLKOF(TNode JKACDAAJHJD, TNode ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x37414D0", Offset = "0x37408D0", VA = "0x1837414D0")]
	private EKFAHKPLNEO INFIKNBCFOF(TNode JKACDAAJHJD, TNode ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3741EB0", Offset = "0x37412B0", VA = "0x183741EB0")]
	private void ONKMNHIFMEN(EKFAHKPLNEO LAIGFFBGCFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class FNAEHDJEJDN<T> : IEnumerable<FNAEHDJEJDN<T>.OIFBAPJHDGG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct OIFBAPJHDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public T NMENOOMOOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int DIENMHDGFGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class ODHJBIFCOJP : IEnumerator<OIFBAPJHDGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private FNAEHDJEJDN<T> HPOCFKLBOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private int DIENMHDGFGP;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3119B60", Offset = "0x3118F60", VA = "0x183119B60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public OIFBAPJHDGG ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3DF6070", Offset = "0x3DF5470", VA = "0x183DF6070", Slot = "4")]
			get
			{
				return default(OIFBAPJHDGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF6030", Offset = "0x3DF5430", VA = "0x183DF6030")]
		public ODHJBIFCOJP(FNAEHDJEJDN<T> HPOCFKLBOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF5FB0", Offset = "0x3DF53B0", VA = "0x183DF5FB0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x316CA90", Offset = "0x316BE90", VA = "0x18316CA90", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CD00", Offset = "0x1B0C100", VA = "0x181B0CD00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private struct PFAIIOCAGJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public bool NDOAEDKPNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public T NMENOOMOOJP;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const int ACFFHECPFIP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly Dictionary<T, int> HGJFLPINAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PFAIIOCAGJI[] GKLNFHGEBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int DPLGNJBJPAF;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int OKHHIJDJCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2310", Offset = "0x7B1710", VA = "0x1807B2310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1970", Offset = "0x7B0D70", VA = "0x1807B1970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F85530", VA = "0x182F86130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3478760", Offset = "0x3477B60", VA = "0x183478760")]
	public FNAEHDJEJDN(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3478840", Offset = "0x3477C40", VA = "0x183478840")]
	public FNAEHDJEJDN(OIFBAPJHDGG[] CECICBAAHNG, bool AGLIDPLMKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3478650", Offset = "0x3477A50", VA = "0x183478650")]
	public int MMMHPHPCHFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3478340", Offset = "0x3477740", VA = "0x183478340")]
	private int GLOIIAJKNHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3478620", Offset = "0x3477A20", VA = "0x183478620", Slot = "6")]
	protected virtual uint IDBBEIKPIDH(uint LHOFGACBHAN, T NMENOOMOOJP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3478100", Offset = "0x3477500", VA = "0x183478100")]
	public bool CMLPBOHMEKB(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3477A90", Offset = "0x3476E90", VA = "0x183477A90")]
	public int AEODHHCKODN(T NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3478580", Offset = "0x3477980", VA = "0x183478580")]
	public T HOPALDFECFK(int DIENMHDGFGP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3477B00", Offset = "0x3476F00", VA = "0x183477B00")]
	public bool BMPLIEBGIDJ(T NMENOOMOOJP, bool OGKAOMLELGH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3477DB0", Offset = "0x34771B0", VA = "0x183477DB0")]
	public bool BMPLIEBGIDJ(T NMENOOMOOJP, int DIENMHDGFGP, bool OGKAOMLELGH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3478060", Offset = "0x3477460", VA = "0x183478060")]
	private int CFHEDIAOFCJ(int HHKMAFFMIKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x34786E0", Offset = "0x3477AE0", VA = "0x1834786E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x34786E0", Offset = "0x3477AE0", VA = "0x1834786E0", Slot = "4")]
	private IEnumerator<OIFBAPJHDGG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class ECCHAMMCFJL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Stack<T> NFEFFDFOKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<T> OLOFKKJPOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly int FCFHBPGBMGE;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x30E4690", Offset = "0x30E3A90", VA = "0x1830E4690")]
	public static ECCHAMMCFJL<T> OEJOLPDFAHH(int EKJEIMGCNCB = 0, int FCFHBPGBMGE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x30E4910", Offset = "0x30E3D10", VA = "0x1830E4910")]
	public ECCHAMMCFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30E4770", Offset = "0x30E3B70", VA = "0x1830E4770")]
	public ECCHAMMCFJL(int EKJEIMGCNCB, int FCFHBPGBMGE = int.MaxValue, bool NFKBGKEECNB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30E40E0", Offset = "0x30E34E0", VA = "0x1830E40E0")]
	public T DANMHHJAMLP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x30E43A0", Offset = "0x30E37A0", VA = "0x1830E43A0")]
	public void FHBGBJJCKEM(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x30E4000", Offset = "0x30E3400", VA = "0x1830E4000")]
	private void CPLJGNJPEDP(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x30E4470", Offset = "0x30E3870", VA = "0x1830E4470")]
	private void MEONELBAMPJ(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x30E4260", Offset = "0x30E3660", VA = "0x1830E4260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x30E4490", Offset = "0x30E3890", VA = "0x1830E4490")]
	private void MGGDDIDJFOF(IEnumerable<T> GDGKEEBHCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NJNFPPCJFIF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<int, T> MJJMEPPKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private T AOINJPOPCOK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public virtual T CGDBALKDFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3D309A0", Offset = "0x3D2FDA0", VA = "0x183D309A0")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D30930", Offset = "0x3D2FD30", VA = "0x183D30930")]
	public bool DADDPKGOCCP(int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D30C80", Offset = "0x3D30080", VA = "0x183D30C80")]
	public T KAHDAMILILK(int OEPKFEKLEAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D30F80", Offset = "0x3D30380", VA = "0x183D30F80")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D308E0", Offset = "0x3D2FCE0", VA = "0x183D308E0")]
	public bool AFCHMNEGHNL(int CLNHOKCOILM, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D31020", Offset = "0x3D30420", VA = "0x183D31020")]
	public NJNFPPCJFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class ENEBJLAOCBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	protected struct MNKICBDEBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public T ILNPCEAPFCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int NGNMMHLFMBP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	protected readonly List<MNKICBDEBOD> ABDBKDILDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private T LHFDINHLBHO;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2F86130", Offset = "0x2F85530", VA = "0x182F86130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x310B6A0", Offset = "0x310AAA0", VA = "0x18310B6A0")]
	public bool CCJBPIIMLHG(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x310B600", Offset = "0x310AA00", VA = "0x18310B600")]
	public void BKKEPFPDOJH(T NMENOOMOOJP, int CLNHOKCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x310B820", Offset = "0x310AC20", VA = "0x18310B820")]
	public bool HBMDGHADMGB(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x310BAD0", Offset = "0x310AED0", VA = "0x18310BAD0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x310B580", Offset = "0x310A980", VA = "0x18310B580")]
	public T BELKAAGPBIA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x310B970", Offset = "0x310AD70", VA = "0x18310B970")]
	private void IACEPJMFGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x310BB30", Offset = "0x310AF30", VA = "0x18310BB30")]
	public ENEBJLAOCBK()
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
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3E80", Offset = "0x5DE3280", VA = "0x185DE3E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4150", Offset = "0x5DE3550", VA = "0x185DE4150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4060", Offset = "0x5DE3460", VA = "0x185DE4060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3DD0", Offset = "0x5DE31D0", VA = "0x185DE3DD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DE40A0", Offset = "0x5DE34A0", VA = "0x185DE40A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3FB0", Offset = "0x5DE33B0", VA = "0x185DE3FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3D40", Offset = "0x5DE3140", VA = "0x185DE3D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C9110", Offset = "0x40C8510", VA = "0x1840C9110", Slot = "4")]
		public virtual T CFLGAPBCDFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DMMJDACBMDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<byte, LHNHDKNCDIE> BDFGKFIOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly ECCHAMMCFJL<LHNHDKNCDIE> BHIIKCLPCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly bool LBDDOIAKBKC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LHNHDKNCDIE HPDFNOPAGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector2 NKFBBENNKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAF6DA0", Offset = "0xAF61A0", VA = "0x180AF6DA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xDC49F0", Offset = "0xDC3DF0", VA = "0x180DC49F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 ELGANODCOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDF9B60", Offset = "0xDF8F60", VA = "0x180DF9B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 ODDJPPGHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1D30", Offset = "0x5DE1130", VA = "0x185DE1D30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x773AB0", Offset = "0x772EB0", VA = "0x180773AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int DJCEKAPDOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774E60", VA = "0x180775A60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x775A70", Offset = "0x774E70", VA = "0x180775A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2710", Offset = "0x5DE1B10", VA = "0x185DE2710")]
	public DMMJDACBMDG(Bounds KNCHPBNAJOJ, Vector2[] INFNFIFOEEN, int INABNMDGFEA, byte HHKMAFFMIKG, float LCLMMFOGGGC = 0f, [Optional] ECCHAMMCFJL<LHNHDKNCDIE> BHIIKCLPCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2030", Offset = "0x5DE1430", VA = "0x185DE2030")]
	public LHNHDKNCDIE INMOAIELNDI(byte DIENMHDGFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2640", Offset = "0x5DE1A40", VA = "0x185DE2640")]
	public void PPDONOOJPJJ(Vector3 JCADPOBEOPO, float ICGNBGEOOMP, float CNBGCPJPKOF, List<byte> GMEEFBGIPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B166D0", Offset = "0x1B15AD0", VA = "0x181B166D0")]
	public void FEFPNGPJNJL(LHNHDKNCDIE.OMAGFBCICME EJDEBNAENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C40", Offset = "0x5DE1040", VA = "0x185DE1C40")]
	public static int BGPFONJLDEF(Vector2[] INFNFIFOEEN, int INABNMDGFEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2440", Offset = "0x5DE1840", VA = "0x185DE2440")]
	private LHNHDKNCDIE NOBJHCCLPPF(byte DIENMHDGFGP, LHNHDKNCDIE.MLLCEBDMCJJ CDDILJNOPLC, LHNHDKNCDIE ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2090", Offset = "0x5DE1490", VA = "0x185DE2090")]
	private void KBKPAEEOOCH(LHNHDKNCDIE ECLIMLPEPIL, Vector2[] INFNFIFOEEN, int BPJEPAGEEOD, int BBDIBFOKENG, int GIPNPBHFJOC, int OEHPJFKJCHG, float LCLMMFOGGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1DB0", Offset = "0x5DE11B0", VA = "0x185DE1DB0")]
	private void FNKIOBDGHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1D50", Offset = "0x5DE1150", VA = "0x185DE1D50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1FD0", Offset = "0x5DE13D0", VA = "0x185DE1FD0", Slot = "1")]
	~DMMJDACBMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LHNHDKNCDIE
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum MLLCEBDMCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OMAGFBCICME
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
	public byte KHHBGPLFKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector3 DFPMLNFPJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Vector3 DIHNPGKKGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector3 GFHAHIPPJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Vector3 JINNHFIEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public MLLCEBDMCJJ OACIIGMJNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public LHNHDKNCDIE OCENHJEKAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public List<LHNHDKNCDIE> EMGMIKMBLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool PENMFNGCGDB;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE39A0", Offset = "0x5DE2DA0", VA = "0x185DE39A0")]
	public LHNHDKNCDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3620", Offset = "0x5DE2A20", VA = "0x185DE3620")]
	public void NPCHCHIGNHH(LHNHDKNCDIE AHNPOOGMEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	public void FEFPNGPJNJL(int NGHJAKMBFKH, OMAGFBCICME EJDEBNAENPJ, int LHCNAECDNAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3740", Offset = "0x5DE2B40", VA = "0x185DE3740")]
	public void PPDONOOJPJJ(List<byte> GMEEFBGIPNM, Vector3 JCADPOBEOPO, float ICGNBGEOOMP, float CNBGCPJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3530", Offset = "0x5DE2930", VA = "0x185DE3530")]
	public bool CBPHJCJJMBK(Vector3 GGCAPAPOAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE35F0", Offset = "0x5DE29F0", VA = "0x185DE35F0")]
	public bool HOJNNFHDMFG(Vector3 GGCAPAPOAOA, float KNKOJNPJHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3560", Offset = "0x5DE2960", VA = "0x185DE3560")]
	public void GJHPIDDJMKM()
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
		public struct HCKJMJGCJDO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private readonly List<Component> HAPGAOAPCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private readonly bool HBIHNGOPJAM;

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x35DD500", Offset = "0x35DC900", VA = "0x1835DD500")]
			public HCKJMJGCJDO(List<Component> HAPGAOAPCEH, bool HBIHNGOPJAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x35DD3C0", Offset = "0x35DC7C0", VA = "0x1835DD3C0")]
			public PLLIJNPEAOI<T> HMFAGAOEPDF()
			{
				return default(PLLIJNPEAOI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x35DD430", Offset = "0x35DC830", VA = "0x1835DD430", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x35DD430", Offset = "0x35DC830", VA = "0x1835DD430", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public struct PLLIJNPEAOI<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly List<Component> HAPGAOAPCEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly bool HBIHNGOPJAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private int DIENMHDGFGP;

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public T ADHFGEBEBLN
			{
				[Cpp2IlInjected.Token(Token = "0x60001EB")]
				[Cpp2IlInjected.Address(RVA = "0x3F20AD0", Offset = "0x3F1FED0", VA = "0x183F20AD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3F20A60", Offset = "0x3F1FE60", VA = "0x183F20A60", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F20AA0", Offset = "0x3F1FEA0", VA = "0x183F20AA0")]
			public PLLIJNPEAOI(List<Component> HAPGAOAPCEH, bool HBIHNGOPJAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F209A0", Offset = "0x3F1FDA0", VA = "0x183F209A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3F209B0", Offset = "0x3F1FDB0", VA = "0x183F209B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x315AEB0", Offset = "0x315A2B0", VA = "0x18315AEB0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5700", Offset = "0x5DE4B00", VA = "0x185DE5700")]
		private void GJHPIDDJMKM(GameObject IGCNBCNNLGN, bool EHGFADNFMAI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5540", Offset = "0x5DE4940", VA = "0x185DE5540")]
		public static void GJHPIDDJMKM(GameObject IGCNBCNNLGN, ToolHierarchyCache MNODIPHKNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x27AAE10", Offset = "0x27AA210", VA = "0x1827AAE10")]
		public void HGOLOCOCCLH<T>(Action<T> ONCLGAMIHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x27AB030", Offset = "0x27AA430", VA = "0x1827AB030")]
		public T JMEHLBFCEEG<T>(bool HBIHNGOPJAM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x27AB0A0", Offset = "0x27AA4A0", VA = "0x1827AB0A0")]
		public HCKJMJGCJDO<T> PMANAFPKGKF<T>(bool HBIHNGOPJAM = false) where T : class
		{
			return default(HCKJMJGCJDO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE58E0", Offset = "0x5DE4CE0", VA = "0x185DE58E0")]
		public List<Component> KFIABODLNPM(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE54C0", Offset = "0x5DE48C0", VA = "0x185DE54C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache OPHKAEHAFCM, ToolHierarchyCache CLGLFIMLHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5870", Offset = "0x5DE4C70", VA = "0x185DE5870", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ECLCDMJMICA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MBJLLIEHDNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private int EKJEIMGCNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int NDNJNGNIAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private List<T> OHFHGCFJPNC;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x343A010", Offset = "0x3439410", VA = "0x18343A010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T JGBDDJFAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A250", Offset = "0x3C99650", VA = "0x183C9A250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T AFHOCKMBBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A180", Offset = "0x3C99580", VA = "0x183C9A180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T MPNODCAOJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A790", Offset = "0x3C99B90", VA = "0x183C9A790")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A810", Offset = "0x3C99C10", VA = "0x183C9A810")]
	public MBJLLIEHDNG(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A3C0", Offset = "0x3C997C0", VA = "0x183C9A3C0")]
	public void BKKEPFPDOJH(T DHPAHNEEIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A6F0", Offset = "0x3C99AF0", VA = "0x183C9A6F0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A610", Offset = "0x3C99A10", VA = "0x183C9A610")]
	public void FHAADKGIEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A5B0", Offset = "0x3C999B0", VA = "0x183C9A5B0")]
	public void FADADAHOEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C9A6E0", Offset = "0x3C99AE0", VA = "0x183C9A6E0")]
	public void GNOIGBELKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FBDPKPLJGHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	private struct CEPDELNPBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int NGNMMHLFMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T ILNPCEAPFCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<object, CEPDELNPBIH> MJJMEPPKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly EqualityComparer<T> BNILNHHALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T AOINJPOPCOK;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public virtual T CGDBALKDFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xEE10B0", Offset = "0xEE04B0", VA = "0x180EE10B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x343C6E0", Offset = "0x343BAE0", VA = "0x18343C6E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool OEJIBJJBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x343C7B0", Offset = "0x343BBB0", VA = "0x18343C7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public object CNGNCGGPOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x343C9F0", Offset = "0x343BDF0", VA = "0x18343C9F0")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, object NOEAHPPKHNC, int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x343C720", Offset = "0x343BB20", VA = "0x18343C720")]
	public bool DADDPKGOCCP(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x343C490", Offset = "0x343B890", VA = "0x18343C490")]
	public bool AFCHMNEGHNL(object NOEAHPPKHNC, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x343C800", Offset = "0x343BC00", VA = "0x18343C800")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x343DC00", Offset = "0x343D000", VA = "0x18343DC00")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x343F440", Offset = "0x343E840", VA = "0x18343F440")]
	public FBDPKPLJGHF()
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
