shader_type spatial;

uniform sampler2D screen_texture : hint_screen_texture;
void vertex() {
	// Called for every vertex the material is visible on.
}

void fragment() {
	// Called for every pixel the material is visible on.
	ALBEDO = texture(screen_texture, SCREEN_UV).rgb;
	if (ALBEDO.r > 0.04 || ALBEDO.b > 0.04 || ALBEDO.g > 0.04) {
		ALBEDO = vec3(0.2,0.2,0.5);
		ALPHA = 1.0;
	} else {
		ALBEDO = vec3(0);
		ALPHA = 0.4;
	}
}

//void light() {
	// Called for every pixel for every light affecting the material.
	// Uncomment to replace the default light processing function with this one.
//}
