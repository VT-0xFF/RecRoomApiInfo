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
public class MNLGIADCBEC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E2AC0", Offset = "0x6E1EC0", VA = "0x1806E2AC0")]
	public MNLGIADCBEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F920", Offset = "0x4D1ED20", VA = "0x184D1F920")]
	public byte[] LIPNFHGKCGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void EINEPDGHPGH(IncrementalHash HOIJMIKCIJF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD27920", Offset = "0xD26D20", VA = "0x180D27920")]
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
	[PJBJGJOEOBG]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[PJBJGJOEOBG]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4D22AA0", Offset = "0x4D21EA0", VA = "0x184D22AA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D22A60", Offset = "0x4D21E60", VA = "0x184D22A60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D22AE0", Offset = "0x4D21EE0", VA = "0x184D22AE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D22CF0", Offset = "0x4D220F0", VA = "0x184D22CF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D22C60", Offset = "0x4D22060", VA = "0x184D22C60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xFF9320", Offset = "0xFF8720", VA = "0x180FF9320")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEA0900", Offset = "0xE9FD00", VA = "0x180EA0900")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D22A20", Offset = "0x4D21E20", VA = "0x184D22A20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D22BD0", Offset = "0x4D21FD0", VA = "0x184D22BD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D22450", Offset = "0x4D21850", VA = "0x184D22450")]
	public void CopyBounds(SavedExtents OGCBGOIPCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D22990", Offset = "0x4D21D90", VA = "0x184D22990")]
	public void SetLocalSpaceBounds(Bounds DJAAMGHKMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88C130", Offset = "0x88B530", VA = "0x18088C130")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D22980", Offset = "0x4D21D80", VA = "0x184D22980")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D22480", Offset = "0x4D21880", VA = "0x184D22480")]
	private void FFNJKAAFFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D22750", Offset = "0x4D21B50", VA = "0x184D22750")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D21E90", Offset = "0x4D21290", VA = "0x184D21E90")]
	public static void CalculateLocalBoundsFor(GameObject OPNEJBACONM, out Bounds DJAAMGHKMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D22690", Offset = "0x4D21A90", VA = "0x184D22690")]
	private static void NMBMIHFBDLB(Bounds FFOHEAHJJEI, Color DMIPEKEOIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D229B0", Offset = "0x4D21DB0", VA = "0x184D229B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x552EE0", Offset = "0x5522E0", VA = "0x180552EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "4")]
	public virtual void NNEGALMHLLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
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
	[MNLGIADCBEC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2938790", Offset = "0x2937B90", VA = "0x182938790", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29382D0", Offset = "0x29376D0", VA = "0x1829382D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2938D90", Offset = "0x2938190", VA = "0x182938D90")]
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
	private sealed class FBNLOJCEKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public FBNLOJCEKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x393CDF0", Offset = "0x393C1F0", VA = "0x18393CDF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[MNLGIADCBEC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x393CB40", Offset = "0x393BF40", VA = "0x18393CB40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x393CB70", Offset = "0x393BF70", VA = "0x18393CB70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x393CA90", Offset = "0x393BE90", VA = "0x18393CA90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public TVal this[TKey KACNOLACOBJ]
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x393CAC0", Offset = "0x393BEC0", VA = "0x18393CAC0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x393C990", Offset = "0x393BD90", VA = "0x18393C990", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x393C1F0", Offset = "0x393B5F0", VA = "0x18393C1F0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x393BB60", Offset = "0x393AF60", VA = "0x18393BB60", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x393B760", Offset = "0x393AB60", VA = "0x18393B760", Slot = "14")]
	protected virtual string HPIFMMIFEKA(TKeyVal GNEKBOJHNBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3658370", Offset = "0x3657770", VA = "0x183658370", Slot = "4")]
	public bool ContainsKey(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x393C880", Offset = "0x393BC80", VA = "0x18393C880", Slot = "5")]
	public bool TryGetValue(TKey KACNOLACOBJ, out TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x393B6D0", Offset = "0x393AAD0", VA = "0x18393B6D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x393B6D0", Offset = "0x393AAD0", VA = "0x18393B6D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x393C8B0", Offset = "0x393BCB0", VA = "0x18393C8B0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OPIIFFKICFB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JLKIPKMJBEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public JLKIPKMJBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7EC0", Offset = "0x3CB72C0", VA = "0x183CB7EC0")]
		internal bool <GetSamples>b__0(global::AFFFILIJAIM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly float OOJJHBOBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly float BDLFADCBFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private List<global::AFFFILIJAIM<float, T>> JAGHKCNHPEI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CNCPAADKLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8070", Offset = "0x3CC7470", VA = "0x183CC8070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8B80", Offset = "0x3CC7F80", VA = "0x183CC8B80")]
	public OPIIFFKICFB(float FGAEPLKDBIO, float ACPADLJMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3CC82B0", Offset = "0x3CC76B0", VA = "0x183CC82B0")]
	public bool HNECIHFJGHP(float BHPIEGPPAOH, T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3CC80F0", Offset = "0x3CC74F0", VA = "0x183CC80F0")]
	public int HIJIEHALDPE(float BHPIEGPPAOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3CC84D0", Offset = "0x3CC78D0", VA = "0x183CC84D0")]
	public IEnumerable<T> KEOLBAHKKIN(float BHPIEGPPAOH, [Optional] float? OPKHPCBHOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8B50", Offset = "0x3CC7F50", VA = "0x183CC8B50")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8410", Offset = "0x3CC7810", VA = "0x183CC8410")]
	private void IONABLEMKMF(float BHPIEGPPAOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class OFHDPCBCIHC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JAKINFCEION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T IKGDHNEELOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float IBDHLDLDGPL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static float JKLBEONPGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<T> JHPGLLAKKIL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int CJEILOPECBO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JAKINFCEION[] INALBAMOJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int IBIKKDJEDCG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float PFDHHOGBMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x128F9D0", Offset = "0x128EDD0", VA = "0x18128F9D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x125A710", Offset = "0x1259B10", VA = "0x18125A710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEC40", Offset = "0x3FCE040", VA = "0x183FCEC40")]
	public OFHDPCBCIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3FCEB60", Offset = "0x3FCDF60", VA = "0x183FCEB60")]
	public OFHDPCBCIHC(int IJHNFJCHOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3FCDAE0", Offset = "0x3FCCEE0", VA = "0x183FCDAE0")]
	public void KCLLGEJMGAB(float BHPIEGPPAOH, T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE720", Offset = "0x3FCDB20", VA = "0x183FCE720")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3FCDF80", Offset = "0x3FCD380", VA = "0x183FCDF80")]
	public bool KMNCLPOOJDM(float JCJELBAPEMM, float JKJNIFDBJFH, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD630", Offset = "0x3FCCA30", VA = "0x183FCD630")]
	public bool HJGEKGOOIFF(float JCJELBAPEMM, float JKJNIFDBJFH, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE5D0", Offset = "0x3FCD9D0", VA = "0x183FCE5D0")]
	public void MLIAFMALHOE(float JCJELBAPEMM, float JKJNIFDBJFH, List<T> KCNEECJJIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCDAB0", Offset = "0x3FCCEB0", VA = "0x183FCDAB0")]
	private int ICBLPPBGHDK(int HKGICFHPEDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCE2F0", Offset = "0x3FCD6F0", VA = "0x183FCE2F0")]
	private void MJMNOMNECDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NGHIMBOPOFL();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LGEFONHOAMM(T NCCAGEJPKHF, T LIGCOAKACCN, float HFMCMEGOMAH);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DKEPLBENFED(T MGNFAPLJAOB, float HFMCMEGOMAH);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T CFJINDJMMBK(T NCCAGEJPKHF, T LIGCOAKACCN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T JMOILDJOKNH(T NCCAGEJPKHF, T LIGCOAKACCN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HGJECJBAKGK : global::OFHDPCBCIHC<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F400", Offset = "0x4D1E800", VA = "0x184D1F400", Slot = "4")]
	protected override Vector3 NGHIMBOPOFL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F340", Offset = "0x4D1E740", VA = "0x184D1F340", Slot = "5")]
	protected override Vector3 LGEFONHOAMM(Vector3 NCCAGEJPKHF, Vector3 LIGCOAKACCN, float HFMCMEGOMAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F230", Offset = "0x4D1E630", VA = "0x184D1F230", Slot = "6")]
	protected override Vector3 DKEPLBENFED(Vector3 MGNFAPLJAOB, float HFMCMEGOMAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F180", Offset = "0x4D1E580", VA = "0x184D1F180", Slot = "7")]
	protected override Vector3 CFJINDJMMBK(Vector3 NCCAGEJPKHF, Vector3 LIGCOAKACCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F2D0", Offset = "0x4D1E6D0", VA = "0x184D1F2D0", Slot = "8")]
	protected override Vector3 JMOILDJOKNH(Vector3 NCCAGEJPKHF, Vector3 LIGCOAKACCN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F470", Offset = "0x4D1E870", VA = "0x184D1F470")]
	public HGJECJBAKGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MHOMAIGFBMF : global::OFHDPCBCIHC<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D211C0", Offset = "0x4D205C0", VA = "0x184D211C0")]
	public MHOMAIGFBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D21220", Offset = "0x4D20620", VA = "0x184D21220")]
	public MHOMAIGFBMF(int IJHNFJCHOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xEA74C0", Offset = "0xEA68C0", VA = "0x180EA74C0", Slot = "4")]
	protected override float NGHIMBOPOFL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D21140", Offset = "0x4D20540", VA = "0x184D21140", Slot = "5")]
	protected override float LGEFONHOAMM(float NCCAGEJPKHF, float LIGCOAKACCN, float HFMCMEGOMAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB820", Offset = "0x3DBAC20", VA = "0x183DBB820", Slot = "6")]
	protected override float DKEPLBENFED(float MGNFAPLJAOB, float HFMCMEGOMAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x240A630", Offset = "0x2409A30", VA = "0x18240A630", Slot = "7")]
	protected override float CFJINDJMMBK(float NCCAGEJPKHF, float LIGCOAKACCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4D21130", Offset = "0x4D20530", VA = "0x184D21130", Slot = "8")]
	protected override float JMOILDJOKNH(float NCCAGEJPKHF, float LIGCOAKACCN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class INEHNIGMLGA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7470", Offset = "0x1FC6870", VA = "0x181FC7470")]
	public static global::JKAMCIKKICB<T1> DDAMABLPPOO<T1>(T1 OLIJOICAHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x208E180", Offset = "0x208D580", VA = "0x18208E180")]
	public static global::AFFFILIJAIM<T1, T2> DDAMABLPPOO<T1, T2>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1FC76B0", Offset = "0x1FC6AB0", VA = "0x181FC76B0")]
	public static global::LDOHHNGJIMF<T1, T2, T3> DDAMABLPPOO<T1, T2, T3>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7A20", Offset = "0x1FC6E20", VA = "0x181FC7A20")]
	public static global::MBPMDJBKPDI<T1, T2, T3, T4> DDAMABLPPOO<T1, T2, T3, T4>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7980", Offset = "0x1FC6D80", VA = "0x181FC7980")]
	public static global::IKGEKMGLAIK<T1, T2, T3, T4, T5> DDAMABLPPOO<T1, T2, T3, T4, T5>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1FC78D0", Offset = "0x1FC6CD0", VA = "0x181FC78D0")]
	public static global::OAJFDPFNECC<T1, T2, T3, T4, T5, T6> DDAMABLPPOO<T1, T2, T3, T4, T5, T6>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7810", Offset = "0x1FC6C10", VA = "0x181FC7810")]
	public static global::HEMIHCMKFGA<T1, T2, T3, T4, T5, T6, T7> DDAMABLPPOO<T1, T2, T3, T4, T5, T6, T7>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK, T7 NMBMOEHGNLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7740", Offset = "0x1FC6B40", VA = "0x181FC7740")]
	public static global::LADDFCHBAEA<T1, T2, T3, T4, T5, T6, T7, T8> DDAMABLPPOO<T1, T2, T3, T4, T5, T6, T7, T8>(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK, T7 NMBMOEHGNLD, T8 KKLJBFLNBJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1A16290", Offset = "0x1A15690", VA = "0x181A16290")]
	[IteratorStateMachine(typeof(LOIAJJHBFHH))]
	public static IEnumerable<global::AFFFILIJAIM<T1, T2>> LAOFPLLPAFK<T1, T2>(IEnumerable<T1> GNKLMCIFODF, IEnumerable<T2> FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1A180C0", Offset = "0x1A174C0", VA = "0x181A180C0")]
	[IteratorStateMachine(typeof(KBIOIFEMNAE))]
	public static IEnumerable<global::LDOHHNGJIMF<T1, T2, T3>> LAOFPLLPAFK<T1, T2, T3>(IEnumerable<T1> GNKLMCIFODF, IEnumerable<T2> FFOHEAHJJEI, IEnumerable<T3> DMIPEKEOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x25485C0", Offset = "0x25479C0", VA = "0x1825485C0")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x44D7640", Offset = "0x44D6A40", VA = "0x1844D7640")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x44D7650", Offset = "0x44D6A50", VA = "0x1844D7650")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG, int DCDJLNIGGKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FB80", Offset = "0x4D1EF80", VA = "0x184D1FB80")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG, int DCDJLNIGGKK, int FDNOCALODJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FB00", Offset = "0x4D1EF00", VA = "0x184D1FB00")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG, int DCDJLNIGGKK, int FDNOCALODJI, int JBFFFNDFCDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FB20", Offset = "0x4D1EF20", VA = "0x184D1FB20")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG, int DCDJLNIGGKK, int FDNOCALODJI, int JBFFFNDFCDM, int AHDFNFFEIOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FB50", Offset = "0x4D1EF50", VA = "0x184D1FB50")]
	internal static int IMMLEJGDIDC(int OMNFLJHBKOJ, int FBGOIOJMKPI, int ADEOBBAKPHG, int DCDJLNIGGKK, int FDNOCALODJI, int JBFFFNDFCDM, int AHDFNFFEIOH, int MODCJOFGGIJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JKAMCIKKICB<T1> : IComparable<global::JKAMCIKKICB<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
	public JKAMCIKKICB(T1 OLIJOICAHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x427FBA0", Offset = "0x427EFA0", VA = "0x18427FBA0", Slot = "4")]
	public int CompareTo(global::JKAMCIKKICB<T1> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x427FC10", Offset = "0x427F010", VA = "0x18427FC10", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x87EBF0", Offset = "0x87DFF0", VA = "0x18087EBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x427FCB0", Offset = "0x427F0B0", VA = "0x18427FCB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AFFFILIJAIM<T1, T2> : IComparable<global::AFFFILIJAIM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E26A00", Offset = "0x1E25E00", VA = "0x181E26A00")]
	public AFFFILIJAIM(T1 OLIJOICAHCA, T2 PMIMIADIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2726E50", Offset = "0x2726250", VA = "0x182726E50", Slot = "4")]
	public int CompareTo(global::AFFFILIJAIM<T1, T2> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2727860", Offset = "0x2726C60", VA = "0x182727860", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2727E80", Offset = "0x2727280", VA = "0x182727E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2728470", Offset = "0x2727870", VA = "0x182728470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LDOHHNGJIMF<T1, T2, T3> : IComparable<global::LDOHHNGJIMF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x306FB40", Offset = "0x306EF40", VA = "0x18306FB40")]
	public LDOHHNGJIMF(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x306F360", Offset = "0x306E760", VA = "0x18306F360", Slot = "4")]
	public int CompareTo(global::LDOHHNGJIMF<T1, T2, T3> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x306F560", Offset = "0x306E960", VA = "0x18306F560", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x306F850", Offset = "0x306EC50", VA = "0x18306F850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x306F9B0", Offset = "0x306EDB0", VA = "0x18306F9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MBPMDJBKPDI<T1, T2, T3, T4> : IComparable<global::MBPMDJBKPDI<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T4 NLOHIHJNHEC;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1F00C90", Offset = "0x1F00090", VA = "0x181F00C90")]
	public MBPMDJBKPDI(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1F00860", Offset = "0x1EFFC60", VA = "0x181F00860", Slot = "4")]
	public int CompareTo(global::MBPMDJBKPDI<T1, T2, T3, T4> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1F009A0", Offset = "0x1EFFDA0", VA = "0x181F009A0", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1F00AC0", Offset = "0x1EFFEC0", VA = "0x181F00AC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1F00B80", Offset = "0x1EFFF80", VA = "0x181F00B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IKGEKMGLAIK<T1, T2, T3, T4, T5> : IComparable<global::IKGEKMGLAIK<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T4 NLOHIHJNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T5 PHKKFCKHAPD;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2FB13A0", Offset = "0x2FB07A0", VA = "0x182FB13A0")]
	public IKGEKMGLAIK(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0EB0", Offset = "0x2FB02B0", VA = "0x182FB0EB0", Slot = "4")]
	public int CompareTo(global::IKGEKMGLAIK<T1, T2, T3, T4, T5> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1030", Offset = "0x2FB0430", VA = "0x182FB1030", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1170", Offset = "0x2FB0570", VA = "0x182FB1170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1270", Offset = "0x2FB0670", VA = "0x182FB1270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OAJFDPFNECC<T1, T2, T3, T4, T5, T6> : IComparable<global::OAJFDPFNECC<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T4 NLOHIHJNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T5 PHKKFCKHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T6 OKKBHMNPJHJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB980", Offset = "0x3FCAD80", VA = "0x183FCB980")]
	public OAJFDPFNECC(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB3E0", Offset = "0x3FCA7E0", VA = "0x183FCB3E0", Slot = "4")]
	public int CompareTo(global::OAJFDPFNECC<T1, T2, T3, T4, T5, T6> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB5A0", Offset = "0x3FCA9A0", VA = "0x183FCB5A0", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB710", Offset = "0x3FCAB10", VA = "0x183FCB710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3FCB830", Offset = "0x3FCAC30", VA = "0x183FCB830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HEMIHCMKFGA<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::HEMIHCMKFGA<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T4 NLOHIHJNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T5 PHKKFCKHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T6 OKKBHMNPJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T7 BKFFPJPOGGD;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37458B0", Offset = "0x3744CB0", VA = "0x1837458B0")]
	public HEMIHCMKFGA(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK, T7 NMBMOEHGNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3745250", Offset = "0x3744650", VA = "0x183745250", Slot = "4")]
	public int CompareTo(global::HEMIHCMKFGA<T1, T2, T3, T4, T5, T6, T7> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3745450", Offset = "0x3744850", VA = "0x183745450", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x37455F0", Offset = "0x37449F0", VA = "0x1837455F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3745740", Offset = "0x3744B40", VA = "0x183745740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LADDFCHBAEA<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::LADDFCHBAEA<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T1 ADPLBLDOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T2 GLPDNKEODBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T3 OOMCAOICHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T4 NLOHIHJNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T5 PHKKFCKHAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T6 OKKBHMNPJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T7 BKFFPJPOGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T8 BEKJLOKAKAN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x30662C0", Offset = "0x30656C0", VA = "0x1830662C0")]
	public LADDFCHBAEA(T1 OLIJOICAHCA, T2 PMIMIADIKNJ, T3 MHOIPFGGBLL, T4 BGNAAFGDKJP, T5 EHEKEIPJJCA, T6 KAHDNADFIJK, T7 NMBMOEHGNLD, T8 KKLJBFLNBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3065BB0", Offset = "0x3064FB0", VA = "0x183065BB0", Slot = "4")]
	public int CompareTo(global::LADDFCHBAEA<T1, T2, T3, T4, T5, T6, T7, T8> OGCBGOIPCGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3065E00", Offset = "0x3065200", VA = "0x183065E00", Slot = "0")]
	public override bool Equals(object OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3065FC0", Offset = "0x30653C0", VA = "0x183065FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3066130", Offset = "0x3065530", VA = "0x183066130", Slot = "3")]
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
	public T IKGDHNEELOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float KJGKNLKCAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x10A96D0", Offset = "0x10A8AD0", VA = "0x1810A96D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x34BA460", Offset = "0x34B9860", VA = "0x1834BA460")]
	public T CEMHEHDLIEM(float HFMCMEGOMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34BA630", Offset = "0x34B9A30", VA = "0x1834BA630")]
	public T FCOAHJGBIBI(float HFMCMEGOMAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LGEFONHOAMM(T NCCAGEJPKHF, T LIGCOAKACCN, float HFMCMEGOMAH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EAD0", Offset = "0x4D1DED0", VA = "0x184D1EAD0", Slot = "4")]
	protected override float LGEFONHOAMM(float NCCAGEJPKHF, float LIGCOAKACCN, float HFMCMEGOMAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EB50", Offset = "0x4D1DF50", VA = "0x184D1EB50")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4D23C50", Offset = "0x4D23050", VA = "0x184D23C50", Slot = "4")]
	protected override Vector3 LGEFONHOAMM(Vector3 NCCAGEJPKHF, Vector3 LIGCOAKACCN, float HFMCMEGOMAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4D23D10", Offset = "0x4D23110", VA = "0x184D23D10")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D5F0", Offset = "0x4D1C9F0", VA = "0x184D1D5F0", Slot = "4")]
	protected override Color LGEFONHOAMM(Color NCCAGEJPKHF, Color LIGCOAKACCN, float HFMCMEGOMAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D640", Offset = "0x4D1CA40", VA = "0x184D1D640")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public sealed class GKEMBLCLEDH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IKIHMMBOCHJ LBKLIKIKGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private T[] GEBCEHHOKFK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x552CD0", Offset = "0x5520D0", VA = "0x180552CD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A10", Offset = "0x5D2E10", VA = "0x1805D3A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2F3D690", Offset = "0x2F3CA90", VA = "0x182F3D690")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C4E0", Offset = "0x2F3B8E0", VA = "0x182F3C4E0")]
	public static global::GKEMBLCLEDH<T> HFCEOLCNMNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C3A0", Offset = "0x2F3B7A0", VA = "0x182F3C3A0")]
	public static global::GKEMBLCLEDH<T> FPKCPOBBIBG(int KJJBHCMHFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DBD0", Offset = "0x2F3CFD0", VA = "0x182F3DBD0")]
	private GKEMBLCLEDH(T[] KMBLMLEEIPG, int KJJBHCMHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C320", Offset = "0x2F3B720", VA = "0x182F3C320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C910", Offset = "0x2F3BD10", VA = "0x182F3C910")]
	public void KCLLGEJMGAB(in T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2F3C280", Offset = "0x2F3B680", VA = "0x182F3C280")]
	public void DNCCJHOKHFG(int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D160", Offset = "0x2F3C560", VA = "0x182F3D160")]
	public void KPBNPHGEEAP(int IJHNFJCHOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F3D7D0", Offset = "0x2F3CBD0", VA = "0x182F3D7D0")]
	private void OBNPLLBBJNA(int KJJBHCMHFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EJOPDDOEAMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FC1DD0", Offset = "0x1FC11D0", VA = "0x181FC1DD0")]
	public static global::GKEMBLCLEDH<T> HFCEOLCNMNF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1960850", Offset = "0x195FC50", VA = "0x181960850")]
	public static global::GKEMBLCLEDH<T> FPKCPOBBIBG<T>(int KJJBHCMHFJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KAKPEOKPOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FAACECGGIKO>> PKGHMBDJOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FFPIFELIMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ALENHKNJBCN;

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x965650", Offset = "0x964A50", VA = "0x180965650")]
	private KAKPEOKPOBO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FAACECGGIKO>> ACPPKDIDLJI, int OIEDGPHBDIN, int GOAJODAPPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FE20", Offset = "0x4D1F220", VA = "0x184D1FE20")]
	public static KAKPEOKPOBO HFCEOLCNMNF()
	{
		return default(KAKPEOKPOBO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FEA0", Offset = "0x4D1F2A0", VA = "0x184D1FEA0")]
	public (int, int, Task) NKHGAPEGPPJ(int GCNBPOLLEGI)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D20110", Offset = "0x4D1F510", VA = "0x184D20110")]
	public void OMIKMGHLENL(int GCNBPOLLEGI, int GOAJODAPPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class MADHGHKJNCD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly Dictionary<TKey, TVal> GMFCMPIGMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<TVal, TKey> MLAHAIFPIPB;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7FE0", Offset = "0x1EF73E0", VA = "0x181EF7FE0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CHCGHNMIENC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x552EC0", Offset = "0x5522C0", VA = "0x180552EC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ICollection<TKey> FKDBAAIAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8010", Offset = "0x1EF7410", VA = "0x181EF8010", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TVal> MHHNGLDPOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8040", Offset = "0x1EF7440", VA = "0x181EF8040", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public TVal DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1EF4860", Offset = "0x1EF3C60", VA = "0x181EF4860", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8070", Offset = "0x1EF7470", VA = "0x181EF8070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TKey DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7D70", Offset = "0x1EF7170", VA = "0x181EF7D70")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7D00", Offset = "0x1EF7100", VA = "0x181EF7D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7400", Offset = "0x1EF6800", VA = "0x181EF7400", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E30", Offset = "0x1EF7230", VA = "0x181EF7E30", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7230", Offset = "0x1EF6630", VA = "0x181EF7230", Slot = "9")]
	public void Add(TKey KACNOLACOBJ, TVal MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7260", Offset = "0x1EF6660", VA = "0x181EF7260", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7460", Offset = "0x1EF6860", VA = "0x181EF7460", Slot = "8")]
	public bool ContainsKey(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1EF74C0", Offset = "0x1EF68C0", VA = "0x181EF74C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E00", Offset = "0x1EF7200", VA = "0x181EF7E00", Slot = "10")]
	public bool Remove(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E00", Offset = "0x1EF7200", VA = "0x181EF7E00", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7ED0", Offset = "0x1EF72D0", VA = "0x181EF7ED0", Slot = "11")]
	public bool TryGetValue(TKey KACNOLACOBJ, out TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1EF79C0", Offset = "0x1EF6DC0", VA = "0x181EF79C0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF74F0", Offset = "0x1EF68F0", VA = "0x181EF74F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] INALBAMOJHE, int DLNBKPGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7BD0", Offset = "0x1EF6FD0", VA = "0x181EF7BD0")]
	public void KCLLGEJMGAB(TVal GBEHFHJJEGC, TKey KACNOLACOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7C80", Offset = "0x1EF7080", VA = "0x181EF7C80")]
	public void KCLLGEJMGAB(KeyValuePair<TVal, TKey> CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7D40", Offset = "0x1EF7140", VA = "0x181EF7D40")]
	public bool NIGFKNBLCPA(TVal KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1EF3170", Offset = "0x1EF2570", VA = "0x181EF3170")]
	public bool OMFGGLAJBGI(KeyValuePair<TVal, TKey> CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7550", Offset = "0x1EF6950", VA = "0x181EF7550")]
	public bool EPGMMIBEDJL(TVal KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7550", Offset = "0x1EF6950", VA = "0x181EF7550")]
	public bool EPGMMIBEDJL(KeyValuePair<TVal, TKey> CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1EF72C0", Offset = "0x1EF66C0", VA = "0x181EF72C0")]
	public bool BIAHFFMAKML(TVal KACNOLACOBJ, out TKey MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1EF72F0", Offset = "0x1EF66F0", VA = "0x181EF72F0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CKPGMHDFGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7B50", Offset = "0x1EF6F50", VA = "0x181EF7B50")]
	private void HAMDNOAPMLI(TKey KACNOLACOBJ, TVal GBEHFHJJEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7640", Offset = "0x1EF6A40", VA = "0x181EF7640")]
	private void FMKHOFAANLI(TKey KACNOLACOBJ, TVal GBEHFHJJEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7780", Offset = "0x1EF6B80", VA = "0x181EF7780")]
	private bool GFBBLLOHAEK(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF76C0", Offset = "0x1EF6AC0", VA = "0x181EF76C0")]
	private bool GFBBLLOHAEK(TVal GBEHFHJJEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7F00", Offset = "0x1EF7300", VA = "0x181EF7F00")]
	public MADHGHKJNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class KGIAMOEMHJJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private global::KGIAMOEMHJJ<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x128F9D0", Offset = "0x128EDD0", VA = "0x18128F9D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2C5DF00", Offset = "0x2C5D300", VA = "0x182C5DF00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C5E410", Offset = "0x2C5D810", VA = "0x182C5E410")]
		public Enumerator(global::KGIAMOEMHJJ<T> KCNEECJJIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C5DA90", Offset = "0x2C5CE90", VA = "0x182C5DA90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C5DE60", Offset = "0x2C5D260", VA = "0x182C5DE60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C5DBC0", Offset = "0x2C5CFC0", VA = "0x182C5DBC0")]
		private void OKGCKHOBGIN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private T[] DHBJDHCKMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int LLBPABECDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private int EMNELHABKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int BNNMAOPHHMC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C65C60", Offset = "0x2C65060", VA = "0x182C65C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public T DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C65DD0", Offset = "0x2C651D0", VA = "0x182C65DD0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C65B60", Offset = "0x2C64F60", VA = "0x182C65B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C66030", Offset = "0x2C65430", VA = "0x182C66030")]
	public KGIAMOEMHJJ(int KJJBHCMHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C647C0", Offset = "0x2C63BC0", VA = "0x182C647C0")]
	public void KCLLGEJMGAB(T HFMCMEGOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C65170", Offset = "0x2C64570", VA = "0x182C65170")]
	public void NAFIILBMGHG(IEnumerable<T> OHCNJJNNDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E20", Offset = "0x2C65220", VA = "0x182C65E20")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C64500", Offset = "0x2C63900", VA = "0x182C64500")]
	public void FICJDHEFOPM(int LFFBMCJGPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C64DC0", Offset = "0x2C641C0", VA = "0x182C64DC0")]
	public void MOICDHKHODJ(int LFFBMCJGPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C64C70", Offset = "0x2C64070", VA = "0x182C64C70")]
	public void LLLKGDGBIAL(T[] INALBAMOJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C64020", Offset = "0x2C63420", VA = "0x182C64020")]
	public Enumerator DGONKCCFOLN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E40", Offset = "0x2C65240", VA = "0x182C65E40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C65E40", Offset = "0x2C65240", VA = "0x182C65E40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C64410", Offset = "0x2C63810", VA = "0x182C64410")]
	private int FCNIELNALIF(int DBFCFFLFJDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C64110", Offset = "0x2C63510", VA = "0x182C64110")]
	private int FBLALNFOIAB(int DBFCFFLFJDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DMAOGBFKHND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IDisposable[] GEBCEHHOKFK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BF850", Offset = "0x6BEC50", VA = "0x1806BF850")]
	public DMAOGBFKHND(params IDisposable[] KMBLMLEEIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xD7FF20", Offset = "0xD7F320", VA = "0x180D7FF20")]
	public static DMAOGBFKHND HFCEOLCNMNF(params IDisposable[] KMBLMLEEIPG)
	{
		return default(DMAOGBFKHND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D750", Offset = "0x4D1CB50", VA = "0x184D1D750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PIKGBHGEJDK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly IDisposable PGABBOCLCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public T IKGDHNEELOA;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2FAACA0", Offset = "0x2FAA0A0", VA = "0x182FAACA0")]
	public PIKGBHGEJDK(IDisposable BJBBMMOBBBD, in T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2834CC0", Offset = "0x28340C0", VA = "0x182834CC0")]
	public static global::PIKGBHGEJDK<U> LKKAFHJGMJP<U>(in global::PIKGBHGEJDK<T> BJBBMMOBBBD, in U MGNFAPLJAOB)
	{
		return default(global::PIKGBHGEJDK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x21D0DC0", Offset = "0x21D01C0", VA = "0x1821D0DC0")]
	public global::PIKGBHGEJDK<U> PBBCNMMJGAG<U>(in U MGNFAPLJAOB)
	{
		return default(global::PIKGBHGEJDK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8620", Offset = "0x2AF7A20", VA = "0x182AF8620")]
	public static global::PIKGBHGEJDK<(T, U)> DNAEEACBNHK<U>(in global::PIKGBHGEJDK<T> GNKLMCIFODF, in global::PIKGBHGEJDK<U> FFOHEAHJJEI)
	{
		return default(global::PIKGBHGEJDK<(T, U)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3661770", Offset = "0x3660B70", VA = "0x183661770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BJDNAEFGAID
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2829F40", Offset = "0x2829340", VA = "0x182829F40")]
	public static global::PIKGBHGEJDK<T> HFCEOLCNMNF<T>(IDisposable BJBBMMOBBBD, in T MGNFAPLJAOB)
	{
		return default(global::PIKGBHGEJDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x21D0DC0", Offset = "0x21D01C0", VA = "0x1821D0DC0")]
	public static global::PIKGBHGEJDK<U> LKKAFHJGMJP<U, T>(in global::PIKGBHGEJDK<T> FBNNHFPPCNM, in U MGNFAPLJAOB)
	{
		return default(global::PIKGBHGEJDK<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x21D0D80", Offset = "0x21D0180", VA = "0x1821D0D80")]
	public static global::PIKGBHGEJDK<(T, U)> DNAEEACBNHK<T, U>(in global::PIKGBHGEJDK<T> GNKLMCIFODF, in global::PIKGBHGEJDK<U> FFOHEAHJJEI)
	{
		return default(global::PIKGBHGEJDK<(T, U)>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct IKIHMMBOCHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x552EC0", Offset = "0x5522C0", VA = "0x180552EC0")]
	public static IKIHMMBOCHJ FEIPLCALHLB<T>([Optional] string DLKGIKEBMAH, [Optional] string PFJIIFJIPNG, bool MPHGGPPCCON = false)
	{
		return default(IKIHMMBOCHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class EKPGOELCLGC<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<Internal, External> IDAMCANKDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Func<External, Internal> BEAHNMEICFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private IList<Internal> NODDPNCGJJL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<Internal> JIGDPHFCINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool CHCGHNMIENC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D3990", Offset = "0x5D2D90", VA = "0x1805D3990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x713EB0", Offset = "0x7132B0", VA = "0x180713EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public External DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3939400", Offset = "0x3938800", VA = "0x183939400", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x39394A0", Offset = "0x39388A0", VA = "0x1839394A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x39393A0", Offset = "0x39387A0", VA = "0x1839393A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3939310", Offset = "0x3938710", VA = "0x183939310")]
	public EKPGOELCLGC(Func<Internal, External> IDAMCANKDIM, Func<External, Internal> BEAHNMEICFO, bool OPJDAFIOHAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3939020", Offset = "0x3938420", VA = "0x183939020", Slot = "6")]
	public int IndexOf(External CBOKIMKBPGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3938CA0", Offset = "0x39380A0", VA = "0x183938CA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3938D00", Offset = "0x3938100", VA = "0x183938D00", Slot = "13")]
	public bool Contains(External CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3938D90", Offset = "0x3938190", VA = "0x183938D90", Slot = "14")]
	public void CopyTo(External[] INALBAMOJHE, int DLNBKPGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3938C10", Offset = "0x3938010", VA = "0x183938C10", Slot = "11")]
	public void Add(External CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3939110", Offset = "0x3938510", VA = "0x183939110", Slot = "7")]
	public void Insert(int DBFCFFLFJDL, External CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3939280", Offset = "0x3938680", VA = "0x183939280", Slot = "15")]
	public bool Remove(External CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x39391B0", Offset = "0x39385B0", VA = "0x1839391B0", Slot = "8")]
	public void RemoveAt(int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3938FB0", Offset = "0x39383B0", VA = "0x183938FB0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1EFA100", Offset = "0x1EF9500", VA = "0x181EFA100", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DefaultMember("Item")]
public class IJANLADGCBO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Func<Internal, External> IDAMCANKDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> NODDPNCGJJL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<Internal> JIGDPHFCINL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool CHCGHNMIENC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x552FE0", Offset = "0x5523E0", VA = "0x180552FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public External DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0AF0", Offset = "0x2FAFEF0", VA = "0x182FB0AF0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0A90", Offset = "0x2FAFE90", VA = "0x182FB0A90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
	public IJANLADGCBO(Func<Internal, External> IDAMCANKDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0A40", Offset = "0x2FAFE40", VA = "0x182FB0A40")]
	public IJANLADGCBO(IReadOnlyList<Internal> NODDPNCGJJL, Func<Internal, External> IDAMCANKDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0820", Offset = "0x2FAFC20", VA = "0x182FB0820")]
	public void LLLKGDGBIAL(External[] INALBAMOJHE, int DLNBKPGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2FB07B0", Offset = "0x2FAFBB0", VA = "0x182FB07B0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1C2E080", Offset = "0x1C2D480", VA = "0x181C2E080", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class CCHKIIPPPLO<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private IReadOnlyList<Internal> NODDPNCGJJL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<Internal> JIGDPHFCINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CHCGHNMIENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x552FE0", Offset = "0x5523E0", VA = "0x180552FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public External DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1F3BB60", Offset = "0x1F3AF60", VA = "0x181F3BB60", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1F3BB00", Offset = "0x1F3AF00", VA = "0x181F3BB00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
	public CCHKIIPPPLO(IReadOnlyList<Internal> NODDPNCGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BA20", Offset = "0x1F3AE20", VA = "0x181F3BA20")]
	public bool OMFGGLAJBGI(External CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1F3B7F0", Offset = "0x1F3ABF0", VA = "0x181F3B7F0")]
	public void LLLKGDGBIAL(External[] INALBAMOJHE, int DLNBKPGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1F3B720", Offset = "0x1F3AB20", VA = "0x181F3B720", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1EFA100", Offset = "0x1EF9500", VA = "0x181EFA100", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public abstract class JFAPAIIJKOI
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IDJJDJFINEG(object[] LOIJKDAGJIC);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	protected JFAPAIIJKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class AHHPHLHHDEM<T> : JFAPAIIJKOI
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	protected struct PMLJCNDPDFL
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public enum NLKKPDDNKML
		{
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NLKKPDDNKML HHDFIJECABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public T MOOMHHEHKEJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int BKCDKJHNMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly bool PCBIMMHLOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected readonly bool BPCAIHCHHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	protected List<T> BEPNBBFEHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private List<PMLJCNDPDFL> MNPKAJKJPDM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FNFEACEJELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3A064B0", Offset = "0x3A058B0", VA = "0x183A064B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3A06950", Offset = "0x3A05D50", VA = "0x183A06950")]
	protected AHHPHLHHDEM(bool BPCAIHCHHEG, bool PCBIMMHLOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3A062B0", Offset = "0x3A056B0", VA = "0x183A062B0")]
	protected bool CMJFPPFOLHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3A061D0", Offset = "0x3A055D0", VA = "0x183A061D0")]
	protected void ADADAJEGHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3A064F0", Offset = "0x3A058F0", VA = "0x183A064F0")]
	protected void IPONHIEBIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x228D7F0", Offset = "0x228CBF0", VA = "0x18228D7F0")]
	private static void HNKHHGLALBF<U>(ref List<U> NODDPNCGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3A066A0", Offset = "0x3A05AA0", VA = "0x183A066A0", Slot = "5")]
	public void KCLLGEJMGAB(T MOOMHHEHKEJ, bool EMKAEDBKHPG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3A06350", Offset = "0x3A05750", VA = "0x183A06350", Slot = "6")]
	public void EPGMMIBEDJL(T MOOMHHEHKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3A06820", Offset = "0x3A05C20", VA = "0x183A06820")]
	public void PDAIKLBALNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AALNJJOBKAN
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CDMOJAPFDMP : global::AHHPHLHHDEM<Action>, AALNJJOBKAN
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D590", Offset = "0x4D1C990", VA = "0x184D1D590")]
	public CDMOJAPFDMP(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D3D0", Offset = "0x4D1C7D0", VA = "0x184D1D3D0")]
	public void PCIABCLBEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D290", Offset = "0x4D1C690", VA = "0x184D1D290", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D370", Offset = "0x4D1C770", VA = "0x184D1D370")]
	public static CDMOJAPFDMP NJOFOEAECPI(CDMOJAPFDMP POKGJCGKGMG, Action MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D310", Offset = "0x4D1C710", VA = "0x184D1D310")]
	public static CDMOJAPFDMP MNLNHINEFGM(CDMOJAPFDMP POKGJCGKGMG, Action MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LDNEAMJOJNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FGNOLOANHMP<T> : global::AHHPHLHHDEM<Action<T>>, global::LDNEAMJOJNL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public FGNOLOANHMP(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3E3AD50", Offset = "0x3E3A150", VA = "0x183E3AD50")]
	public void PCIABCLBEJI(T HFMCMEGOMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2170", Offset = "0x3EC1570", VA = "0x183EC2170", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x3E39A50", Offset = "0x3E38E50", VA = "0x183E39A50")]
	public static global::FGNOLOANHMP<T> NJOFOEAECPI(global::FGNOLOANHMP<T> POKGJCGKGMG, Action<T> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3E399B0", Offset = "0x3E38DB0", VA = "0x183E399B0")]
	public static global::FGNOLOANHMP<T> MNLNHINEFGM(global::FGNOLOANHMP<T> POKGJCGKGMG, Action<T> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HKEANKMMCOB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T, U> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T, U> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class BKEOHMPAIDF<T, U> : global::AHHPHLHHDEM<Action<T, U>>, global::HKEANKMMCOB<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public BKEOHMPAIDF(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3E99330", Offset = "0x3E98730", VA = "0x183E99330")]
	public void PCIABCLBEJI(T HFMCMEGOMAH, U GFNODCAANNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3E969F0", Offset = "0x3E95DF0", VA = "0x183E969F0", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3E98B70", Offset = "0x3E97F70", VA = "0x183E98B70")]
	public static global::BKEOHMPAIDF<T, U> NJOFOEAECPI(global::BKEOHMPAIDF<T, U> POKGJCGKGMG, Action<T, U> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3E98AD0", Offset = "0x3E97ED0", VA = "0x183E98AD0")]
	public static global::BKEOHMPAIDF<T, U> MNLNHINEFGM(global::BKEOHMPAIDF<T, U> POKGJCGKGMG, Action<T, U> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GAIBEDCBOBP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T, U, V> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T, U, V> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class BIKPBNBGFJF<T, U, V> : global::AHHPHLHHDEM<Action<T, U, V>>, global::GAIBEDCBOBP<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public BIKPBNBGFJF(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x3E95570", Offset = "0x3E94970", VA = "0x183E95570")]
	public void PCIABCLBEJI(T HFMCMEGOMAH, U GFNODCAANNI, V AEKDMOKGKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3E931E0", Offset = "0x3E925E0", VA = "0x183E931E0", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3E93D10", Offset = "0x3E93110", VA = "0x183E93D10")]
	public static global::BIKPBNBGFJF<T, U, V> NJOFOEAECPI(global::BIKPBNBGFJF<T, U, V> POKGJCGKGMG, Action<T, U, V> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3E93C70", Offset = "0x3E93070", VA = "0x183E93C70")]
	public static global::BIKPBNBGFJF<T, U, V> MNLNHINEFGM(global::BIKPBNBGFJF<T, U, V> POKGJCGKGMG, Action<T, U, V> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MGHOPHMMAOF<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T, U, V, W> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T, U, V, W> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class PLMDAIKDDDH<T, U, V, W> : global::AHHPHLHHDEM<Action<T, U, V, W>>, global::MGHOPHMMAOF<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public PLMDAIKDDDH(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3F71CF0", Offset = "0x3F710F0", VA = "0x183F71CF0")]
	public void PCIABCLBEJI(T HFMCMEGOMAH, U GFNODCAANNI, V AEKDMOKGKJI, W OKFCFKIHJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6FA60", Offset = "0x3F6EE60", VA = "0x183F6FA60", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3F71170", Offset = "0x3F70570", VA = "0x183F71170")]
	public static global::PLMDAIKDDDH<T, U, V, W> NJOFOEAECPI(global::PLMDAIKDDDH<T, U, V, W> POKGJCGKGMG, Action<T, U, V, W> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3F710D0", Offset = "0x3F704D0", VA = "0x183F710D0")]
	public static global::PLMDAIKDDDH<T, U, V, W> MNLNHINEFGM(global::PLMDAIKDDDH<T, U, V, W> POKGJCGKGMG, Action<T, U, V, W> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IKIOLFFCDID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T, U, V, W, X> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T, U, V, W, X> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NALJKKALNIH<T, U, V, W, X> : global::AHHPHLHHDEM<Action<T, U, V, W, X>>, global::IKIOLFFCDID<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public NALJKKALNIH(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2C55610", Offset = "0x2C54A10", VA = "0x182C55610")]
	public void PCIABCLBEJI(T HFMCMEGOMAH, U GFNODCAANNI, V AEKDMOKGKJI, W OKFCFKIHJCI, X JEPLLBBBDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C54ED0", Offset = "0x2C542D0", VA = "0x182C54ED0", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2C55260", Offset = "0x2C54660", VA = "0x182C55260")]
	public static global::NALJKKALNIH<T, U, V, W, X> NJOFOEAECPI(global::NALJKKALNIH<T, U, V, W, X> POKGJCGKGMG, Action<T, U, V, W, X> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2C551C0", Offset = "0x2C545C0", VA = "0x182C551C0")]
	public static global::NALJKKALNIH<T, U, V, W, X> MNLNHINEFGM(global::NALJKKALNIH<T, U, V, W, X> POKGJCGKGMG, Action<T, U, V, W, X> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KDOFMMOPECP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCLLGEJMGAB(Action<T, U, V, W, X, Y> MOOMHHEHKEJ, bool EMKAEDBKHPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPGMMIBEDJL(Action<T, U, V, W, X, Y> MOOMHHEHKEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class MALCDEJIKHI<T, U, V, W, X, Y> : global::AHHPHLHHDEM<Action<T, U, V, W, X, Y>>, global::KDOFMMOPECP<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1EF94A0", Offset = "0x1EF88A0", VA = "0x181EF94A0")]
	public MALCDEJIKHI(bool BPCAIHCHHEG = false, bool PCBIMMHLOMO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1EF91E0", Offset = "0x1EF85E0", VA = "0x181EF91E0")]
	public void PCIABCLBEJI(T HFMCMEGOMAH, U GFNODCAANNI, V AEKDMOKGKJI, W OKFCFKIHJCI, X JEPLLBBBDFO, Y BDJKNLLCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1EF80D0", Offset = "0x1EF74D0", VA = "0x181EF80D0", Slot = "4")]
	public override void IDJJDJFINEG(object[] LOIJKDAGJIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8B70", Offset = "0x1EF7F70", VA = "0x181EF8B70")]
	public static global::MALCDEJIKHI<T, U, V, W, X, Y> NJOFOEAECPI(global::MALCDEJIKHI<T, U, V, W, X, Y> POKGJCGKGMG, Action<T, U, V, W, X, Y> MOOMHHEHKEJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF8AD0", Offset = "0x1EF7ED0", VA = "0x181EF8AD0")]
	public static global::MALCDEJIKHI<T, U, V, W, X, Y> MNLNHINEFGM(global::MALCDEJIKHI<T, U, V, W, X, Y> POKGJCGKGMG, Action<T, U, V, W, X, Y> MOOMHHEHKEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class ACBHJNDJJAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct DMNOIIBJDJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::ACBHJNDJJAG<T> MLKJAGDGPIC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public T IKGDHNEELOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x3388B30", Offset = "0x3387F30", VA = "0x183388B30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3388B00", Offset = "0x3387F00", VA = "0x183388B00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6BF850", Offset = "0x6BEC50", VA = "0x1806BF850")]
		public DMNOIIBJDJG(global::ACBHJNDJJAG<T> MLKJAGDGPIC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MOFLCGAKDNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder<DMNOIIBJDJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public global::ACBHJNDJJAG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x338AB30", Offset = "0x3389F30", VA = "0x18338AB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x338A910", Offset = "0x3389D10", VA = "0x18338A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct LBCFFCMNFFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<DMNOIIBJDJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public global::ACBHJNDJJAG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x338A570", Offset = "0x3389970", VA = "0x18338A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x338A910", Offset = "0x3389D10", VA = "0x18338A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly SemaphoreSlim NHCAHPFJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private T FMOLCOGKJOK;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BOPLLOBIFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3383420", Offset = "0x3382820", VA = "0x183383420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3383A30", Offset = "0x3382E30", VA = "0x183383A30")]
	public ACBHJNDJJAG(in T FMOLCOGKJOK, int FHBCOLLPAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3383A00", Offset = "0x3382E00", VA = "0x183383A00")]
	public ACBHJNDJJAG(in T FMOLCOGKJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x33833E0", Offset = "0x33827E0", VA = "0x1833833E0")]
	public DMNOIIBJDJG GJJACKPDPEL()
	{
		return default(DMNOIIBJDJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x33833A0", Offset = "0x33827A0", VA = "0x1833833A0")]
	public DMNOIIBJDJG GJJACKPDPEL(CancellationToken MBCDFHLPEDE)
	{
		return default(DMNOIIBJDJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x33838A0", Offset = "0x3382CA0", VA = "0x1833838A0")]
	[AsyncStateMachine(typeof(global::ACBHJNDJJAG<>.MOFLCGAKDNB))]
	public Task<DMNOIIBJDJG> PNNHIHBAOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3383720", Offset = "0x3382B20", VA = "0x183383720")]
	[AsyncStateMachine(typeof(global::ACBHJNDJJAG<>.LBCFFCMNFFP))]
	public Task<DMNOIIBJDJG> PNNHIHBAOHN(CancellationToken MBCDFHLPEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KBHNFBMJJOA
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4D20230", Offset = "0x4D1F630", VA = "0x184D20230")]
	public static global::ACBHJNDJJAG<FAACECGGIKO> HFCEOLCNMNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4D201C0", Offset = "0x4D1F5C0", VA = "0x184D201C0")]
	public static global::ACBHJNDJJAG<FAACECGGIKO> HFCEOLCNMNF(int FHBCOLLPAGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7470", Offset = "0x1FC6870", VA = "0x181FC7470")]
	public static global::ACBHJNDJJAG<T> HFCEOLCNMNF<T>(in T FMOLCOGKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2091780", Offset = "0x2090B80", VA = "0x182091780")]
	public static global::ACBHJNDJJAG<T> HFCEOLCNMNF<T>(in T FMOLCOGKJOK, int FHBCOLLPAGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class GEJMMHBDBFN<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate bool ALGIIAAFHOI(global::GEJMMHBDBFN<T> FKKCOCJCKAD);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class AJFMBINNACG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public T nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::GEJMMHBDBFN<T> foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public AJFMBINNACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2F2EFA0", Offset = "0x2F2E3A0", VA = "0x182F2EFA0")]
		internal bool <FindNode>b__0(global::GEJMMHBDBFN<T> node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public T DLENLDALPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public LinkedList<global::GEJMMHBDBFN<T>> EJBIPMHMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public global::GEJMMHBDBFN<T> IBJBFIHNLOE;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public global::GEJMMHBDBFN<T> JHIMGLCOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5A5130", Offset = "0x5A4530", VA = "0x1805A5130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2F37380", Offset = "0x2F36780", VA = "0x182F37380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool BFPNMFLEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2F37EF0", Offset = "0x2F372F0", VA = "0x182F37EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CLOHDAFLAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2F36BB0", Offset = "0x2F35FB0", VA = "0x182F36BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public global::GEJMMHBDBFN<T> CGAFANNDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2F36AF0", Offset = "0x2F35EF0", VA = "0x182F36AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2F390A0", Offset = "0x2F384A0", VA = "0x182F390A0")]
	public GEJMMHBDBFN(T MAFBNBECNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2F38350", Offset = "0x2F37750", VA = "0x182F38350")]
	public global::GEJMMHBDBFN<T> OLIONOHLNCL(T GFEANOGHNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2F370D0", Offset = "0x2F364D0", VA = "0x182F370D0")]
	public global::GEJMMHBDBFN<T> FBNBCGLENGG(T MFOEOGEMAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2F36E60", Offset = "0x2F36260", VA = "0x182F36E60")]
	public global::GEJMMHBDBFN<T> EPGMMIBEDJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2F387C0", Offset = "0x2F37BC0", VA = "0x182F387C0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2F36BF0", Offset = "0x2F35FF0", VA = "0x182F36BF0")]
	public global::GEJMMHBDBFN<T> EBLKELBIMLP(T BEJACBLGALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2F38A20", Offset = "0x2F37E20", VA = "0x182F38A20")]
	public static void PDBCIAGOCGP(global::GEJMMHBDBFN<T> AOEPKEPAIGL, ALGIIAAFHOI PMONFNLOMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x2207550", Offset = "0x2206950", VA = "0x182207550")]
	public static void PDBCIAGOCGP<A>(global::GEJMMHBDBFN<T> AOEPKEPAIGL, Func<global::GEJMMHBDBFN<T>, A, bool> PMONFNLOMGD, A GNNJJJAOEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2F37460", Offset = "0x2F36860", VA = "0x182F37460")]
	public static string GGBNBCDKGNJ(global::GEJMMHBDBFN<T> AOEPKEPAIGL, int BDNGLGIDOEC = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2F37F20", Offset = "0x2F37320", VA = "0x182F37F20")]
	public static global::GEJMMHBDBFN<T> NDGFKLKHJLF(global::GEJMMHBDBFN<T> AOEPKEPAIGL, T OAEAGGNOMAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class EGDFIGJNIDH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate Task<TResult> BMAKGDLLFIJ(TRequest JNKDPLJLFBG, CancellationToken MBCDFHLPEDE);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum JNEIBFKAENI
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class GNPDFHPPPEN
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private const float PIJIDIDDLEE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TimeSpan DGDIJIDJLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int GIJKELDIMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public JNEIBFKAENI BPMCPPKFNMM;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public static readonly GNPDFHPPPEN NHBAGNNNDIM;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float IMACPGGIMFL
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3B0ABA0", Offset = "0x3B09FA0", VA = "0x183B0ABA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TimeSpan JBCCIOBMNAF
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3B0ACF0", Offset = "0x3B0A0F0", VA = "0x183B0ACF0")]
		public GNPDFHPPPEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private readonly struct NKEPKPMNPCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public readonly TRequest JNKDPLJLFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public readonly CancellationToken MBCDFHLPEDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public readonly TaskCompletionSource<TResult> HIKIKNMLLBD;

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F090", Offset = "0x3B0E490", VA = "0x183B0F090")]
		public NKEPKPMNPCF(TRequest JNKDPLJLFBG, TaskCompletionSource<TResult> HIKIKNMLLBD, CancellationToken MBCDFHLPEDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CBHPKAINOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public CBHPKAINOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7FE0", Offset = "0x1EF73E0", VA = "0x181EF7FE0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JILMCPLPPMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public global::EGDFIGJNIDH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B0B380", Offset = "0x3B0A780", VA = "0x183B0B380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x714190", Offset = "0x713590", VA = "0x180714190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class DGFMFPPBLDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public NKEPKPMNPCF req;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public global::EGDFIGJNIDH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public DGFMFPPBLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3AFC690", Offset = "0x3AFBA90", VA = "0x183AFC690")]
		internal void <ProcessQueue>b__0(Task<TResult> task)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly CancellationTokenSource AFJIEGKOCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<NKEPKPMNPCF> NHKPGHMAAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly GNPDFHPPPEN IHJFBANMGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BMAKGDLLFIJ GFAIGBAPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Task HIMHDECHHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private int ANOFDDBABLL;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3B098A0", Offset = "0x3B08CA0", VA = "0x183B098A0")]
	public EGDFIGJNIDH(BMAKGDLLFIJ GFAIGBAPNJK, [Optional] GNPDFHPPPEN IHJFBANMGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3B093D0", Offset = "0x3B087D0", VA = "0x183B093D0")]
	public Task<TResult> OIONIHHCIGC(TRequest JNKDPLJLFBG, CancellationToken MBCDFHLPEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3B07F40", Offset = "0x3B07340", VA = "0x183B07F40")]
	private void BOGJBFPOIEK(NKEPKPMNPCF FKOONOMJOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3B08140", Offset = "0x3B07540", VA = "0x183B08140")]
	[AsyncStateMachine(typeof(global::EGDFIGJNIDH<, >.JILMCPLPPMP))]
	private Task GNBDLHNGLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3B08A40", Offset = "0x3B07E40", VA = "0x183B08A40")]
	private NKEPKPMNPCF LCDJPDLHJIF()
	{
		return default(NKEPKPMNPCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3B08670", Offset = "0x3B07A70", VA = "0x183B08670")]
	private void HNJFDPFMFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3B08100", Offset = "0x3B07500", VA = "0x183B08100", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class LJOJJCBMDCF<TKey, TVal> : global::FCBJKEHNGFH<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int DEKJNPLFNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	internal Dictionary<TKey, (TVal value, int size)> EMAFIKLGMCF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	internal override int EIBFCFLLEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E29060", Offset = "0x1E28460", VA = "0x181E29060", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	internal int ENCMFJKHJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E28FB0", Offset = "0x1E283B0", VA = "0x181E28FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public override int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E29090", Offset = "0x1E28490", VA = "0x181E29090", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1E293B0", Offset = "0x1E287B0", VA = "0x181E293B0")]
	public LJOJJCBMDCF(int KJJBHCMHFJM, [Optional] LFFDJFONBMG CIENBIMODKL, [Optional] IEqualityComparer<TKey> LLFENFBGHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1E290F0", Offset = "0x1E284F0", VA = "0x181E290F0")]
	public void NHEBIGNLIIE(TKey KACNOLACOBJ, TVal MGNFAPLJAOB, bool AJFMBJGAABI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1E28FE0", Offset = "0x1E283E0", VA = "0x181E28FE0")]
	public bool KGFLGDNCHGP(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1E28CD0", Offset = "0x1E280D0", VA = "0x181E28CD0", Slot = "6")]
	public override bool BIAHFFMAKML(TKey FHNEADCFGCN, out TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E28D80", Offset = "0x1E28180", VA = "0x181E28D80")]
	public bool FCOLPOPMKBC(TKey KACNOLACOBJ, TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E29200", Offset = "0x1E28600", VA = "0x181E29200")]
	public bool PGILONADIPA(TKey KACNOLACOBJ, TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1E29190", Offset = "0x1E28590", VA = "0x181E29190", Slot = "7")]
	public override void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E29310", Offset = "0x1E28710", VA = "0x181E29310")]
	private bool POGFDCLIMOK(TKey KACNOLACOBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[DefaultMember("Item")]
public class FCBJKEHNGFH<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate int LFFDJFONBMG(TKey KACNOLACOBJ, TVal MGNFAPLJAOB);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BPIGOHCAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public TKey DCBIHGMJIKF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public TVal IKGDHNEELOA
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x680BA0", Offset = "0x67FFA0", VA = "0x180680BA0")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x713AD0", Offset = "0x712ED0", VA = "0x180713AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OMJCACLPBAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x6D0CB0", Offset = "0x6D00B0", VA = "0x1806D0CB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x6D0CE0", Offset = "0x6D00E0", VA = "0x1806D0CE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public DateTime IAFGCNHFJAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x101DD00", Offset = "0x101D100", VA = "0x18101DD00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6DB0", Offset = "0x3EB61B0", VA = "0x183EB6DB0")]
		public BPIGOHCAIPF(TKey KACNOLACOBJ, TVal GBEHFHJJEGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const int JNIMCNLADBB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly Dictionary<TKey, LinkedListNode<BPIGOHCAIPF>> BFJDIOBCIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LinkedList<BPIGOHCAIPF> IACLGAMJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	protected readonly LFFDJFONBMG CIENBIMODKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly TimeSpan GPOFJIIDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly AJNEDCACPLG JKENABIAAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int PKOOFLEOPGO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int HEEPDHHAAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0B0", Offset = "0x6D94B0", VA = "0x1806DA0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool OFDIEIHGDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3EBF3E0", Offset = "0x3EBE7E0", VA = "0x183EBF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	internal virtual int EIBFCFLLEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0C0", Offset = "0x6D94C0", VA = "0x1806DA0C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private int LFFBMCJGPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x21FFF40", Offset = "0x21FF340", VA = "0x1821FFF40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public virtual int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1C2C3E0", Offset = "0x1C2B7E0", VA = "0x181C2C3E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<TKey> FKDBAAIAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EBED70", Offset = "0x3EBE170", VA = "0x183EBED70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public TVal DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2889980", Offset = "0x2888D80", VA = "0x182889980")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2FAC850", Offset = "0x2FABC50", VA = "0x182FAC850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0190", Offset = "0x3EBF590", VA = "0x183EC0190")]
	public FCBJKEHNGFH(int KJJBHCMHFJM, [Optional] LFFDJFONBMG CIENBIMODKL, [Optional] IEqualityComparer<TKey> LLFENFBGHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0500", Offset = "0x3EBF900", VA = "0x183EC0500")]
	public FCBJKEHNGFH(TimeSpan GPOFJIIDJII, [Optional] IEqualityComparer<TKey> LLFENFBGHHK, [Optional] AJNEDCACPLG JKENABIAAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EC04B0", Offset = "0x3EBF8B0", VA = "0x183EC04B0")]
	public FCBJKEHNGFH(int KJJBHCMHFJM, TimeSpan GPOFJIIDJII, [Optional] IEqualityComparer<TKey> LLFENFBGHHK, [Optional] AJNEDCACPLG JKENABIAAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0260", Offset = "0x3EBF660", VA = "0x183EC0260")]
	public FCBJKEHNGFH(int KJJBHCMHFJM, LFFDJFONBMG CIENBIMODKL, TimeSpan GPOFJIIDJII, [Optional] IEqualityComparer<TKey> LLFENFBGHHK, [Optional] AJNEDCACPLG JKENABIAAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF270", Offset = "0x3EBE670", VA = "0x183EBF270")]
	public void GLPGKBNIAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF0F0", Offset = "0x3EBE4F0", VA = "0x183EBF0F0")]
	public void GCIBODCAOML(TKey KACNOLACOBJ, TVal MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3EBEF90", Offset = "0x3EBE390", VA = "0x183EBEF90")]
	public bool EPGMMIBEDJL(TKey KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3EBECC0", Offset = "0x3EBE0C0", VA = "0x183EBECC0")]
	private TVal CEDINIMJBIG(TKey FHNEADCFGCN)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3EBE960", Offset = "0x3EBDD60", VA = "0x183EBE960", Slot = "6")]
	public virtual bool BIAHFFMAKML(TKey FHNEADCFGCN, out TVal MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFD80", Offset = "0x3EBF180", VA = "0x183EBFD80", Slot = "7")]
	public virtual void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFC00", Offset = "0x3EBF000", VA = "0x183EBFC00")]
	private bool NJPDKONJCKO(BPIGOHCAIPF HOJECEOGPJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF9D0", Offset = "0x3EBEDD0", VA = "0x183EBF9D0")]
	private void NCPEICNGKEF(LinkedListNode<BPIGOHCAIPF> NILBNMLGODN, TVal MEMCCCNHBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3EBFFC0", Offset = "0x3EBF3C0", VA = "0x183EBFFC0")]
	private void PGADOPELPNL(TKey KACNOLACOBJ, TVal MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3EBF610", Offset = "0x3EBEA10", VA = "0x183EBF610")]
	private void KNFCGLOKCEK(BPIGOHCAIPF HOJECEOGPJG, TVal MEMCCCNHBPO, int KFHFOADDGMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DefaultMember("Item")]
public class JMGACHHJODC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<T> NODDPNCGJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HashSet<T> BGOFNLNDGJO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7FE0", Offset = "0x1EF73E0", VA = "0x181EF7FE0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool CHCGHNMIENC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x552EC0", Offset = "0x5522C0", VA = "0x180552EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public T DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x32735E0", Offset = "0x32729E0", VA = "0x1832735E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x42843C0", Offset = "0x42837C0", VA = "0x1842843C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2F33C70", Offset = "0x2F33070", VA = "0x182F33C70", Slot = "11")]
	public void Add(T CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4283E00", Offset = "0x4283200", VA = "0x184283E00")]
	public bool HPGJOBNABMC(T CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4284260", Offset = "0x4283660", VA = "0x184284260", Slot = "15")]
	public bool Remove(T CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F920", Offset = "0x3F6ED20", VA = "0x183F6F920", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FF8A10", Offset = "0x1FF7E10", VA = "0x181FF8A10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4283B20", Offset = "0x4282F20", VA = "0x184283B20", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x233E9F0", Offset = "0x233DDF0", VA = "0x18233E9F0", Slot = "13")]
	public bool Contains(T CBOKIMKBPGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3750C60", Offset = "0x3750060", VA = "0x183750C60", Slot = "14")]
	public void CopyTo(T[] INALBAMOJHE, int DLNBKPGJCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1EF4860", Offset = "0x1EF3C60", VA = "0x181EF4860", Slot = "6")]
	public int IndexOf(T CBOKIMKBPGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x4283EA0", Offset = "0x42832A0", VA = "0x184283EA0", Slot = "7")]
	public void Insert(int DBFCFFLFJDL, T CBOKIMKBPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x4284100", Offset = "0x4283500", VA = "0x184284100", Slot = "8")]
	public void RemoveAt(int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x4283C80", Offset = "0x4283080", VA = "0x184283C80")]
	public void EKBMAOKGGAN(Predicate<T> ECHCLPMDDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x4283B80", Offset = "0x4282F80", VA = "0x184283B80")]
	public void DDJFGCLKFAM(Comparison<T> GGKJJLEBFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x42842E0", Offset = "0x42836E0", VA = "0x1842842E0")]
	public JMGACHHJODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MMMIMKOHMNJ
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x4D21290", Offset = "0x4D20690", VA = "0x184D21290")]
	public static Vector3 GLMLPCELHLA(this GameObject OPNEJBACONM, float NHEAFDGONEO)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x1DC6A30", Offset = "0x1DC5E30", VA = "0x181DC6A30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4D23230", Offset = "0x4D22630", VA = "0x184D23230")]
		public SerializedGuid(in Guid DBNJDHBNKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x4D230E0", Offset = "0x4D224E0", VA = "0x184D230E0")]
		public static SerializedGuid ONKEHDJEGJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4D22F40", Offset = "0x4D22340", VA = "0x184D22F40")]
		public static SerializedGuid HPHLDNHCBEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4D22FC0", Offset = "0x4D223C0", VA = "0x184D22FC0")]
		public bool KPECOCAMEKL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4D23200", Offset = "0x4D22600", VA = "0x184D23200", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4D23160", Offset = "0x4D22560", VA = "0x184D23160", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4D23050", Offset = "0x4D22450", VA = "0x184D23050")]
		public bool OMFKDJAGFKD(in Guid DBNJDHBNKOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4D22DB0", Offset = "0x4D221B0", VA = "0x184D22DB0", Slot = "7")]
		public bool Equals(SerializedGuid OGCBGOIPCGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4D22E50", Offset = "0x4D22250", VA = "0x184D22E50", Slot = "0")]
		public override bool Equals(object CMGFKLKICHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x4D22F30", Offset = "0x4D22330", VA = "0x184D22F30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4D22D80", Offset = "0x4D22180", VA = "0x184D22D80", Slot = "6")]
		public int CompareTo(SerializedGuid OGCBGOIPCGM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class DKPGNIHPPCP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly Type HCENCBHNEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public readonly string JNECLNDGKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly bool GLBFJAOBMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public readonly bool MPFHNDJOFFB;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D6E0", Offset = "0x4D1CAE0", VA = "0x184D1D6E0")]
	public DKPGNIHPPCP(Type DEKCDAJCKNN, string KPICADIEJFB, bool PHDNOOGDKCJ = false, bool NKHCHEOAIGE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface JKPAEBOCBEG
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OOONCOPLELK<T> : JKPAEBOCBEG
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	T IKGDHNEELOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BPNEBMKFMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string LMFFGJFBFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::OOONCOPLELK<T> PAHIOBOFEKN(Action<T> PBFPNCHOPOO);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::OOONCOPLELK<T> GBKPAHJABIE(Action<T> PBFPNCHOPOO);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::OOONCOPLELK<T> JLGDKOBIGFP(Action<T, T> JLFCHAKDCBN);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::OOONCOPLELK<T> CAMCIDNCEFK(Action<T, T> JLFCHAKDCBN);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::OOONCOPLELK<T> NAGFEFBMNNB(Action<string> HGEGINJNLKD);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OOONCOPLELK<T> LMNANDEJLNN(Action<string> HGEGINJNLKD);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DJEEEHBMDCG<T> : global::OOONCOPLELK<T>, JKPAEBOCBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private global::BKEOHMPAIDF<T, T> DPFMKOBMOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private global::FGNOLOANHMP<T> OEBGJOGMKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private global::FGNOLOANHMP<string> LGOJDFBHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private string JDFDMBCBICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private T BLBGKFGAFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool NFNLLOKBMEG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public T IKGDHNEELOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x57AA30", Offset = "0x579E30", VA = "0x18057AA30", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1EF3930", Offset = "0x1EF2D30", VA = "0x181EF3930", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool BPNEBMKFMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5D48B0", Offset = "0x5D3CB0", VA = "0x1805D48B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string LMFFGJFBFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x57B0C0", Offset = "0x57A4C0", VA = "0x18057B0C0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2342130", Offset = "0x2341530", VA = "0x182342130", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2342090", Offset = "0x2341490", VA = "0x182342090")]
	private void DHOEGJJCPKM(T BEIEPHAKHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2342440", Offset = "0x2341840", VA = "0x182342440")]
	private void PPAGBKEEONP(string IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2342200", Offset = "0x2341600", VA = "0x182342200")]
	public void KMNIOBMPDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x23421B0", Offset = "0x23415B0", VA = "0x1823421B0", Slot = "6")]
	public global::OOONCOPLELK<T> JLGDKOBIGFP(Action<T, T> JLFCHAKDCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2342040", Offset = "0x2341440", VA = "0x182342040", Slot = "7")]
	public global::OOONCOPLELK<T> CAMCIDNCEFK(Action<T, T> JLFCHAKDCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x23423B0", Offset = "0x23417B0", VA = "0x1823423B0", Slot = "4")]
	public global::OOONCOPLELK<T> PAHIOBOFEKN(Action<T> JLFCHAKDCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2342160", Offset = "0x2341560", VA = "0x182342160", Slot = "5")]
	public global::OOONCOPLELK<T> GBKPAHJABIE(Action<T> PBFPNCHOPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2342320", Offset = "0x2341720", VA = "0x182342320", Slot = "8")]
	public global::OOONCOPLELK<T> NAGFEFBMNNB(Action<string> HGEGINJNLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x23422B0", Offset = "0x23416B0", VA = "0x1823422B0", Slot = "9")]
	public global::OOONCOPLELK<T> LMNANDEJLNN(Action<string> HGEGINJNLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x23424E0", Offset = "0x23418E0", VA = "0x1823424E0")]
	public DJEEEHBMDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class IKGJIPLFCNA
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class BFAAIPPLLNJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public global::OOONCOPLELK<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public global::OMINEPFFKOH<T> promise;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public BFAAIPPLLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2FA0", Offset = "0x2FA23A0", VA = "0x182FA2FA0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x1E73000", Offset = "0x1E72400", VA = "0x181E73000")]
	public static global::OIKEDAHIDPO<T> KMDOFKKILKD<T>(this global::OOONCOPLELK<T> EGFFLEGKDBI, Action<T> BKKOCCDDHJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class AJNEDCACPLG
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class LJBBAGKNAEP : AJNEDCACPLG
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static AJNEDCACPLG KFKKKAOCIAC
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x4D20FD0", Offset = "0x4D203D0", VA = "0x184D20FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public override DateTime ALCJHLEOIEL
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x4D20F70", Offset = "0x4D20370", VA = "0x184D20F70", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public override float NKICCIKKNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4D20FC0", Offset = "0x4D203C0", VA = "0x184D20FC0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4D210D0", Offset = "0x4D204D0", VA = "0x184D210D0")]
		public LJBBAGKNAEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static AJNEDCACPLG HHAFDLMHHFD;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static AJNEDCACPLG NHBAGNNNDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D0B0", Offset = "0x4D1C4B0", VA = "0x184D1D0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract DateTime ALCJHLEOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public abstract float NKICCIKKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	protected AJNEDCACPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PENNBABONAP : global::GLBJOIAFAFE<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4D21570", Offset = "0x4D20970", VA = "0x184D21570")]
	public PENNBABONAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GLBJOIAFAFE<T> : global::NBMOKNNNPGD<T>, CEGAIMNEPOD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Task<T> NDDKHGLPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Task HHOPFCNHPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C420", Offset = "0x1C1B820", VA = "0x181C1C420", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public global::OIKEDAHIDPO<T> GGFEIBNOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private DCCNBCFBHAJ KJKKHDEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FDC0", Offset = "0x1C1F1C0", VA = "0x181C1FDC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2F3DE50", Offset = "0x2F3D250", VA = "0x182F3DE50")]
	public GLBJOIAFAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class IFNPDHNGJPL : global::IDHEILNDPED<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FA00", Offset = "0x4D1EE00", VA = "0x184D1FA00")]
	public IFNPDHNGJPL(Exception OCJJHJBGOJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class IDHEILNDPED<T> : global::NBMOKNNNPGD<T>, CEGAIMNEPOD, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Task<T> NDDKHGLPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private Task HHOPFCNHPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C420", Offset = "0x1C1B820", VA = "0x181C1C420", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public global::OIKEDAHIDPO<T> GGFEIBNOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private DCCNBCFBHAJ KJKKHDEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FDC0", Offset = "0x1C1F1C0", VA = "0x181C1FDC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x2FACE50", Offset = "0x2FAC250", VA = "0x182FACE50")]
	public IDHEILNDPED(Exception OCJJHJBGOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface CEGAIMNEPOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	[NotNull]
	Task NDDKHGLPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[NotNull]
	DCCNBCFBHAJ GGFEIBNOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface NBMOKNNNPGD<T> : CEGAIMNEPOD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	[NotNull]
	new Task<T> NDDKHGLPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	[NotNull]
	new global::OIKEDAHIDPO<T> GGFEIBNOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class PJDENPLMDME<TTask, T> : global::NBMOKNNNPGD<T>, CEGAIMNEPOD, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class BEDBJCEDCMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public global::PJDENPLMDME<TTask, T> <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public BEDBJCEDCMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static bool AJJGMCOJFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly Task<T> KGEMAANMAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly CancellationTokenSource LKGLNOMGPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool LKPHLDJGJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SynchronizationContext BDBCPDLPAMH;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> NDDKHGLPIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task HHOPFCNHPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::OIKEDAHIDPO<T> GGFEIBNOGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private DCCNBCFBHAJ KJKKHDEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1F3E890", Offset = "0x1F3DC90", VA = "0x181F3E890", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool FMGPGEHBAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5D3990", Offset = "0x5D2D90", VA = "0x1805D3990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3664E80", Offset = "0x3664280", VA = "0x183664E80")]
	static PJDENPLMDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x36651A0", Offset = "0x36645A0", VA = "0x1836651A0")]
	protected PJDENPLMDME(TTask KGEMAANMAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x36648A0", Offset = "0x3663CA0", VA = "0x1836648A0", Slot = "1")]
	~PJDENPLMDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2F50230", Offset = "0x2F4F630", VA = "0x182F50230", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3664B50", Offset = "0x3663F50", VA = "0x183664B50")]
	private void HBDDIHGACID(bool NLDEMDBHFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T FNJJEBHOBPK(TTask KPCKFMLMEFK);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void FPLLKNCHCOG();

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3664CC0", Offset = "0x36640C0", VA = "0x183664CC0")]
	[CompilerGenerated]
	private void JJMCIKGPGAG(object DNMFIMLLNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DAFIHCEEDIN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly Type HCENCBHNEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string JNECLNDGKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly bool GLBFJAOBMKF;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D680", Offset = "0x4D1CA80", VA = "0x184D1D680")]
	public DAFIHCEEDIN(Type DEKCDAJCKNN, string KPICADIEJFB, bool PHDNOOGDKCJ = false)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x552ED0", Offset = "0x5522D0", VA = "0x180552ED0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x576710", Offset = "0x575B10", VA = "0x180576710")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public T this[int BOPGJDPNNAI, int JDGLKMMKBMB]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C560", Offset = "0x1C1B960", VA = "0x181C1C560")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C600", Offset = "0x1C1BA00", VA = "0x181C1C600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C4D0", Offset = "0x1C1B8D0", VA = "0x181C1C4D0")]
		public Array2D(uint PGJMBKLMNBH, uint FBPGHOCBINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C450", Offset = "0x1C1B850", VA = "0x181C1C450")]
		public void PDAIKLBALNI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4D1D230", Offset = "0x4D1C630", VA = "0x184D1D230")]
		public Array2DVector3(uint PGJMBKLMNBH, uint FBPGHOCBINA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal static class DLBKLKHJIEA
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const int PGEDIMAGFGI = -1;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const int BIKPBHOOHKP = 0;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[DefaultMember("Item")]
public class EGHOEMDNMHG<THandle, TValue> : IDisposable where THandle : struct, FPGNOEEIOFL where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<THandle> DEBFFNNGKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<TValue> AMNAGCLEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Func<TValue> BFHJIKGFINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Action<TValue> BHGHHLGDOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int NADMHPNIPNC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public TValue DHNKJMCOFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7550", Offset = "0x1EF6950", VA = "0x181EF7550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A8B0", Offset = "0x3B09CB0", VA = "0x183B0A8B0")]
	public EGHOEMDNMHG(Action<TValue> BHGHHLGDOEM, [Optional] Func<TValue> BFHJIKGFINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A2A0", Offset = "0x3B096A0", VA = "0x183B0A2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A1C0", Offset = "0x3B095C0", VA = "0x183B0A1C0")]
	public THandle DDAMABLPPOO()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A530", Offset = "0x3B09930", VA = "0x183B0A530")]
	public THandle KCLLGEJMGAB(TValue MGNFAPLJAOB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A3F0", Offset = "0x3B097F0", VA = "0x183B0A3F0")]
	public bool EPGMMIBEDJL(THandle HBMKOKCEHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x3B09F90", Offset = "0x3B09390", VA = "0x183B09F90")]
	public bool BMMIHMCNOML(THandle HBMKOKCEHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A790", Offset = "0x3B09B90", VA = "0x183B0A790")]
	public bool OPAPHKJEMEB(THandle HBMKOKCEHDC, out TValue MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A070", Offset = "0x3B09470", VA = "0x183B0A070")]
	public TValue CEDINIMJBIG(THandle HBMKOKCEHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A6E0", Offset = "0x3B09AE0", VA = "0x183B0A6E0")]
	public bool MOHGLDOANJE(THandle HBMKOKCEHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A4E0", Offset = "0x3B098E0", VA = "0x183B0A4E0")]
	private THandle FNAANMGENBG(int DBFCFFLFJDL)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A5A0", Offset = "0x3B099A0", VA = "0x183B0A5A0")]
	private TValue KMDOFKKILKD(int DBFCFFLFJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A4A0", Offset = "0x3B098A0", VA = "0x183B0A4A0")]
	private void FMHDGIMJGAJ(int DBFCFFLFJDL, in THandle HBMKOKCEHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A260", Offset = "0x3B09660", VA = "0x183B0A260")]
	private void DHOEGJJCPKM(int DBFCFFLFJDL, in TValue MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A5D0", Offset = "0x3B099D0", VA = "0x183B0A5D0")]
	private THandle LCCENKPDMCL()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3B09DB0", Offset = "0x3B091B0", VA = "0x183B09DB0")]
	private void BAIHKOJDOAE(THandle HBMKOKCEHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A520", Offset = "0x3B09920", VA = "0x183B0A520")]
	private int IALIIMHBOII(int BNNMAOPHHMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A510", Offset = "0x3B09910", VA = "0x183B0A510")]
	private bool GFBPHCPDAGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5A39A0", Offset = "0x5A2DA0", VA = "0x1805A39A0")]
	private void CAPBJPFEMIP(THandle HBMKOKCEHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A830", Offset = "0x3B09C30", VA = "0x183B0A830")]
	private bool PNLBAMECLGM(out THandle HBMKOKCEHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A320", Offset = "0x3B09720", VA = "0x183B0A320")]
	private bool ELPMDMGOMFH(out THandle HBMKOKCEHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A0C0", Offset = "0x3B094C0", VA = "0x183B0A0C0")]
	private void DBNIGHHLLDM(THandle HBMKOKCEHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x3B09E70", Offset = "0x3B09270", VA = "0x183B09E70")]
	private void BKPHCJCMNAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FPGNOEEIOFL
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	int EEKKOADMDBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	int OACAMHLIHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EKIGKPCJPCI<T> : FPGNOEEIOFL, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class KEKMFIPHHGO
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x20E32F0", Offset = "0x20E26F0", VA = "0x1820E32F0")]
	public static bool GFFPKPIOFFN<T>(this T HBMKOKCEHDC) where T : struct, FPGNOEEIOFL
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EHEIOHHGBPG
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	private enum NJBCIBKLHOI : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int HOIJMIKCIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool LPHJAPIKKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NJBCIBKLHOI FDPFLDBNIDI;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool FHPNLCMAFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4D1DE20", Offset = "0x4D1D220", VA = "0x184D1DE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool JGMDILEFJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4D1E3E0", Offset = "0x4D1D7E0", VA = "0x184D1E3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E650", Offset = "0x4D1DA50", VA = "0x184D1E650")]
	public EHEIOHHGBPG(bool LPHJAPIKKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1D870", Offset = "0x4D1CC70", VA = "0x184D1D870")]
	public void ANGEBMFAHII(object CMGFKLKICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E5A0", Offset = "0x4D1D9A0", VA = "0x184D1E5A0")]
	public void PJBEJLDCKAF(int MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E510", Offset = "0x4D1D910", VA = "0x184D1E510")]
	public void OHHGMKNDEGL(uint BGLGHODKIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DE00", Offset = "0x4D1D200", VA = "0x184D1DE00")]
	public void DMFBHCBHHJB(bool FPPJHGNJGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E1F0", Offset = "0x4D1D5F0", VA = "0x184D1E1F0")]
	public void ELHHKCIMLFA(long OHMLAHMIJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E4D0", Offset = "0x4D1D8D0", VA = "0x184D1E4D0")]
	public void IOADFAGHOLI(ulong EBPNBGGEONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E520", Offset = "0x4D1D920", VA = "0x184D1E520")]
	public void ONIJJOCPIJD(string NJLPAIJKDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E230", Offset = "0x4D1D630", VA = "0x184D1E230")]
	public void FLOJPGLGKNO(Enum OCJJHJBGOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E2C0", Offset = "0x4D1D6C0", VA = "0x184D1E2C0")]
	public void HDJFMFCMBGD(IList NODDPNCGJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2203D20", Offset = "0x2203120", VA = "0x182203D20")]
	public void HFNMMBCEIPO<T, U>(Dictionary<T, U> IPOFNIBPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DE30", Offset = "0x4D1D230", VA = "0x184D1DE30")]
	private void EEJKFJFLIEI(IDictionary IPOFNIBPFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E3F0", Offset = "0x4D1D7F0", VA = "0x184D1E3F0")]
	public int HKDHOIDMLKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E460", Offset = "0x4D1D860", VA = "0x184D1E460")]
	public short HPPJADKMJJB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E590", Offset = "0x4D1D990", VA = "0x184D1E590")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1DD90", Offset = "0x4D1D190", VA = "0x184D1DD90")]
	private void CPBOPIBNJJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class JAAABBONBOA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal class GFIJJJGHCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public TNode DDGLIDGJCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public TNode PDIGOPINEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public EFEILBPBFED BJBBMMOBBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<EFEILBPBFED> IEECLIIFADC;

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		public GFIJJJGHCLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct EFEILBPBFED : IComparable<EFEILBPBFED>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int DFOAIJHGLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public TClaimant PDLAECANPDF;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x55ACF0", Offset = "0x55A0F0", VA = "0x18055ACF0")]
		public EFEILBPBFED(int DFOAIJHGLEC, TClaimant PDLAECANPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x24B30C0", Offset = "0x24B24C0", VA = "0x1824B30C0")]
		public bool BHGPJIOEJPI(in EFEILBPBFED OGCBGOIPCGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x24B3130", Offset = "0x24B2530", VA = "0x1824B3130")]
		public bool JKKCIPLMHPI(in EFEILBPBFED OGCBGOIPCGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x24B3120", Offset = "0x24B2520", VA = "0x1824B3120", Slot = "4")]
		public int CompareTo(EFEILBPBFED OGCBGOIPCGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x24B3140", Offset = "0x24B2540", VA = "0x1824B3140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum IBHBCLJCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class OEBDFHNBJHB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::JAAABBONBOA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1EEE830", Offset = "0x1EEDC30", VA = "0x181EEE830")]
		[DebuggerHidden]
		public OEBDFHNBJHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x24CE640", Offset = "0x24CDA40", VA = "0x1824CE640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x24CE800", Offset = "0x24CDC00", VA = "0x1824CE800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x24CE720", Offset = "0x24CDB20", VA = "0x1824CE720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1C2C230", Offset = "0x1C2B630", VA = "0x181C2C230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly global::OKMKOJPNKDG<GFIJJJGHCLC> OFMJDBALCFK;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly global::OKMKOJPNKDG<List<EFEILBPBFED>> KODPOJNLPJI;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int BNOALKDCAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	internal readonly Dictionary<TClaimant, TNode> JGNGMJEAJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	internal readonly Dictionary<TNode, GFIJJJGHCLC> IBPFLDHGILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IBHBCLJCBPE IHAPPEONNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool JIAGLECDCJM;

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode HMOGOJDMMOE(TNode FKKCOCJCKAD);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GEOHNALBGKG(TNode FKKCOCJCKAD, TClaimant CJCHJDPNHBB, TClaimant MLLLMFOODPE);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x24C1270", Offset = "0x24C0670", VA = "0x1824C1270")]
	public JAAABBONBOA(IBHBCLJCBPE IHAPPEONNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x24C0AC0", Offset = "0x24BFEC0", VA = "0x1824C0AC0")]
	public void JFFDMEKBHOG(TNode FKKCOCJCKAD, TNode BEJACBLGALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x24BFA10", Offset = "0x24BEE10", VA = "0x1824BFA10")]
	public void APKBBNBBDBC(TClaimant PDLAECANPDF, TNode BEDIFGOMMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x24C02B0", Offset = "0x24BF6B0", VA = "0x1824C02B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x24C0210", Offset = "0x24BF610", VA = "0x1824C0210")]
	private void DHPEJEHPKDL(TClaimant PDLAECANPDF, TNode AFEIBDLNLNH, TNode BEDIFGOMMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x24C0D00", Offset = "0x24C0100", VA = "0x1824C0D00")]
	private int LHLKGHIODIP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x24C0810", Offset = "0x24BFC10", VA = "0x1824C0810")]
	private void IMGENIFFGED(TClaimant PDLAECANPDF, TNode BDKBFPJOIOP, TNode MOGEPJGKFOI, int PCCMGLEEFMO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x24C0510", Offset = "0x24BF910", VA = "0x1824C0510")]
	private void GGJCKPKLOFO(EFEILBPBFED OBOPJNEGLCC, GFIJJJGHCLC PLOIENHNMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x24C05A0", Offset = "0x24BF9A0", VA = "0x1824C05A0")]
	private void HHHHMIPAPGE(TClaimant PDLAECANPDF, TNode BDKBFPJOIOP, TNode MOGEPJGKFOI, int PCCMGLEEFMO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x24C0110", Offset = "0x24BF510", VA = "0x1824C0110")]
	private void CDBBHOKMMGK(EFEILBPBFED OBOPJNEGLCC, TNode FKKCOCJCKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x24BFF50", Offset = "0x24BF350", VA = "0x1824BFF50")]
	private void BKGHJMGFLNH(EFEILBPBFED OBOPJNEGLCC, GFIJJJGHCLC PLOIENHNMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x24C0E40", Offset = "0x24C0240", VA = "0x1824C0E40")]
	private void NNIOIAPGAAE(GFIJJJGHCLC PLOIENHNMPE, bool NFBJMOMIKKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x24BFB10", Offset = "0x24BEF10", VA = "0x1824BFB10")]
	private void BJCFKJDPKHB(GFIJJJGHCLC PLOIENHNMPE, TNode BEJACBLGALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x24C0D70", Offset = "0x24C0170", VA = "0x1824C0D70")]
	[IteratorStateMachine(typeof(global::JAAABBONBOA<, >.OEBDFHNBJHB))]
	private IEnumerable<TNode> MMPEGKFECPD(TNode BDKBFPJOIOP, TNode MOGEPJGKFOI, bool NJEGGKGEEMO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x24C0050", Offset = "0x24BF450", VA = "0x1824C0050")]
	private GFIJJJGHCLC CBNCAGDCHFA(TNode FKKCOCJCKAD, TNode PDIGOPINEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x24C0F80", Offset = "0x24C0380", VA = "0x1824C0F80")]
	private GFIJJJGHCLC OHECFCGIFJI(TNode FKKCOCJCKAD, TNode PDIGOPINEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x24C0B40", Offset = "0x24BFF40", VA = "0x1824C0B40")]
	private void JGDOHFGCGCG(GFIJJJGHCLC PLOIENHNMPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class MMNAMPNLBIB<T> : IEnumerable<global::MMNAMPNLBIB<T>.EBPKCKKNNFF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct EBPKCKKNNFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T MGNFAPLJAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int DBFCFFLFJDL;
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class IKIMLBCDNMA : IEnumerator<EBPKCKKNNFF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private global::MMNAMPNLBIB<T> FAHPLPOKBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int DBFCFFLFJDL;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x27E6490", Offset = "0x27E5890", VA = "0x1827E6490", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EBPKCKKNNFF PODANKLJMIE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2C4A080", Offset = "0x2C49480", VA = "0x182C4A080", Slot = "4")]
			get
			{
				return default(EBPKCKKNNFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A2D30", Offset = "0x8A2130", VA = "0x1808A2D30")]
		public IKIMLBCDNMA(global::MMNAMPNLBIB<T> FAHPLPOKBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C49FF0", Offset = "0x2C493F0", VA = "0x182C49FF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8065B0", Offset = "0x8059B0", VA = "0x1808065B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x83AD40", Offset = "0x83A140", VA = "0x18083AD40", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct FHCGMEFBFPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool BEPBLLLGNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public T MGNFAPLJAOB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int LHJHHOPDJKP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private Dictionary<T, int> BMIHJEGFGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private FHCGMEFBFPO[] FLJDLFPMGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int BHKPNIMHBIF;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1EF8010", Offset = "0x1EF7410", VA = "0x181EF8010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F000", Offset = "0x2C4E400", VA = "0x182C4F000")]
	public static global::MMNAMPNLBIB<T> LIHOCNCBFML(EBPKCKKNNFF[] LCNOOIDMEEJ, bool PBMIJNIDNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F600", Offset = "0x2C4EA00", VA = "0x182C4F600")]
	public MMNAMPNLBIB(int KJJBHCMHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E9C0", Offset = "0x2C4DDC0", VA = "0x182C4E9C0")]
	public bool CHLPDFDHKDN(T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EB60", Offset = "0x2C4DF60", VA = "0x182C4EB60")]
	public bool DFMKMLGLNFM(int DBFCFFLFJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F480", Offset = "0x2C4E880", VA = "0x182C4F480")]
	public bool OMFGGLAJBGI(Func<T, bool> DMIPNDECKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F430", Offset = "0x2C4E830", VA = "0x182C4F430")]
	public int NEKNIHFLBBC(T MGNFAPLJAOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EF90", Offset = "0x2C4E390", VA = "0x182C4EF90")]
	public T KMDOFKKILKD(int DBFCFFLFJDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F530", Offset = "0x2C4E930", VA = "0x182C4F530")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EF70", Offset = "0x2C4E370", VA = "0x182C4EF70")]
	public bool HPGJOBNABMC(T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C4ED40", Offset = "0x2C4E140", VA = "0x182C4ED40")]
	public bool HPGJOBNABMC(T MGNFAPLJAOB, int DBFCFFLFJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EC10", Offset = "0x2C4E010", VA = "0x182C4EC10")]
	public bool EPGMMIBEDJL(T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EBC0", Offset = "0x2C4DFC0", VA = "0x182C4EBC0")]
	public bool DNCCJHOKHFG(int DBFCFFLFJDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C4EC90", Offset = "0x2C4E090", VA = "0x182C4EC90")]
	private void GFBBLLOHAEK(int DBFCFFLFJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C4E9F0", Offset = "0x2C4DDF0", VA = "0x182C4E9F0")]
	public EBPKCKKNNFF[] CLPJPLOKDGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F3E0", Offset = "0x2C4E7E0", VA = "0x182C4F3E0")]
	private int MEAENHCPNOE(int LLBPABECDNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F580", Offset = "0x2C4E980", VA = "0x182C4F580", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C4F580", Offset = "0x2C4E980", VA = "0x182C4F580", Slot = "4")]
	private IEnumerator<EBPKCKKNNFF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OKMKOJPNKDG<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly Stack<T> DBMLIKOMENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<T> DMJGLAICAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly int CKCHDMNPJAN;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public int KHMONBCCGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1C21F80", Offset = "0x1C21380", VA = "0x181C21F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int BCOFECAFOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B66920", Offset = "0x2B65D20", VA = "0x182B66920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x36FC090", Offset = "0x36FB490", VA = "0x1836FC090")]
	public static global::OKMKOJPNKDG<T> MFGJDIKOFDD(int KJJBHCMHFJM = 0, int CKCHDMNPJAN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x36FBFC0", Offset = "0x36FB3C0", VA = "0x1836FBFC0")]
	public static global::OKMKOJPNKDG<T> LIMJEHEBPHM(int KJJBHCMHFJM = 0, int CKCHDMNPJAN = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x36FC4B0", Offset = "0x36FB8B0", VA = "0x1836FC4B0")]
	public OKMKOJPNKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x36FC320", Offset = "0x36FB720", VA = "0x1836FC320")]
	public OKMKOJPNKDG(int KJJBHCMHFJM, int CKCHDMNPJAN = int.MaxValue, bool MGOEFJGLNHK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x36FBE70", Offset = "0x36FB270", VA = "0x1836FBE70")]
	public T EANPDNNNOLD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x36FBBF0", Offset = "0x36FAFF0", VA = "0x1836FBBF0")]
	public void DJFKFFLPMOI(T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x36FBA90", Offset = "0x36FAE90", VA = "0x1836FBA90")]
	private void BHBIGAALOIB(T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x36FBFA0", Offset = "0x36FB3A0", VA = "0x1836FBFA0")]
	private void HBOEHOIHGMM(T MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x36FBB50", Offset = "0x36FAF50", VA = "0x1836FBB50")]
	[Conditional("DEBUG_BUILD")]
	private void CMLOCLKOKOL(T JOEGFHBCGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x36FBCB0", Offset = "0x36FB0B0", VA = "0x1836FBCB0")]
	[Conditional("DEBUG_BUILD")]
	private void DMFHEPBDANA(T JOEGFHBCGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x36FBD60", Offset = "0x36FB160", VA = "0x1836FBD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x36FC160", Offset = "0x36FB560", VA = "0x1836FC160")]
	private void NKMAHNEPMEO(IEnumerable<T> AMNAGCLEGPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class BMDKCNLILAN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Dictionary<int, T> LAOJLGDANJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private T HICGIPKKEHJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public virtual T DDOLCJJEEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5524A0", Offset = "0x5518A0", VA = "0x1805524A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool NNABBHPBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x3BCA9C0", Offset = "0x3BC9DC0", VA = "0x183BCA9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA960", Offset = "0x3BC9D60", VA = "0x183BCA960")]
	public bool PGADOPELPNL(T MGNFAPLJAOB, int DFOAIJHGLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA1D0", Offset = "0x3BC95D0", VA = "0x183BCA1D0")]
	public bool CAAPKADMLNG(int DFOAIJHGLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA4A0", Offset = "0x3BC98A0", VA = "0x183BCA4A0")]
	public T CPPCDALJCOK(int IHBDAOEFOMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA8A0", Offset = "0x3BC9CA0", VA = "0x183BCA8A0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA810", Offset = "0x3BC9C10", VA = "0x183BCA810")]
	private bool OODGOIDAKAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA1A0", Offset = "0x3BC95A0", VA = "0x183BCA1A0")]
	public bool BIAHFFMAKML(int DFOAIJHGLEC, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2EB14A0", Offset = "0x2EB08A0", VA = "0x182EB14A0")]
	public BMDKCNLILAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GFMGOGIHFFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	protected struct CIEFBNCKEJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public T IKGDHNEELOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int MKDHIDDHFPJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	protected readonly List<CIEFBNCKEJC> DHBJDHCKMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T MFGLFEOCIIP;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1EF7FE0", Offset = "0x1EF73E0", VA = "0x181EF7FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F39F40", Offset = "0x2F39340", VA = "0x182F39F40")]
	public bool OMFGGLAJBGI(T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2F39C20", Offset = "0x2F39020", VA = "0x182F39C20")]
	public void KCLLGEJMGAB(T MGNFAPLJAOB, int DFOAIJHGLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F39A70", Offset = "0x2F38E70", VA = "0x182F39A70")]
	public bool EPGMMIBEDJL(T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A190", Offset = "0x2F39590", VA = "0x182F3A190")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2F39B90", Offset = "0x2F38F90", VA = "0x182F39B90")]
	public T HGMJHCLCAMB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2F39CC0", Offset = "0x2F390C0", VA = "0x182F39CC0")]
	public T LCDJPDLHJIF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x2F39D30", Offset = "0x2F39130", VA = "0x182F39D30")]
	private void OLABDODLLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2F3A1F0", Offset = "0x2F395F0", VA = "0x182F3A1F0")]
	public GFMGOGIHFFC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[JGOEDCMEHLE(KOOLODOPKJP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x4D21790", Offset = "0x4D20B90", VA = "0x184D21790")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x4D21C60", Offset = "0x4D21060", VA = "0x184D21C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x4D21A80", Offset = "0x4D20E80", VA = "0x184D21A80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x4D21E00", Offset = "0x4D21200", VA = "0x184D21E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x4D21650", Offset = "0x4D20A50", VA = "0x184D21650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D21B20", Offset = "0x4D20F20", VA = "0x184D21B20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x4D21940", Offset = "0x4D20D40", VA = "0x184D21940")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D215B0", Offset = "0x4D209B0", VA = "0x184D215B0")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface FMOKKGONMKP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public abstract class ResourcePrefabReference<T> : FMOKKGONMKP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1C2BF60", Offset = "0x1C2B360", VA = "0x181C2BF60", Slot = "4")]
		public virtual T BGGNGEKLILH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KJKKPNFHGDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<byte, HGPJDFAKALA> AEFOFOFDEEE;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public HGPJDFAKALA HPLLEKLCIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector2 KCHLPOGMFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x12E66B0", Offset = "0x12E5AB0", VA = "0x1812E66B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2EABED0", Offset = "0x2EAB2D0", VA = "0x182EABED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Vector2 BOJBJAJCGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x15532B0", Offset = "0x15526B0", VA = "0x1815532B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1553340", Offset = "0x1552740", VA = "0x181553340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector2 CONDLECMEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x377DE60", Offset = "0x377D260", VA = "0x18377DE60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x377DE80", Offset = "0x377D280", VA = "0x18377DE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HGFBJICCKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x57D7E0", Offset = "0x57CBE0", VA = "0x18057D7E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5A39A0", Offset = "0x5A2DA0", VA = "0x1805A39A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D20A50", Offset = "0x4D1FE50", VA = "0x184D20A50")]
	public KJKKPNFHGDF(Bounds MDGAKGBHPNO, Vector2[] FBBOOFIFNED, int JLMIILILMFK, byte LLBPABECDNP, float CNNJGFLEBGJ = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D209F0", Offset = "0x4D1FDF0", VA = "0x184D209F0")]
	public HGPJDFAKALA PAOJJCGIOON(byte DBFCFFLFJDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x4D203C0", Offset = "0x4D1F7C0", VA = "0x184D203C0")]
	public void KNOKGICEOMO(Vector3 FPKNBMBNOOF, float DAHIMCEJJKJ, float LDNPLACBGFJ, ref List<byte> IGGNGDEKCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x4D209D0", Offset = "0x4D1FDD0", VA = "0x184D209D0")]
	public void NEKANIHMMOL(HGPJDFAKALA.HMBHPKPFHNA COEHDANKLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x4D20290", Offset = "0x4D1F690", VA = "0x184D20290")]
	private HGPJDFAKALA HHBDNAKAANH(byte DBFCFFLFJDL, HGPJDFAKALA.LMPBGOLPHJP KGDKCIKEFOH, HGPJDFAKALA PDIGOPINEPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x4D204B0", Offset = "0x4D1F8B0", VA = "0x184D204B0")]
	private void MKPEBFPECOJ(HGPJDFAKALA PDIGOPINEPN, Vector2[] FBBOOFIFNED, int EEEGLPDOOKB, int BCAOPOBPHOD, int OLCKCNILNGK, int FAMEELIFMBB, float CNNJGFLEBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class HGPJDFAKALA
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum LMPBGOLPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum HMBHPKPFHNA
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte ACLJPPHAFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public Vector3 IDBHAGCEAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Vector3 OMJCACLPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3 COIPEABOCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Vector3 BFPPFIEKLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public LMPBGOLPHJP GFFEJCOCCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public HGPJDFAKALA JHIMGLCOEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public List<HGPJDFAKALA> NAPMHCOLIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool KAMEIOJPPAC;

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F900", Offset = "0x4D1ED00", VA = "0x184D1F900")]
	public HGPJDFAKALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F8A0", Offset = "0x4D1ECA0", VA = "0x184D1F8A0")]
	public HGPJDFAKALA(byte MGMHKIPIHKD, LMPBGOLPHJP KGDKCIKEFOH, HGPJDFAKALA PDIGOPINEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F800", Offset = "0x4D1EC00", VA = "0x184D1F800")]
	public void OLIONOHLNCL(HGPJDFAKALA NFDIOFNFDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80")]
	public void NEKANIHMMOL(int DCAPNPOFGEE, HMBHPKPFHNA COEHDANKLIG, int KMBBICFKMIN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F530", Offset = "0x4D1E930", VA = "0x184D1F530")]
	public void KNOKGICEOMO(List<byte> IGGNGDEKCDB, Vector3 FPKNBMBNOOF, float DAHIMCEJJKJ, float LDNPLACBGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F4D0", Offset = "0x4D1E8D0", VA = "0x184D1F4D0")]
	public bool CCDNFEFJGCN(Vector3 PIHBNCCGJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F7C0", Offset = "0x4D1EBC0", VA = "0x184D1F7C0")]
	public bool MDCGHGKGLAC(Vector3 PIHBNCCGJFN, float FBLHFJJMAOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class DKGEEOCOABD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly Dictionary<T, object> EGEKKCLDLDP;

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x233F0E0", Offset = "0x233E4E0", VA = "0x18233F0E0")]
	public bool EEIGLABIFEM(T IBIPPJBIHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2343270", Offset = "0x2342670", VA = "0x182343270")]
	public bool EEIGLABIFEM(T IBIPPJBIHGA, object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x23432B0", Offset = "0x23426B0", VA = "0x1823432B0")]
	public bool EEIGLABIFEM(T IBIPPJBIHGA, object ANBIAABLBGM, out object JKBJOJAFMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2343350", Offset = "0x2342750", VA = "0x182343350")]
	public bool PGKKPHMMBIK(T IBIPPJBIHGA, object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2343310", Offset = "0x2342710", VA = "0x182343310")]
	public bool OPPDHGAFFPC(T IBIPPJBIHGA, object ANBIAABLBGM, out object JKBJOJAFMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2343390", Offset = "0x2342790", VA = "0x182343390")]
	public bool PGKKPHMMBIK(T IBIPPJBIHGA, object ANBIAABLBGM, out object JKBJOJAFMPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x23431A0", Offset = "0x23425A0", VA = "0x1823431A0")]
	public void AFHHBNPCCJB(T IBIPPJBIHGA, object ANBIAABLBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x23431D0", Offset = "0x23425D0", VA = "0x1823431D0")]
	public void ALPAIMENOBE(T IBIPPJBIHGA, object ANBIAABLBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x2343420", Offset = "0x2342820", VA = "0x182343420")]
	public DKGEEOCOABD()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct NPPEPFOMGMN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private readonly List<Component> NODDPNCGJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private readonly bool PLOFFKKOKFP;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x7B1880", Offset = "0x7B0C80", VA = "0x1807B1880")]
			public NPPEPFOMGMN(List<Component> NODDPNCGJJL, bool PLOFFKKOKFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x1C28B60", Offset = "0x1C27F60", VA = "0x181C28B60")]
			public DIMIMDLHDLN<T> DGONKCCFOLN()
			{
				return default(DIMIMDLHDLN<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x1C28BD0", Offset = "0x1C27FD0", VA = "0x181C28BD0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x1C28BD0", Offset = "0x1C27FD0", VA = "0x181C28BD0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct DIMIMDLHDLN<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private readonly List<Component> NODDPNCGJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private readonly bool PLOFFKKOKFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private int DBFCFFLFJDL;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public T PODANKLJMIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x1C20710", Offset = "0x1C1FB10", VA = "0x181C20710", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0x1C206A0", Offset = "0x1C1FAA0", VA = "0x181C206A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x1C206E0", Offset = "0x1C1FAE0", VA = "0x181C206E0")]
			public DIMIMDLHDLN(List<Component> NODDPNCGJJL, bool PLOFFKKOKFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x1C205D0", Offset = "0x1C1F9D0", VA = "0x181C205D0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x1C205E0", Offset = "0x1C1F9E0", VA = "0x181C205E0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x1C20690", Offset = "0x1C1FA90", VA = "0x181C20690", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x4D23AC0", Offset = "0x4D22EC0", VA = "0x184D23AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x4D23A80", Offset = "0x4D22E80", VA = "0x184D23A80")]
		public ToolHierarchyCache(GameObject HLKCHJAOJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x4D23570", Offset = "0x4D22970", VA = "0x184D23570")]
		private void JBPGKBOBEDK(GameObject HLKCHJAOJOJ, bool LNDFBPMLFOA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x4D23690", Offset = "0x4D22A90", VA = "0x184D23690")]
		public static void JBPGKBOBEDK(GameObject HLKCHJAOJOJ, ref ToolHierarchyCache AFKOFAEODLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x4D23260", Offset = "0x4D22660", VA = "0x184D23260")]
		public void EANHGMGNJIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4D23720", Offset = "0x4D22B20", VA = "0x184D23720")]
		public void KDABDMIGFDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x21AD320", Offset = "0x21AC720", VA = "0x1821AD320")]
		public void KHFGKBGBJBM<T>(Action<T> MOOMHHEHKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x4D234B0", Offset = "0x4D228B0", VA = "0x184D234B0")]
		public Component IGONIMFEDGF(Type HHDFIJECABM, bool PLOFFKKOKFP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1E14430", Offset = "0x1E13830", VA = "0x181E14430")]
		public T IGONIMFEDGF<T>(bool PLOFFKKOKFP = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x4D23420", Offset = "0x4D22820", VA = "0x184D23420")]
		public NPPEPFOMGMN<Component> HFMNHKLPHHC(Type HHDFIJECABM, bool PLOFFKKOKFP = false)
		{
			return default(NPPEPFOMGMN<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x2835AC0", Offset = "0x2834EC0", VA = "0x182835AC0")]
		public NPPEPFOMGMN<T> HFMNHKLPHHC<T>(bool PLOFFKKOKFP = false) where T : class
		{
			return default(NPPEPFOMGMN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4D23770", Offset = "0x4D22B70", VA = "0x184D23770")]
		public List<Component> LIDFDJGGMKD(Type HHDFIJECABM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4D23330", Offset = "0x4D22730", VA = "0x184D23330", Slot = "4")]
		public bool Equals(ToolHierarchyCache JEPLLBBBDFO, ToolHierarchyCache BDJKNLLCOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4D233B0", Offset = "0x4D227B0", VA = "0x184D233B0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CMGFKLKICHP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class EBKPOEPIHLM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int KJJBHCMHFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int OJHAJGFPOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<T> GGKBIBBPFEB;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1C21F80", Offset = "0x1C21380", VA = "0x181C21F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public T MKDBJDGKENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x3D02FC0", Offset = "0x3D023C0", VA = "0x183D02FC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public T KHMCCDBHGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x3D02C70", Offset = "0x3D02070", VA = "0x183D02C70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public T LENMIAPKODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3D031A0", Offset = "0x3D025A0", VA = "0x183D031A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x3D031F0", Offset = "0x3D025F0", VA = "0x183D031F0")]
	public EBKPOEPIHLM(int KJJBHCMHFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x3D02DC0", Offset = "0x3D021C0", VA = "0x183D02DC0")]
	public void KCLLGEJMGAB(T OPGDFGBEFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x3D030E0", Offset = "0x3D024E0", VA = "0x183D030E0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x3D02D20", Offset = "0x3D02120", VA = "0x183D02D20")]
	public void FCPLJJNBKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x3D02F70", Offset = "0x3D02370", VA = "0x183D02F70")]
	public void LCAKHDBBDJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x3D03120", Offset = "0x3D02520", VA = "0x183D03120")]
	public void PGDFBJCFOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class FJLMBBOGJJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool KKJPBFLFJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Action MOOMHHEHKEJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public static FJLMBBOGJJM KCBGDOEMDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x4D1EA50", Offset = "0x4D1DE50", VA = "0x184D1EA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool NLIAJPDLOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x57D7B0", Offset = "0x57CBB0", VA = "0x18057D7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x88C6F0", Offset = "0x88BAF0", VA = "0x18088C6F0")]
	public FJLMBBOGJJM(Action MOOMHHEHKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EA30", Offset = "0x4D1DE30", VA = "0x184D1EA30")]
	public void KNOFFOGILML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EA30", Offset = "0x4D1DE30", VA = "0x184D1EA30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class DLNFKJJHIIH
{
	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80")]
	public static void LFNMABFFEOJ(EOIJJEFJAEF ILFDINHCIBP, string CDFIONJNBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class NGKOFOOGAHH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private struct GEJNDJMGJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int MKDHIDDHFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public T IKGDHNEELOA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<object, GEJNDJMGJDJ> LAOJLGDANJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private T HICGIPKKEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public virtual T DDOLCJJEEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x12E66B0", Offset = "0x12E5AB0", VA = "0x1812E66B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2EABED0", Offset = "0x2EAB2D0", VA = "0x182EABED0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool NNABBHPBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2EB1470", Offset = "0x2EB0870", VA = "0x182EB1470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public object LNPGHLAKHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x57CD70", Offset = "0x57C170", VA = "0x18057CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0FB0", Offset = "0x2EB03B0", VA = "0x182EB0FB0")]
	public bool PGADOPELPNL(T MGNFAPLJAOB, object ANBIAABLBGM, int DFOAIJHGLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2EABE20", Offset = "0x2EAB220", VA = "0x182EABE20")]
	public bool CAAPKADMLNG(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2EABB40", Offset = "0x2EAAF40", VA = "0x182EABB40")]
	public bool BIAHFFMAKML(object ANBIAABLBGM, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2EAAFC0", Offset = "0x2EAA3C0", VA = "0x182EAAFC0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2EAFA60", Offset = "0x2EAEE60", VA = "0x182EAFA60")]
	private bool OODGOIDAKAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2EB14A0", Offset = "0x2EB08A0", VA = "0x182EB14A0")]
	public NGKOFOOGAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class JBNNIIFGENG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Dictionary<object, float> LAOJLGDANJL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float EDCJBGDJNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xFF9320", Offset = "0xFF8720", VA = "0x180FF9320")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xD7F260", Offset = "0xD7E660", VA = "0x180D7F260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FD30", Offset = "0x4D1F130", VA = "0x184D1FD30")]
	public void PGADOPELPNL(float MGNFAPLJAOB, object ANBIAABLBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FBA0", Offset = "0x4D1EFA0", VA = "0x184D1FBA0")]
	public void CAAPKADMLNG(object ANBIAABLBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FC10", Offset = "0x4D1F010", VA = "0x184D1FC10")]
	private void ONDGDBBLNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FDA0", Offset = "0x4D1F1A0", VA = "0x184D1FDA0")]
	public JBNNIIFGENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public sealed class EOIJJEFJAEF
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class OKFLEKKAAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly string NHJFLMFMMJC;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		private OKFLEKKAAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6B3A70", Offset = "0x6B2E70", VA = "0x1806B3A70")]
		public OKFLEKKAAMP(string NHJFLMFMMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4D21520", Offset = "0x4D20920", VA = "0x184D21520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class INDCMNPKBID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public INDCMNPKBID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x4D1FA50", Offset = "0x4D1EE50", VA = "0x184D1FA50")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly HashSet<object> POGANJMBJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int NFAHNDFBJFN;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool JNFPCEKJIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4D1E680", Offset = "0x4D1DA80", VA = "0x184D1E680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int MKAOECNIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE670", Offset = "0x5DDA70", VA = "0x1805DE670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E770", Offset = "0x4D1DB70", VA = "0x184D1E770")]
	public bool KCLLGEJMGAB(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E690", Offset = "0x4D1DA90", VA = "0x184D1E690")]
	public bool EPGMMIBEDJL(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E7F0", Offset = "0x4D1DBF0", VA = "0x184D1E7F0")]
	public bool OMFGGLAJBGI(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E710", Offset = "0x4D1DB10", VA = "0x184D1E710")]
	public void GFMMHEEDCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E850", Offset = "0x4D1DC50", VA = "0x184D1E850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4D1E9C0", Offset = "0x4D1DDC0", VA = "0x184D1E9C0")]
	public EOIJJEFJAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class ALLGLDPDFBM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct DLKGPMEDOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float IBDHLDLDGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public T IKGDHNEELOA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private Dictionary<object, DLKGPMEDOLC> LAOJLGDANJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private T AKELNLJGNKM;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public virtual T LHOMCOBBOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1A40800", Offset = "0x1A3FC00", VA = "0x181A40800", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2EABF40", Offset = "0x2EAB340", VA = "0x182EABF40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public object INNIJMAOIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x554DF0", Offset = "0x5541F0", VA = "0x180554DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6963A0", Offset = "0x6957A0", VA = "0x1806963A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NNABBHPBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A010", Offset = "0x3A09410", VA = "0x183A0A010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x3A09B50", Offset = "0x3A08F50", VA = "0x183A09B50")]
	public bool PGADOPELPNL(T MGNFAPLJAOB, object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x3A08180", Offset = "0x3A07580", VA = "0x183A08180")]
	public bool CAAPKADMLNG(object ANBIAABLBGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2EAAFC0", Offset = "0x2EAA3C0", VA = "0x182EAAFC0")]
	public void PDAIKLBALNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x3A07F00", Offset = "0x3A07300", VA = "0x183A07F00")]
	public bool BIAHFFMAKML(object ANBIAABLBGM, out T MGNFAPLJAOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x3A08F90", Offset = "0x3A08390", VA = "0x183A08F90")]
	private bool OODGOIDAKAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x3A0A050", Offset = "0x3A09450", VA = "0x183A0A050")]
	public ALLGLDPDFBM()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EB90", Offset = "0x4D1DF90", VA = "0x184D1EB90")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4D1EC90", Offset = "0x4D1E090", VA = "0x184D1EC90")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
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
