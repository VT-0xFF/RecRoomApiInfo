using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ARFaceCoefficients : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x313000", Offset = "0x312200", VA = "0x180313000")]
	public ARFaceCoefficients()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ARSelfieController : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x313000", Offset = "0x312200", VA = "0x180313000")]
	public ARSelfieController()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RequireComponent(typeof(ARFace))]
public class ARKitBlendShapeVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private float m_CoefficientScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ARFace m_Face;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float coefficientScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3485D0", Offset = "0x3477D0", VA = "0x1803485D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x917D50", Offset = "0x916F50", VA = "0x180917D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public SkinnedMeshRenderer skinnedMeshRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3163C0", Offset = "0x3155C0", VA = "0x1803163C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24326F0", Offset = "0x24318F0", VA = "0x1824326F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2432140", Offset = "0x2431340", VA = "0x182432140")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2432190", Offset = "0x2431390", VA = "0x182432190")]
	private void CreateFeatureBlendMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24324A0", Offset = "0x24316A0", VA = "0x1824324A0")]
	private void SetVisible(bool visible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24325F0", Offset = "0x24317F0", VA = "0x1824325F0")]
	private void UpdateVisibility()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2432300", Offset = "0x2431500", VA = "0x182432300")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2432240", Offset = "0x2431440", VA = "0x182432240")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24323C0", Offset = "0x24315C0", VA = "0x1824323C0")]
	private void OnSystemStateChanged(ARSessionStateChangedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24323D0", Offset = "0x24315D0", VA = "0x1824323D0")]
	private void OnUpdated(ARFaceUpdatedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2432530", Offset = "0x2431730", VA = "0x182432530")]
	private void UpdateFaceFeatures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24326E0", Offset = "0x24318E0", VA = "0x1824326E0")]
	public ARKitBlendShapeVisualizer()
	{
	}
}
namespace Cpp2IlInjected;

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
