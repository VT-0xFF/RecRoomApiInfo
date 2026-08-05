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
		[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F6AC0", Offset = "0x7F5EC0", VA = "0x1807F6AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DE4FE0", Offset = "0x5DE43E0", VA = "0x185DE4FE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4FA0", Offset = "0x5DE43A0", VA = "0x185DE4FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5020", Offset = "0x5DE4420", VA = "0x185DE5020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE51D0", Offset = "0x5DE45D0", VA = "0x185DE51D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5140", Offset = "0x5DE4540", VA = "0x185DE5140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8710A0", Offset = "0x8704A0", VA = "0x1808710A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x912C90", Offset = "0x912090", VA = "0x180912C90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4F60", Offset = "0x5DE4360", VA = "0x185DE4F60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DE50B0", Offset = "0x5DE44B0", VA = "0x185DE50B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4A90", Offset = "0x5DE3E90", VA = "0x185DE4A90")]
	public void CopyBounds(SavedExtents LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4EB0", Offset = "0x5DE42B0", VA = "0x185DE4EB0")]
	public void SetLocalSpaceBounds(Bounds PFOBCKCBNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x9843F0", Offset = "0x9837F0", VA = "0x1809843F0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4EA0", Offset = "0x5DE42A0", VA = "0x185DE4EA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4AC0", Offset = "0x5DE3EC0", VA = "0x185DE4AC0")]
	private void DBJPNIJOMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C80", Offset = "0x5DE4080", VA = "0x185DE4C80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4420", Offset = "0x5DE3820", VA = "0x185DE4420")]
	public static void CalculateLocalBoundsFor(GameObject PLLPJJEOIKJ, [Out] Bounds PFOBCKCBNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4360", Offset = "0x5DE3760", VA = "0x185DE4360")]
	private static void AGIIOHHIPFH(Bounds MLKGDIFPGGI, Color CPHKPECCMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4ED0", Offset = "0x5DE42D0", VA = "0x185DE4ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD48610", Offset = "0xD47A10", VA = "0x180D48610")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x40FF850", Offset = "0x40FEC50", VA = "0x1840FF850")]
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
	[Cpp2IlInjected.Address(RVA = "0x40FF430", Offset = "0x40FE830", VA = "0x1840FF430", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40FE0D0", Offset = "0x40FD4D0", VA = "0x1840FE0D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x40FF780", Offset = "0x40FEB80", VA = "0x1840FF780")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CDFE90", Offset = "0x3CDF290", VA = "0x183CDFE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x31178A0", Offset = "0x3116CA0", VA = "0x1831178A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x31178F0", Offset = "0x3116CF0", VA = "0x1831178F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x31177A0", Offset = "0x3116BA0", VA = "0x1831177A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MIMFBLPNKOG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3117840", Offset = "0x3116C40", VA = "0x183117840", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3117680", Offset = "0x3116A80", VA = "0x183117680", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x31173A0", Offset = "0x31167A0", VA = "0x1831173A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3116840", Offset = "0x3115C40", VA = "0x183116840", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31167B0", Offset = "0x3115BB0", VA = "0x1831167B0", Slot = "14")]
	protected virtual string MFGIKEJOAGH(TKeyVal FKJCJEMHCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31166C0", Offset = "0x3115AC0", VA = "0x1831166C0", Slot = "4")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3117540", Offset = "0x3116940", VA = "0x183117540", Slot = "5")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3116710", Offset = "0x3115B10", VA = "0x183116710", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3116710", Offset = "0x3115B10", VA = "0x183116710", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3117590", Offset = "0x3116990", VA = "0x183117590")]
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
		[Cpp2IlInjected.Address(RVA = "0x3565300", Offset = "0x3564700", VA = "0x183565300")]
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
		[Cpp2IlInjected.Address(RVA = "0x3961CF0", Offset = "0x39610F0", VA = "0x183961CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3962180", Offset = "0x3961580", VA = "0x183962180")]
	public KCKMDLFEJLI(float ELOKGPKKGGH, float OAFAIJGKPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3961B60", Offset = "0x3960F60", VA = "0x183961B60")]
	public bool AJMNFLNABNC(float EMHCHPDFFJH, T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3961E70", Offset = "0x3961270", VA = "0x183961E70")]
	public IEnumerable<T> LNBIJLJIOJM(float EMHCHPDFFJH, [Optional] float? LIKEKJBBPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3961D60", Offset = "0x3961160", VA = "0x183961D60")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3961D90", Offset = "0x3961190", VA = "0x183961D90")]
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
		[Cpp2IlInjected.Address(RVA = "0xB38F30", Offset = "0xB38330", VA = "0x180B38F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xB38F10", Offset = "0xB38310", VA = "0x180B38F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3555730", Offset = "0x3554B30", VA = "0x183555730")]
	public GMGLBHMJALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3555750", Offset = "0x3554B50", VA = "0x183555750")]
	public GMGLBHMJALE(int PEGIIHFIAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3554910", Offset = "0x3553D10", VA = "0x183554910")]
	public void BKKEPFPDOJH(float EMHCHPDFFJH, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3554E50", Offset = "0x3554250", VA = "0x183554E50")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3555250", Offset = "0x3554650", VA = "0x183555250")]
	public bool NGNOAKNAGPI(float GDGJKFLFKCP, float DLAICJOBAGL, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35549D0", Offset = "0x3553DD0", VA = "0x1835549D0")]
	public bool HCBDHBKGKIH(float GDGJKFLFKCP, float DLAICJOBAGL, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35550C0", Offset = "0x35544C0", VA = "0x1835550C0")]
	public void LPPOGLLKGBH(float GDGJKFLFKCP, float DLAICJOBAGL, List<T> PNJHGINLCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3554F40", Offset = "0x3554340", VA = "0x183554F40")]
	private int KACIFCJONLG(int DJCMHPGMECB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3555200", Offset = "0x3554600", VA = "0x183555200")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE34F0", Offset = "0x5DE28F0", VA = "0x185DE34F0", Slot = "5")]
	protected override Vector3 CMDODLFOPMG(Vector3 NMENOOMOOJP, float AINBOEMJDAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DE34A0", Offset = "0x5DE28A0", VA = "0x185DE34A0", Slot = "6")]
	protected override Vector3 AKBPLAMNLAK(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3530", Offset = "0x5DE2930", VA = "0x185DE3530", Slot = "7")]
	protected override Vector3 KFADEEOFAHL(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DE35B0", Offset = "0x5DE29B0", VA = "0x185DE35B0")]
	public LCALIFMOBNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KLGJHPDBIPJ
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x257A310", Offset = "0x2579710", VA = "0x18257A310")]
	public static CMJMNONAAOE<T1, T2> EBILOFOJHAE<T1, T2>(T1 IEOAFPFFIOF, T2 GMADBNICDPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x257A390", Offset = "0x2579790", VA = "0x18257A390")]
	public static IBIBEMBICOC<T1, T2, T3> EBILOFOJHAE<T1, T2, T3>(T1 IEOAFPFFIOF, T2 GMADBNICDPL, T3 LFHMOALNBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A900", Offset = "0x3D09D00", VA = "0x183D0A900")]
	internal static int BGEAOCDEBDO(int JMOEEHHBNAA, int HPOINDKHAMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x52B3370", Offset = "0x52B2770", VA = "0x1852B3370")]
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
	[Cpp2IlInjected.Address(RVA = "0x4904A70", Offset = "0x4903E70", VA = "0x184904A70")]
	public CMJMNONAAOE(T1 IEOAFPFFIOF, T2 GMADBNICDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4902C00", Offset = "0x4902000", VA = "0x184902C00", Slot = "4")]
	public int CompareTo(CMJMNONAAOE<T1, T2> LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x49034E0", Offset = "0x49028E0", VA = "0x1849034E0", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4903E80", Offset = "0x4903280", VA = "0x184903E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4903F50", Offset = "0x4903350", VA = "0x184903F50", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x36C4C30", Offset = "0x36C4030", VA = "0x1836C4C30")]
	public IBIBEMBICOC(T1 IEOAFPFFIOF, T2 GMADBNICDPL, T3 LFHMOALNBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x36C4430", Offset = "0x36C3830", VA = "0x1836C4430", Slot = "4")]
	public int CompareTo(IBIBEMBICOC<T1, T2, T3> LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x36C4570", Offset = "0x36C3970", VA = "0x1836C4570", Slot = "0")]
	public override bool Equals(object LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36C4830", Offset = "0x36C3C30", VA = "0x1836C4830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x36C4960", Offset = "0x36C3D60", VA = "0x1836C4960", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F1ECF0", Offset = "0x1F1E0F0", VA = "0x181F1ECF0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EBA0", Offset = "0x1F1DFA0", VA = "0x181F1EBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float AEPCGBLCGPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x80DA60", Offset = "0x80CE60", VA = "0x18080DA60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x430E860", Offset = "0x430DC60", VA = "0x18430E860")]
	public T LKNDNCJMPJJ(float AINBOEMJDAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x430E500", Offset = "0x430D900", VA = "0x18430E500")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE2D50", Offset = "0x5DE2150", VA = "0x185DE2D50", Slot = "4")]
	protected override float JLPKMGCCDGA(float CGOLGFILFFA, float EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2D90", Offset = "0x5DE2190", VA = "0x185DE2D90")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xC29F50", Offset = "0xC29350", VA = "0x180C29F50", Slot = "4")]
	protected override Vector3 JLPKMGCCDGA(Vector3 CGOLGFILFFA, Vector3 EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5FF0", Offset = "0x5DE53F0", VA = "0x185DE5FF0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1BA0", Offset = "0x5DE0FA0", VA = "0x185DE1BA0", Slot = "4")]
	protected override Color JLPKMGCCDGA(Color CGOLGFILFFA, Color EFDLLCLEIOO, float AINBOEMJDAE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C60", Offset = "0x5DE1060", VA = "0x185DE1C60")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BHKLKEBDMKF : FNAEHDJEJDN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B50", Offset = "0x5DE0F50", VA = "0x185DE1B50")]
	public BHKLKEBDMKF(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AE0", Offset = "0x5DE0EE0", VA = "0x185DE1AE0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x376C710", Offset = "0x376BB10", VA = "0x18376C710")]
	private NGAIOCCOKPO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OOCDFLGPFMD, int HLEINPDLHLC, int HLGFKBPLPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3D26150", Offset = "0x3D25550", VA = "0x183D26150")]
	public static NGAIOCCOKPO<T> PBDMNAJCIOP()
	{
		return default(NGAIOCCOKPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3D247D0", Offset = "0x3D23BD0", VA = "0x183D247D0")]
	public (int, int, Task<T>) CNNFFAJGANO(int GACBLILIICC, [Optional] CancellationToken EANFAKGANNH, double IODAOFLOKJG = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D25F60", Offset = "0x3D25360", VA = "0x183D25F60")]
	public void DOMFPLGKCJP(int GACBLILIICC, int HLGFKBPLPKF, [In] T KHFCBCPBAFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class IDHEMLBCMOB
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3380", Offset = "0x5DE2780", VA = "0x185DE3380")]
	public static NGAIOCCOKPO<CPIOBHNHOJN> PBDMNAJCIOP()
	{
		return default(NGAIOCCOKPO<CPIOBHNHOJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3300", Offset = "0x5DE2700", VA = "0x185DE3300")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F860A0", Offset = "0x2F854A0", VA = "0x182F860A0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x3103190", Offset = "0x3102590", VA = "0x183103190", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> CAKFANLNPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4DC32F0", Offset = "0x4DC26F0", VA = "0x184DC32F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3290", Offset = "0x4DC2690", VA = "0x184DC3290", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3350", Offset = "0x4DC2750", VA = "0x184DC3350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4DC2B50", Offset = "0x4DC1F50", VA = "0x184DC2B50")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2860", Offset = "0x4DC1C60", VA = "0x184DC2860", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3110", Offset = "0x4DC2510", VA = "0x184DC3110", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2830", Offset = "0x4DC1C30", VA = "0x184DC2830", Slot = "9")]
	public void Add(TKey MIMFBLPNKOG, TVal NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4DC27E0", Offset = "0x4DC1BE0", VA = "0x184DC27E0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x30E5720", Offset = "0x30E4B20", VA = "0x1830E5720", Slot = "8")]
	public bool ContainsKey(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4DC28C0", Offset = "0x4DC1CC0", VA = "0x184DC28C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2FE0", Offset = "0x4DC23E0", VA = "0x184DC2FE0", Slot = "10")]
	public bool Remove(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3010", Offset = "0x4DC2410", VA = "0x184DC3010", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4DC3160", Offset = "0x4DC2560", VA = "0x184DC3160", Slot = "11")]
	public bool TryGetValue(TKey MIMFBLPNKOG, [Out] TVal NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2A60", Offset = "0x4DC1E60", VA = "0x184DC2A60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2950", Offset = "0x4DC1D50", VA = "0x184DC2950", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2750", Offset = "0x4DC1B50", VA = "0x184DC2750")]
	public bool AFCHMNEGHNL(TVal MIMFBLPNKOG, [Out] TKey NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4DC25D0", Offset = "0x4DC19D0", VA = "0x184DC25D0")]
	private void AEAFPLCJANA(TKey MIMFBLPNKOG, TVal OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2F40", Offset = "0x4DC2340", VA = "0x184DC2F40")]
	private void LPDNBCFHHOA(TKey MIMFBLPNKOG, TVal OKHKFFGCACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2D40", Offset = "0x4DC2140", VA = "0x184DC2D40")]
	private bool JDNPPFNHIOL(TKey MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4DC31A0", Offset = "0x4DC25A0", VA = "0x184DC31A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3171230", Offset = "0x3170630", VA = "0x183171230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3172740", Offset = "0x3171B40", VA = "0x183172740")]
		public Enumerator(LJAGKPEGIDK<T> PNJHGINLCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x316F410", Offset = "0x316E810", VA = "0x18316F410", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3170BD0", Offset = "0x316FFD0", VA = "0x183170BD0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x316E400", Offset = "0x316D800", VA = "0x18316E400")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A998B0", Offset = "0x3A98CB0", VA = "0x183A998B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T BPKONBPIDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x3A99FB0", Offset = "0x3A993B0", VA = "0x183A99FB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3A99C20", Offset = "0x3A99020", VA = "0x183A99C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A840", Offset = "0x3A99C40", VA = "0x183A9A840")]
	public LJAGKPEGIDK(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A99A80", Offset = "0x3A98E80", VA = "0x183A99A80")]
	public void BKKEPFPDOJH(T AINBOEMJDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A0E0", Offset = "0x3A994E0", VA = "0x183A9A0E0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3A99E00", Offset = "0x3A99200", VA = "0x183A99E00")]
	public void FGCEGMGKOFJ(int APAKJDHFMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A3E0", Offset = "0x3A997E0", VA = "0x183A9A3E0")]
	public void MCOHMDHFFHG(T[] NCABOBFFNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A99F20", Offset = "0x3A99320", VA = "0x183A99F20")]
	public Enumerator HMFAGAOEPDF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A6C0", Offset = "0x3A99AC0", VA = "0x183A9A6C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A6C0", Offset = "0x3A99AC0", VA = "0x183A9A6C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A997A0", Offset = "0x3A98BA0", VA = "0x183A997A0")]
	private int ABOACPKMOMH(int DIENMHDGFGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A99DD0", Offset = "0x3A991D0", VA = "0x183A99DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EC1660", Offset = "0x3EC0A60", VA = "0x183EC1660", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EC15A0", Offset = "0x3EC09A0", VA = "0x183EC15A0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EC1550", Offset = "0x3EC0950", VA = "0x183EC1550")]
	public PBOLJEIJDAH(IReadOnlyList<Internal> HAPGAOAPCEH, Func<Internal, External> LDCNDLKEBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1470", Offset = "0x3EC0870", VA = "0x183EC1470", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x33CB100", Offset = "0x33CA500", VA = "0x1833CB100", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x357AEB0", Offset = "0x357A2B0", VA = "0x18357AEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x357B0E0", Offset = "0x357A4E0", VA = "0x18357B0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x375D350", Offset = "0x375C750", VA = "0x18375D350")]
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
		[Cpp2IlInjected.Address(RVA = "0x355D3D0", Offset = "0x355C7D0", VA = "0x18355D3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x355DB90", Offset = "0x355CF90", VA = "0x18355DB90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x352E610", Offset = "0x352DA10", VA = "0x18352E610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x352F290", Offset = "0x352E690", VA = "0x18352F290", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D395B0", Offset = "0x3D389B0", VA = "0x183D395B0")]
	public NPLEEFFCEBE(BBKBOPMFMLC KAONABANHPF, [Optional] GNJMDBNAAOA GKCKIHFKHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3D38820", Offset = "0x3D37C20", VA = "0x183D38820")]
	public Task<TResult> MOCPHLKKHEN(TRequest JAFMNEFDFCM, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3D384D0", Offset = "0x3D378D0", VA = "0x183D384D0")]
	private void KEOOEAIFIIG(IKKFOAIIPIN NFDMGBNANMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D38290", Offset = "0x3D37690", VA = "0x183D38290")]
	[AsyncStateMachine(typeof(NPLEEFFCEBE<, >.AHDIFHGPLND))]
	private Task HMPLCCEIFOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D38EF0", Offset = "0x3D382F0", VA = "0x183D38EF0")]
	private IKKFOAIIPIN MPDGBNOIHML()
	{
		return default(IKKFOAIIPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D37FE0", Offset = "0x3D373E0", VA = "0x183D37FE0")]
	[AsyncStateMachine(typeof(NPLEEFFCEBE<, >.GEDLKBBOPEH))]
	private Task FHOEKACHDHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3D37DB0", Offset = "0x3D371B0", VA = "0x183D37DB0")]
	private void CHPGGMAKFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D37EA0", Offset = "0x3D372A0", VA = "0x183D37EA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F860A0", Offset = "0x2F854A0", VA = "0x182F860A0", Slot = "19")]
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
		[Cpp2IlInjected.Address(RVA = "0x30F8160", Offset = "0x30F7560", VA = "0x1830F8160", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x31117E0", Offset = "0x3110BE0", VA = "0x1831117E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3110E80", Offset = "0x3110280", VA = "0x183110E80", Slot = "11")]
	public void Add(T EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3110F60", Offset = "0x3110360", VA = "0x183110F60")]
	public bool BMPLIEBGIDJ(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3111620", Offset = "0x3110A20", VA = "0x183111620", Slot = "15")]
	public bool Remove(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x31110F0", Offset = "0x31104F0", VA = "0x1831110F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x31116C0", Offset = "0x3110AC0", VA = "0x1831116C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3111020", Offset = "0x3110420", VA = "0x183111020", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3111080", Offset = "0x3110480", VA = "0x183111080", Slot = "13")]
	public bool Contains(T EDPLJLLHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x31110C0", Offset = "0x31104C0", VA = "0x1831110C0", Slot = "14")]
	public void CopyTo(T[] NCABOBFFNFK, int EKDLGEADDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3111180", Offset = "0x3110580", VA = "0x183111180", Slot = "6")]
	public int IndexOf(T EDPLJLLHNEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x31112B0", Offset = "0x31106B0", VA = "0x1831112B0", Slot = "7")]
	public void Insert(int DIENMHDGFGP, T EDPLJLLHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3111490", Offset = "0x3110890", VA = "0x183111490", Slot = "8")]
	public void RemoveAt(int DIENMHDGFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x31116F0", Offset = "0x3110AF0", VA = "0x1831116F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2061B20", Offset = "0x2060F20", VA = "0x182061B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5570", Offset = "0x5DE4970", VA = "0x185DE5570")]
		public SerializedGuid([In] Guid GJKCBNEBGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE53D0", Offset = "0x5DE47D0", VA = "0x185DE53D0")]
		public static SerializedGuid KGCFKMMNJNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5450", Offset = "0x5DE4850", VA = "0x185DE5450")]
		public static SerializedGuid NENKMODCNKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5260", Offset = "0x5DE4660", VA = "0x185DE5260")]
		public bool BKHFNIBKMNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5540", Offset = "0x5DE4940", VA = "0x185DE5540", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE54C0", Offset = "0x5DE48C0", VA = "0x185DE54C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52F0", Offset = "0x5DE46F0", VA = "0x185DE52F0", Slot = "7")]
		public bool Equals(SerializedGuid LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5330", Offset = "0x5DE4730", VA = "0x185DE5330", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE53C0", Offset = "0x5DE47C0", VA = "0x185DE53C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE52C0", Offset = "0x5DE46C0", VA = "0x185DE52C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE2C80", Offset = "0x5DE2080", VA = "0x185DE2C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3564CB0", Offset = "0x35640B0", VA = "0x183564CB0")]
		public AJEHHNHHBCP(long NDIHPFMLNID, int ODFDOAKBDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3564D20", Offset = "0x3564120", VA = "0x183564D20")]
		public AJEHHNHHBCP(long NDIHPFMLNID, long ENACCCMAMBC, int ODFDOAKBDGN, int PNKDAAHGGFO, bool LBHJNJGMMDG, string FFEGBBHBJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3564B40", Offset = "0x3563F40", VA = "0x183564B40")]
		public int BFPBCMJLDCD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3564C90", Offset = "0x3564090", VA = "0x183564C90")]
		public int MIAEMDGGCCD(int COEDICOBHHC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3564B90", Offset = "0x3563F90", VA = "0x183564B90")]
		public double EGKOHHJDBAN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x3564BF0", Offset = "0x3563FF0", VA = "0x183564BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4586BD0", Offset = "0x4585FD0", VA = "0x184586BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x355B9C0", Offset = "0x355ADC0", VA = "0x18355B9C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D190E0", Offset = "0x3D184E0", VA = "0x183D190E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<NABJKOHEGKG> AAHFLMHFOND
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D18E50", Offset = "0x3D18250", VA = "0x183D18E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public AJEHHNHHBCP EKLLKFIAHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D190C0", Offset = "0x3D184C0", VA = "0x183D190C0")]
			[CompilerGenerated]
			get
			{
				return default(AJEHHNHHBCP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3D18E90", Offset = "0x3D18290", VA = "0x183D18E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D19110", Offset = "0x3D18510", VA = "0x183D19110")]
		internal NABJKOHEGKG(PIHHFPKOALH<TKey> HINBFABCJMK, TKey MIMFBLPNKOG, GBIKKFKHKKF BLHBFCHIDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D18CF0", Offset = "0x3D180F0", VA = "0x183D18CF0")]
		public NABJKOHEGKG BCEEDKFFGBD(TKey MIMFBLPNKOG, [Optional] GBIKKFKHKKF? DHKPEJIHICJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x24448B0", Offset = "0x2443CB0", VA = "0x1824448B0")]
		[AsyncStateMachine(typeof(BOFODIABBPI<>))]
		public Task<T> OKBEHBGIMJF<T>(TKey MIMFBLPNKOG, Func<NABJKOHEGKG, Task<T>> KMOKEKJAEFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EC0", Offset = "0x3D182C0", VA = "0x183D18EC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2061730", Offset = "0x2060B30", VA = "0x182061730", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3913870", Offset = "0x3912C70", VA = "0x183913870", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2061820", Offset = "0x2060C20", VA = "0x182061820")]
		[DebuggerHidden]
		public JNJDLDDEOBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x33C5C80", Offset = "0x33C5080", VA = "0x1833C5C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3913370", Offset = "0x3912770", VA = "0x183913370", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3913710", Offset = "0x3912B10", VA = "0x183913710")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3913820", Offset = "0x3912C20", VA = "0x183913820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3913760", Offset = "0x3912B60", VA = "0x183913760", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x33CE130", Offset = "0x33CD530", VA = "0x1833CE130", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2061730", Offset = "0x2060B30", VA = "0x182061730", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AACA90", Offset = "0x3AABE90", VA = "0x183AACA90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2061820", Offset = "0x2060C20", VA = "0x182061820")]
		[DebuggerHidden]
		public LNAMALACILP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3AACAF0", Offset = "0x3AABEF0", VA = "0x183AACAF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC120", Offset = "0x3AAB520", VA = "0x183AAC120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC8D0", Offset = "0x3AABCD0", VA = "0x183AAC8D0")]
		private void OEJNKOJDKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC0C0", Offset = "0x3AAB4C0", VA = "0x183AAC0C0")]
		private void AHMEHKPBADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3AACA40", Offset = "0x3AABE40", VA = "0x183AACA40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC930", Offset = "0x3AABD30", VA = "0x183AAC930", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, AJEHHNHHBCP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3AACA10", Offset = "0x3AABE10", VA = "0x183AACA10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F14D50", Offset = "0x3F14150", VA = "0x183F14D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3F14DB0", Offset = "0x3F141B0", VA = "0x183F14DB0")]
	public PIHHFPKOALH(TKey CBGPOPFODNO, GBIKKFKHKKF BLHBFCHIDPL, [Optional] int? ODFDOAKBDGN, [Optional][CanBeNull] Stopwatch BKOAKFJFGDI, [Optional] Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> ADKHFOPOGKA, [Optional] Action<TKey, AJEHHNHHBCP, GBIKKFKHKKF> CIHPHFNBNLO, [Optional] Action<PIHHFPKOALH<TKey>, GBIKKFKHKKF> BFLHJEHNHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3F14B60", Offset = "0x3F13F60", VA = "0x183F14B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3F14BF0", Offset = "0x3F13FF0", VA = "0x183F14BF0")]
	[IteratorStateMachine(typeof(PIHHFPKOALH<>.JNJDLDDEOBH))]
	public IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)> FONEJGJKFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3F14C80", Offset = "0x3F14080", VA = "0x183F14C80")]
	[IteratorStateMachine(typeof(PIHHFPKOALH<>.LNAMALACILP))]
	private IEnumerable<(TKey, List<TKey>, AJEHHNHHBCP)> FONEJGJKFLK(List<TKey> NLAOLIJBIMP, NABJKOHEGKG IGOKCLHKDKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3F14AE0", Offset = "0x3F13EE0", VA = "0x183F14AE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DECC40", Offset = "0x4DEC040", VA = "0x184DECC40")]
	private static string KBKFKGAJEKE(TKey MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4DECDD0", Offset = "0x4DEC1D0", VA = "0x184DECDD0", Slot = "4")]
	public override string KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4DECC80", Offset = "0x4DEC080", VA = "0x184DECC80")]
	public string KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK, [NotNull] MMDLIGCELFJ JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLEHPPLIHNO(PIHHFPKOALH<TKey> HINBFABCJMK, [NotNull] MMDLIGCELFJ JAHJPPENOFA);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3528C10", Offset = "0x3528010", VA = "0x183528C10")]
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
	[Cpp2IlInjected.Address(RVA = "0x36CAC20", Offset = "0x36CA020", VA = "0x1836CAC20")]
	private static string KBKFKGAJEKE(TKey MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x36CB470", Offset = "0x36CA870", VA = "0x1836CB470")]
	public IBOFKOIHLNG(string GNEGIMHONMB = "F2", double JPMAGDJKCOH = double.MaxValue, bool OONMKCCDGBF = false, int JMLDPPPGCHC = int.MaxValue, [Optional] ISet<string> HCKCHPMANHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x36CAC60", Offset = "0x36CA060", VA = "0x1836CAC60", Slot = "4")]
	public override Dictionary<string, string> KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x36CA900", Offset = "0x36C9D00", VA = "0x1836CA900")]
	private bool AOEKIAGJOKN(string MNNOIAJEFIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x36CAD20", Offset = "0x36CA120", VA = "0x1836CAD20")]
	public Dictionary<string, string> KJECHOGEIPH(PIHHFPKOALH<TKey> HINBFABCJMK, GMJMLBCCDIN JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x36CA9E0", Offset = "0x36C9DE0", VA = "0x1836CA9E0")]
	private string GJNFIHNHBGL(StringBuilder GLLDNDEBOFD, List<TKey> PHAIBMOKGCF, GMJMLBCCDIN JAHJPPENOFA, bool BFMIILBCCNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x36CB310", Offset = "0x36CA710", VA = "0x1836CB310")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D23C60", Offset = "0x3D23060", VA = "0x183D23C60")]
	private NFDBKGOJFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3D22C00", Offset = "0x3D22000", VA = "0x183D22C00", Slot = "5")]
	protected override string BLEHPPLIHNO(PIHHFPKOALH<TKey> HINBFABCJMK, MMDLIGCELFJ JAHJPPENOFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3D23A30", Offset = "0x3D22E30", VA = "0x183D23A30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DE3410", Offset = "0x5DE2810", VA = "0x185DE3410")]
		internal void KDAMAHIBEAK(PIHHFPKOALH<string> timer, GBIKKFKHKKF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B60", Offset = "0x5DE2F60", VA = "0x185DE3B60")]
	public LIMGENJPIFA(GBIKKFKHKKF BLHBFCHIDPL, [Optional] string DFGHFHNEBFB, [Optional] int? ODFDOAKBDGN, [Optional] Stopwatch BKOAKFJFGDI, [Optional] Action<string, AJEHHNHHBCP, GBIKKFKHKKF> ADKHFOPOGKA, [Optional] Action<string, AJEHHNHHBCP, GBIKKFKHKKF> CIHPHFNBNLO, [Optional] Action<LIMGENJPIFA, GBIKKFKHKKF> BFLHJEHNHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3AA0", Offset = "0x5DE2EA0", VA = "0x185DE3AA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DE0C10", Offset = "0x5DE0010", VA = "0x185DE0C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x1C9E620", Offset = "0x1C9DA20", VA = "0x181C9E620", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0D10", Offset = "0x5DE0110", VA = "0x185DE0D10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DE3CB0", Offset = "0x5DE30B0", VA = "0x185DE3CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE33D0", Offset = "0x5DE27D0", VA = "0x185DE33D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3EC1A20", Offset = "0x3EC0E20", VA = "0x183EC1A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x3102860", Offset = "0x3101C60", VA = "0x183102860")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DE0B10", Offset = "0x5DDFF10", VA = "0x185DE0B10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0AB0", Offset = "0x5DDFEB0", VA = "0x185DE0AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B60", Offset = "0x5DDFF60", VA = "0x185DE0B60")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F76F90", Offset = "0x2F76390", VA = "0x182F76F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x2F77260", Offset = "0x2F76660", VA = "0x182F77260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3912B80", Offset = "0x3911F80", VA = "0x183912B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x857210", Offset = "0x856610", VA = "0x180857210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD970", Offset = "0x4DCCD70", VA = "0x184DCD970")]
	protected DGBEBIFCLJD(TTask BPGIJHHDFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD730", Offset = "0x4DCCB30", VA = "0x184DCD730", Slot = "1")]
	~DGBEBIFCLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3ACF670", Offset = "0x3ACEA70", VA = "0x183ACF670", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4DCD450", Offset = "0x4DCC850", VA = "0x184DCD450")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE2E40", Offset = "0x5DE2240", VA = "0x185DE2E40")]
	[NotNull]
	public static byte[] KKMPHFMPHEM(this OABNEOHEDGO CDNKMKNCNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2DD0", Offset = "0x5DE21D0", VA = "0x185DE2DD0")]
	[NotNull]
	public static byte[] KKMPHFMPHEM(this OABNEOHEDGO CDNKMKNCNIL, HashAlgorithmName DECGFNENDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3170", Offset = "0x5DE2570", VA = "0x185DE3170")]
	public static bool PHNJIEMKGDG([CanBeNull] this OABNEOHEDGO CDNKMKNCNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2FD0", Offset = "0x5DE23D0", VA = "0x185DE2FD0")]
	public static bool PHNJIEMKGDG([CanBeNull] this OABNEOHEDGO CDNKMKNCNIL, [Out] string HCMLCAPJMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2EB0", Offset = "0x5DE22B0", VA = "0x185DE2EB0")]
	private static bool OJNGLKLDPCC([NotNull] OABNEOHEDGO CDNKMKNCNIL, [Out][CanBeNull] byte[] JONEGCBPEPF, [Out][CanBeNull] byte[] KGNGFHDPFDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ABFPBDHIAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0870", Offset = "0x5DDFC70", VA = "0x185DE0870")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE1360", Offset = "0x5DE0760", VA = "0x185DE1360")]
	public static void JNEPKIDMKHN(this IncrementalHash GOEPOJAJOLN, [CanBeNull] GameObject PLLPJJEOIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AAA0", Offset = "0x2B39EA0", VA = "0x182B3AAA0")]
	public static void JNEPKIDMKHN<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] T AIKEEEBGAIM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2B3AB60", Offset = "0x2B39F60", VA = "0x182B3AB60")]
	public static void MMNACAOAOHH<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] T LLJIKPBOOGA) where T : PGFNKMHLAHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A580", Offset = "0x2B39980", VA = "0x182B3A580")]
	public static void INKMMNBPMMD<T>(this IncrementalHash GOEPOJAJOLN, [CanBeNull] IList<T> LJDDEBCNPPB) where T : PGFNKMHLAHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0DC0", Offset = "0x5DE01C0", VA = "0x185DE0DC0")]
	private static bool DJPKAACJKAJ([CanBeNull] PGFNKMHLAHB LLJIKPBOOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE15B0", Offset = "0x5DE09B0", VA = "0x185DE15B0")]
	public static void NLDPBLIKNCL(this IncrementalHash LHOFGACBHAN, [CanBeNull] string KFFAMCKAPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1020", Offset = "0x5DE0420", VA = "0x185DE1020")]
	public static void FIMODBKFEBC(this IncrementalHash LHOFGACBHAN, long BKKMLHJABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1610", Offset = "0x5DE0A10", VA = "0x185DE1610")]
	public static void OKHACPGGGOG(this IncrementalHash LHOFGACBHAN, int DGEKHHMJPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0E50", Offset = "0x5DE0250", VA = "0x185DE0E50")]
	public static void DMAKOEAGDAB(this IncrementalHash LHOFGACBHAN, short ABIOHIDKEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1440", Offset = "0x5DE0840", VA = "0x185DE1440")]
	public static void LEFOEFGOBBC(this IncrementalHash LHOFGACBHAN, byte PJEKMLDFONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE11F0", Offset = "0x5DE05F0", VA = "0x185DE11F0")]
	public static void GCFIOFODILD(this IncrementalHash LHOFGACBHAN, bool MCHCOEMEBCO, bool KMGLCJPGDNF = false, bool DFIMMHLHDBP = false, bool JAFHIGGAGJP = false, bool AFAJFMGOAJP = false, bool FPHAKFALFGL = false, bool KJMADBFLNNF = false, bool NCHAKNJIDAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2B3ABF0", Offset = "0x2B39FF0", VA = "0x182B3ABF0")]
	public static void OEOOJGKNJJO<T>(this IncrementalHash LHOFGACBHAN, T PNHGPNJINIO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1550", Offset = "0x5DE0950", VA = "0x185DE1550")]
	public static void NIBNHJHGECI(this IncrementalHash LHOFGACBHAN, float FCLANNFCLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1970", Offset = "0x5DE0D70", VA = "0x185DE1970")]
	public static void PNLHHBEJIMM(this IncrementalHash LHOFGACBHAN, ulong IDPADHCHPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D60", Offset = "0x5DE0160", VA = "0x185DE0D60")]
	public static void BAMHBCDFJHC(this IncrementalHash LHOFGACBHAN, uint AMGNGEEDFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1910", Offset = "0x5DE0D10", VA = "0x185DE1910")]
	public static void PENLLLLDPEF(this IncrementalHash LHOFGACBHAN, ushort AIBGEDELNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DE17E0", Offset = "0x5DE0BE0", VA = "0x185DE17E0")]
	public static void OPHLIFDAPEP(this IncrementalHash LHOFGACBHAN, Vector3 IJCHCDMKKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class FCCPJJHBLIA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2CF0", Offset = "0x5DE20F0", VA = "0x185DE2CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB65D40", Offset = "0xB65140", VA = "0x180B65D40")]
		public KINNJBJCKNK(int CLNHOKCOILM, TClaimant KKBKFKENENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39C4430", Offset = "0x39C3830", VA = "0x1839C4430")]
		public bool LJGAIMKHHDK([In] KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x39C4490", Offset = "0x39C3890", VA = "0x1839C4490")]
		public bool NKOIPBLPPCH([In] KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39C4420", Offset = "0x39C3820", VA = "0x1839C4420", Slot = "4")]
		public int CompareTo(KINNJBJCKNK LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39C44A0", Offset = "0x39C38A0", VA = "0x1839C44A0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ECA50", Offset = "0x8EBE50", VA = "0x1808ECA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x375F340", Offset = "0x375E740", VA = "0x18375F340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x375F500", Offset = "0x375E900", VA = "0x18375F500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x375F420", Offset = "0x375E820", VA = "0x18375F420", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x33C70F0", Offset = "0x33C64F0", VA = "0x1833C70F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3740C30", Offset = "0x3740030", VA = "0x183740C30")]
	public IEJEJGDELAP(JIBPNPAJKJB LEIDKMNBCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x373FAD0", Offset = "0x373EED0", VA = "0x18373FAD0")]
	public void EKHCMEDKOFM(TNode JKACDAAJHJD, TNode IPAKJOEMEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x373F4A0", Offset = "0x373E8A0", VA = "0x18373F4A0")]
	public void DHHKOELGLPP(TClaimant KKBKFKENENL, TNode BOJKLANAFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x373F5C0", Offset = "0x373E9C0", VA = "0x18373F5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3740210", Offset = "0x373F610", VA = "0x183740210")]
	private void KEGBEPIOECB(TClaimant KKBKFKENENL, TNode IDJMEHAFBPL, TNode BOJKLANAFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x37401A0", Offset = "0x373F5A0", VA = "0x1837401A0")]
	private int KDKCFAJFAHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x373F790", Offset = "0x373EB90", VA = "0x18373F790")]
	private void EIPBOLANKKG(TClaimant KKBKFKENENL, TNode NJKKONOAGGC, TNode NJFOAHFANFG, int DBHGLDMHAKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x373F410", Offset = "0x373E810", VA = "0x18373F410")]
	private void BIACNIBNJJD(KINNJBJCKNK ACCHIOJKLCL, EKFAHKPLNEO LAIGFFBGCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x373FB60", Offset = "0x373EF60", VA = "0x18373FB60")]
	private void GEOIEOKAGIE(TClaimant KKBKFKENENL, TNode NJKKONOAGGC, TNode NJFOAHFANFG, int DBHGLDMHAKM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3740090", Offset = "0x373F490", VA = "0x183740090")]
	private void JOIOLGFGILC(KINNJBJCKNK ACCHIOJKLCL, TNode JKACDAAJHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37406E0", Offset = "0x373FAE0", VA = "0x1837406E0")]
	private void NFCGACHLGHK(KINNJBJCKNK ACCHIOJKLCL, EKFAHKPLNEO LAIGFFBGCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x37407D0", Offset = "0x373FBD0", VA = "0x1837407D0")]
	private void NOPKAAAIBFP(EKFAHKPLNEO LAIGFFBGCFN, bool LCAANNMOCFI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x37403A0", Offset = "0x373F7A0", VA = "0x1837403A0")]
	private void LIMBFKMIPIA(EKFAHKPLNEO LAIGFFBGCFN, TNode IPAKJOEMEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x373FE40", Offset = "0x373F240", VA = "0x18373FE40")]
	[IteratorStateMachine(typeof(IEJEJGDELAP<, >.IMJCCPIJBAN))]
	private IEnumerable<TNode> IAMAJHKCEAM(TNode NJKKONOAGGC, TNode NJFOAHFANFG, bool OHACBHBOFOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x37402B0", Offset = "0x373F6B0", VA = "0x1837402B0")]
	private EKFAHKPLNEO KHHNJHKLKOF(TNode JKACDAAJHJD, TNode ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x373FF20", Offset = "0x373F320", VA = "0x18373FF20")]
	private EKFAHKPLNEO INFIKNBCFOF(TNode JKACDAAJHJD, TNode ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3740900", Offset = "0x373FD00", VA = "0x183740900")]
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
			[Cpp2IlInjected.Address(RVA = "0x3118570", Offset = "0x3117970", VA = "0x183118570", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public OIFBAPJHDGG ADHFGEBEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4C20", Offset = "0x3DF4020", VA = "0x183DF4C20", Slot = "4")]
			get
			{
				return default(OIFBAPJHDGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4BE0", Offset = "0x3DF3FE0", VA = "0x183DF4BE0")]
		public ODHJBIFCOJP(FNAEHDJEJDN<T> HPOCFKLBOCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DF4B60", Offset = "0x3DF3F60", VA = "0x183DF4B60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3167CF0", Offset = "0x31670F0", VA = "0x183167CF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CB10", Offset = "0x1B0BF10", VA = "0x181B0CB10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F860A0", Offset = "0x2F854A0", VA = "0x182F860A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3476900", Offset = "0x3475D00", VA = "0x183476900")]
	public FNAEHDJEJDN(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x34769E0", Offset = "0x3475DE0", VA = "0x1834769E0")]
	public FNAEHDJEJDN(OIFBAPJHDGG[] CECICBAAHNG, bool AGLIDPLMKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x34767F0", Offset = "0x3475BF0", VA = "0x1834767F0")]
	public int MMMHPHPCHFM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3476560", Offset = "0x3475960", VA = "0x183476560")]
	private int GLOIIAJKNHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x34767C0", Offset = "0x3475BC0", VA = "0x1834767C0", Slot = "6")]
	protected virtual uint IDBBEIKPIDH(uint LHOFGACBHAN, T NMENOOMOOJP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3476510", Offset = "0x3475910", VA = "0x183476510")]
	public bool CMLPBOHMEKB(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x34761F0", Offset = "0x34755F0", VA = "0x1834761F0")]
	public int AEODHHCKODN(T NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3476750", Offset = "0x3475B50", VA = "0x183476750")]
	public T HOPALDFECFK(int DIENMHDGFGP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3476260", Offset = "0x3475660", VA = "0x183476260")]
	public bool BMPLIEBGIDJ(T NMENOOMOOJP, bool OGKAOMLELGH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x34762B0", Offset = "0x34756B0", VA = "0x1834762B0")]
	public bool BMPLIEBGIDJ(T NMENOOMOOJP, int DIENMHDGFGP, bool OGKAOMLELGH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x34764C0", Offset = "0x34758C0", VA = "0x1834764C0")]
	private int CFHEDIAOFCJ(int HHKMAFFMIKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3476880", Offset = "0x3475C80", VA = "0x183476880", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3476880", Offset = "0x3475C80", VA = "0x183476880", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30E4600", Offset = "0x30E3A00", VA = "0x1830E4600")]
	public static ECCHAMMCFJL<T> OEJOLPDFAHH(int EKJEIMGCNCB = 0, int FCFHBPGBMGE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x30E4880", Offset = "0x30E3C80", VA = "0x1830E4880")]
	public ECCHAMMCFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x30E46E0", Offset = "0x30E3AE0", VA = "0x1830E46E0")]
	public ECCHAMMCFJL(int EKJEIMGCNCB, int FCFHBPGBMGE = int.MaxValue, bool NFKBGKEECNB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x30E4050", Offset = "0x30E3450", VA = "0x1830E4050")]
	public T DANMHHJAMLP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x30E4310", Offset = "0x30E3710", VA = "0x1830E4310")]
	public void FHBGBJJCKEM(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x30E3F70", Offset = "0x30E3370", VA = "0x1830E3F70")]
	private void CPLJGNJPEDP(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x30E43E0", Offset = "0x30E37E0", VA = "0x1830E43E0")]
	private void MEONELBAMPJ(T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x30E41D0", Offset = "0x30E35D0", VA = "0x1830E41D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x30E4400", Offset = "0x30E3800", VA = "0x1830E4400")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D2F550", Offset = "0x3D2E950", VA = "0x183D2F550")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F4E0", Offset = "0x3D2E8E0", VA = "0x183D2F4E0")]
	public bool DADDPKGOCCP(int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F830", Offset = "0x3D2EC30", VA = "0x183D2F830")]
	public T KAHDAMILILK(int OEPKFEKLEAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FB30", Offset = "0x3D2EF30", VA = "0x183D2FB30")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F490", Offset = "0x3D2E890", VA = "0x183D2F490")]
	public bool AFCHMNEGHNL(int CLNHOKCOILM, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FBD0", Offset = "0x3D2EFD0", VA = "0x183D2FBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F860A0", Offset = "0x2F854A0", VA = "0x182F860A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x310A0B0", Offset = "0x31094B0", VA = "0x18310A0B0")]
	public bool CCJBPIIMLHG(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x310A010", Offset = "0x3109410", VA = "0x18310A010")]
	public void BKKEPFPDOJH(T NMENOOMOOJP, int CLNHOKCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x310A230", Offset = "0x3109630", VA = "0x18310A230")]
	public bool HBMDGHADMGB(T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x310A4E0", Offset = "0x31098E0", VA = "0x18310A4E0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x3109F90", Offset = "0x3109390", VA = "0x183109F90")]
	public T BELKAAGPBIA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x310A380", Offset = "0x3109780", VA = "0x18310A380")]
	private void IACEPJMFGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x310A540", Offset = "0x3109940", VA = "0x18310A540")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DE3F60", Offset = "0x5DE3360", VA = "0x185DE3F60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4230", Offset = "0x5DE3630", VA = "0x185DE4230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4140", Offset = "0x5DE3540", VA = "0x185DE4140")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x5DE3EB0", Offset = "0x5DE32B0", VA = "0x185DE3EB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4180", Offset = "0x5DE3580", VA = "0x185DE4180")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5DE4090", Offset = "0x5DE3490", VA = "0x185DE4090")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3E20", Offset = "0x5DE3220", VA = "0x185DE3E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x40C7CF0", Offset = "0x40C70F0", VA = "0x1840C7CF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF6CF0", Offset = "0xAF60F0", VA = "0x180AF6CF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xDC4940", Offset = "0xDC3D40", VA = "0x180DC4940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private Vector2 ELGANODCOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xDF9AB0", Offset = "0xDF8EB0", VA = "0x180DF9AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector2 ODDJPPGHBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1E10", Offset = "0x5DE1210", VA = "0x185DE1E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE27F0", Offset = "0x5DE1BF0", VA = "0x185DE27F0")]
	public DMMJDACBMDG(Bounds KNCHPBNAJOJ, Vector2[] INFNFIFOEEN, int INABNMDGFEA, byte HHKMAFFMIKG, float LCLMMFOGGGC = 0f, [Optional] ECCHAMMCFJL<LHNHDKNCDIE> BHIIKCLPCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2110", Offset = "0x5DE1510", VA = "0x185DE2110")]
	public LHNHDKNCDIE INMOAIELNDI(byte DIENMHDGFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2720", Offset = "0x5DE1B20", VA = "0x185DE2720")]
	public void PPDONOOJPJJ(Vector3 JCADPOBEOPO, float ICGNBGEOOMP, float CNBGCPJPKOF, List<byte> GMEEFBGIPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1B164E0", Offset = "0x1B158E0", VA = "0x181B164E0")]
	public void FEFPNGPJNJL(LHNHDKNCDIE.OMAGFBCICME EJDEBNAENPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1D20", Offset = "0x5DE1120", VA = "0x185DE1D20")]
	public static int BGPFONJLDEF(Vector2[] INFNFIFOEEN, int INABNMDGFEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2520", Offset = "0x5DE1920", VA = "0x185DE2520")]
	private LHNHDKNCDIE NOBJHCCLPPF(byte DIENMHDGFGP, LHNHDKNCDIE.MLLCEBDMCJJ CDDILJNOPLC, LHNHDKNCDIE ECLIMLPEPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2170", Offset = "0x5DE1570", VA = "0x185DE2170")]
	private void KBKPAEEOOCH(LHNHDKNCDIE ECLIMLPEPIL, Vector2[] INFNFIFOEEN, int BPJEPAGEEOD, int BBDIBFOKENG, int GIPNPBHFJOC, int OEHPJFKJCHG, float LCLMMFOGGGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E90", Offset = "0x5DE1290", VA = "0x185DE1E90")]
	private void FNKIOBDGHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E30", Offset = "0x5DE1230", VA = "0x185DE1E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE20B0", Offset = "0x5DE14B0", VA = "0x185DE20B0", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DE3A80", Offset = "0x5DE2E80", VA = "0x185DE3A80")]
	public LHNHDKNCDIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3700", Offset = "0x5DE2B00", VA = "0x185DE3700")]
	public void NPCHCHIGNHH(LHNHDKNCDIE AHNPOOGMEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0")]
	public void FEFPNGPJNJL(int NGHJAKMBFKH, OMAGFBCICME EJDEBNAENPJ, int LHCNAECDNAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3820", Offset = "0x5DE2C20", VA = "0x185DE3820")]
	public void PPDONOOJPJJ(List<byte> GMEEFBGIPNM, Vector3 JCADPOBEOPO, float ICGNBGEOOMP, float CNBGCPJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3610", Offset = "0x5DE2A10", VA = "0x185DE3610")]
	public bool CBPHJCJJMBK(Vector3 GGCAPAPOAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE36D0", Offset = "0x5DE2AD0", VA = "0x185DE36D0")]
	public bool HOJNNFHDMFG(Vector3 GGCAPAPOAOA, float KNKOJNPJHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3640", Offset = "0x5DE2A40", VA = "0x185DE3640")]
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
			[Cpp2IlInjected.Address(RVA = "0x35DBE90", Offset = "0x35DB290", VA = "0x1835DBE90")]
			public HCKJMJGCJDO(List<Component> HAPGAOAPCEH, bool HBIHNGOPJAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x35DBD50", Offset = "0x35DB150", VA = "0x1835DBD50")]
			public PLLIJNPEAOI<T> HMFAGAOEPDF()
			{
				return default(PLLIJNPEAOI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x35DBDC0", Offset = "0x35DB1C0", VA = "0x1835DBDC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x35DBDC0", Offset = "0x35DB1C0", VA = "0x1835DBDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F1F6B0", Offset = "0x3F1EAB0", VA = "0x183F1F6B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0x3F1F640", Offset = "0x3F1EA40", VA = "0x183F1F640", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x3F1F680", Offset = "0x3F1EA80", VA = "0x183F1F680")]
			public PLLIJNPEAOI(List<Component> HAPGAOAPCEH, bool HBIHNGOPJAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F1F580", Offset = "0x3F1E980", VA = "0x183F1F580", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x3F1F590", Offset = "0x3F1E990", VA = "0x183F1F590", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x3159760", Offset = "0x3158B60", VA = "0x183159760", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DE57E0", Offset = "0x5DE4BE0", VA = "0x185DE57E0")]
		private void GJHPIDDJMKM(GameObject IGCNBCNNLGN, bool EHGFADNFMAI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5620", Offset = "0x5DE4A20", VA = "0x185DE5620")]
		public static void GJHPIDDJMKM(GameObject IGCNBCNNLGN, ToolHierarchyCache MNODIPHKNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x27AAD80", Offset = "0x27AA180", VA = "0x1827AAD80")]
		public void HGOLOCOCCLH<T>(Action<T> ONCLGAMIHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x27AAFA0", Offset = "0x27AA3A0", VA = "0x1827AAFA0")]
		public T JMEHLBFCEEG<T>(bool HBIHNGOPJAM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x27AB010", Offset = "0x27AA410", VA = "0x1827AB010")]
		public HCKJMJGCJDO<T> PMANAFPKGKF<T>(bool HBIHNGOPJAM = false) where T : class
		{
			return default(HCKJMJGCJDO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE59C0", Offset = "0x5DE4DC0", VA = "0x185DE59C0")]
		public List<Component> KFIABODLNPM(Type LFLAEPCPMDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE55A0", Offset = "0x5DE49A0", VA = "0x185DE55A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache OPHKAEHAFCM, ToolHierarchyCache CLGLFIMLHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5950", Offset = "0x5DE4D50", VA = "0x185DE5950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x34388C0", Offset = "0x3437CC0", VA = "0x1834388C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T JGBDDJFAKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C98DB0", Offset = "0x3C981B0", VA = "0x183C98DB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T AFHOCKMBBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C98CE0", Offset = "0x3C980E0", VA = "0x183C98CE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T MPNODCAOJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C992F0", Offset = "0x3C986F0", VA = "0x183C992F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x3C99370", Offset = "0x3C98770", VA = "0x183C99370")]
	public MBJLLIEHDNG(int EKJEIMGCNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C98F20", Offset = "0x3C98320", VA = "0x183C98F20")]
	public void BKKEPFPDOJH(T DHPAHNEEIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C99250", Offset = "0x3C98650", VA = "0x183C99250")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C99170", Offset = "0x3C98570", VA = "0x183C99170")]
	public void FHAADKGIEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C99110", Offset = "0x3C98510", VA = "0x183C99110")]
	public void FADADAHOEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C99240", Offset = "0x3C98640", VA = "0x183C99240")]
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
		[Cpp2IlInjected.Address(RVA = "0xEE1000", Offset = "0xEE0400", VA = "0x180EE1000", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x343B0A0", Offset = "0x343A4A0", VA = "0x18343B0A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool OEJIBJJBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x343B180", Offset = "0x343A580", VA = "0x18343B180")]
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
	[Cpp2IlInjected.Address(RVA = "0x343B460", Offset = "0x343A860", VA = "0x18343B460")]
	public bool KAFAPEAADGC(T NMENOOMOOJP, object NOEAHPPKHNC, int CLNHOKCOILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x343B0F0", Offset = "0x343A4F0", VA = "0x18343B0F0")]
	public bool DADDPKGOCCP(object NOEAHPPKHNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x343ADB0", Offset = "0x343A1B0", VA = "0x18343ADB0")]
	public bool AFCHMNEGHNL(object NOEAHPPKHNC, [Out] T NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x343B1D0", Offset = "0x343A5D0", VA = "0x18343B1D0")]
	public void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x343C700", Offset = "0x343BB00", VA = "0x18343C700")]
	private bool KLIPCFOONOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x343E520", Offset = "0x343D920", VA = "0x18343E520")]
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
